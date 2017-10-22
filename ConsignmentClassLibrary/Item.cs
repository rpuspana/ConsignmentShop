using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentClassLibrary
{
  public class Item
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool Sold { get; set; }
    public bool PaymentDistributed { get; set; }
    public Vendor Owner { get; set; }

    // create property for the itemsListbox.DisplayMember and itemsListbox.ValueMember
    // from the ConsignmentShop.cs
    public string Display
    {
      get
      {
        return string.Format("{0} - ${1}", Title, Price);
      }
    }
  }
}
