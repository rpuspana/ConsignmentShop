using ConsignmentClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
  public partial class ConsignmentShop : Form
  {
    // default access modifier for class members is private by default

    // test 2

    private Store store = new Store();

    // list of items selected by the user itemsListbox form
    // initially empty
    private List<Item> shoppingCartData = new List<Item>();

    private decimal storeProfit = 0;

    // var to bind the itemxListbox form to the store.Items list
    BindingSource itemsBinding = new BindingSource();

    // var to bind the ShoppingCartListbox form to the shoppingCartData
    BindingSource cartBinding = new BindingSource();

    // var to bind the vendorListbox form to our vendors
    BindingSource vendorsBinding = new BindingSource();

    public ConsignmentShop()
    {
      InitializeComponent();

      // create vendors and items
      SetupData();

      // links items that are not sold to the binding source
      // in this list there are only items that were not sold
      itemsBinding.DataSource = store.Items.Where(item => item.Sold == false).ToList();

      // link our form with instance id itemsListbox to this binding source
      // this puts the binding source in the middle between store.Items and the itemsListBox var from the UI
      itemsListbox.DataSource = itemsBinding;

      // give the itemsListBox one property to display for each item
      // "Display" = call getter for the Item.Display property
      itemsListbox.DisplayMember = "Display";
      itemsListbox.ValueMember = "Display";

      // binding data for the shopping cart
      cartBinding.DataSource = shoppingCartData;

      // link our form with id shoppingCartListBox to the binding source
      shoppingCartListBox.DataSource = cartBinding;

      // give the shoppingCartListBox one property to display for each item
      shoppingCartListBox.DisplayMember = "Display";
      shoppingCartListBox.ValueMember = "Display";

      vendorsBinding.DataSource = store.Vendors;
      vendorListbox.DataSource = vendorsBinding;

      // display full name and how much we own each vendor on the vendorListbox form
      vendorListbox.DisplayMember = "Display";
      vendorListbox.ValueMember = "Display";
    }

    // create some dummy store data to populate the items list in the interface
    private void SetupData()
    {
      store.Name = "Seconds are Better";

      store.Vendors.Add(
        // {firstName="Bill", lastName="Smith", commision=0.5} = once the Vendor instance is created put these values in for the instance's fields
        new Vendor
        {
          FirstName = "Bill",
          LastName = "Smith"
        });
      store.Vendors.Add(new Vendor
      {
        FirstName = "Sue",
        LastName = "Jones"
      });

      store.Items.Add(new Item
      {
        Title = "Moby Dick",
        Description = "A book about a whale",
        Price = 4.50M,
        Owner = store.Vendors[0]
      });

      store.Items.Add(new Item
      {
        Title = "A tale of two cities",
        Description = "A book about a revolution",
        Price = 3.80M,
        Owner = store.Vendors[1]
      });

      store.Items.Add(new Item
      {
        Title = "Harry Potter book 1",
        Description = "A book about a boy",
        Price = 5.20M,
        Owner = store.Vendors[1]
      });

      store.Items.Add(new Item
      {
        Title = "Jane Eyre",
        Description = "A book about a girl",
        Price = 1.50M,
        Owner = store.Vendors[0]
      });
    }

    // click event handler for the "Add to cart" button
    private void addToCart_Click(object sender, EventArgs e)
    {
      //MessageBox.Show("I have clicked");

      // figure out what is selected from the items list
      Item selectedItem = (Item) itemsListbox.SelectedItem;
      //MessageBox.Show("Selected item is " + selectedItem.Title);

      // if the selected item exists in the Store Items for
      if (selectedItem != null)
      {
        if (shoppingCartData.IndexOf(selectedItem) > -1)
        {
          MessageBox.Show("You can not add one more copy of {0} to the shopping cart.", selectedItem.Title);
        }
        else
        {
          // copy that item from the shopping cart
          shoppingCartData.Add(selectedItem);

          // tell the binding source to refresh, because the info has changed
          // false = data type of the items in the list shoppingCartData has not changed
          cartBinding.ResetBindings(false);

          // do we remove the item in the items list ?
        }
      }
      else
      {
        MessageBox.Show("There are no items to add to the shopping cart.");
      }
    }

    // click event handler for the "purchase" button
    private void makePurchase_Click(object sender, EventArgs e)
    {
      // Mark each item in the cart as sold
      foreach(Item item in shoppingCartData)
      {
        item.Sold = true;
        item.Owner.PaymentDue += (decimal)item.Owner.Commision * item.Price;
        storeProfit += (1 - (decimal)item.Owner.Commision) * item.Price;
      }

      // Clear the cart
      shoppingCartData.Clear();

      // links items that are not sold to the binding source
      // in this list there are only items that were not sold
      itemsBinding.DataSource = store.Items.Where(item => item.Sold == false).ToList();

      // tell the binding source to refresh, because the info has changed
      cartBinding.ResetBindings(false);

      // reset the binding of itemsBinding, because we changed the Sold fields for the bought items
      itemsBinding.ResetBindings(false);

      vendorsBinding.ResetBindings(false);

      storeProfitValue.Text = string.Format("${0}", storeProfit);



    }
  }
}
