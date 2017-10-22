namespace ConsignmentShopUI
{
  partial class ConsignmentShop
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.headerText = new System.Windows.Forms.Label();
      this.itemsListbox = new System.Windows.Forms.ListBox();
      this.itemsListboxLabel = new System.Windows.Forms.Label();
      this.addToCart = new System.Windows.Forms.Button();
      this.shoppingCartListBoxLabel = new System.Windows.Forms.Label();
      this.shoppingCartListBox = new System.Windows.Forms.ListBox();
      this.makePurchase = new System.Windows.Forms.Button();
      this.VendorListboxLabel = new System.Windows.Forms.Label();
      this.vendorListbox = new System.Windows.Forms.ListBox();
      this.storeProfitLabel = new System.Windows.Forms.Label();
      this.storeProfitValue = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // headerText
      // 
      this.headerText.AutoSize = true;
      this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.192F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerText.Location = new System.Drawing.Point(12, 9);
      this.headerText.Name = "headerText";
      this.headerText.Size = new System.Drawing.Size(517, 48);
      this.headerText.TabIndex = 0;
      this.headerText.Text = "Consignment Shop Demo";
      // 
      // itemsListbox
      // 
      this.itemsListbox.FormattingEnabled = true;
      this.itemsListbox.ItemHeight = 25;
      this.itemsListbox.Location = new System.Drawing.Point(20, 100);
      this.itemsListbox.Name = "itemsListbox";
      this.itemsListbox.Size = new System.Drawing.Size(393, 254);
      this.itemsListbox.TabIndex = 1;
      // 
      // itemsListboxLabel
      // 
      this.itemsListboxLabel.AutoSize = true;
      this.itemsListboxLabel.Location = new System.Drawing.Point(15, 72);
      this.itemsListboxLabel.Name = "itemsListboxLabel";
      this.itemsListboxLabel.Size = new System.Drawing.Size(120, 25);
      this.itemsListboxLabel.TabIndex = 2;
      this.itemsListboxLabel.Text = "Store Items";
      // 
      // addToCart
      // 
      this.addToCart.Location = new System.Drawing.Point(444, 199);
      this.addToCart.Name = "addToCart";
      this.addToCart.Size = new System.Drawing.Size(171, 51);
      this.addToCart.TabIndex = 3;
      this.addToCart.Text = "Add To Cart ->";
      this.addToCart.UseVisualStyleBackColor = true;
      this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
      // 
      // shoppingCartListBoxLabel
      // 
      this.shoppingCartListBoxLabel.AutoSize = true;
      this.shoppingCartListBoxLabel.Location = new System.Drawing.Point(642, 72);
      this.shoppingCartListBoxLabel.Name = "shoppingCartListBoxLabel";
      this.shoppingCartListBoxLabel.Size = new System.Drawing.Size(149, 25);
      this.shoppingCartListBoxLabel.TabIndex = 5;
      this.shoppingCartListBoxLabel.Text = "Shopping Cart";
      // 
      // shoppingCartListBox
      // 
      this.shoppingCartListBox.FormattingEnabled = true;
      this.shoppingCartListBox.ItemHeight = 25;
      this.shoppingCartListBox.Location = new System.Drawing.Point(647, 100);
      this.shoppingCartListBox.Name = "shoppingCartListBox";
      this.shoppingCartListBox.Size = new System.Drawing.Size(393, 254);
      this.shoppingCartListBox.TabIndex = 4;
      // 
      // makePurchase
      // 
      this.makePurchase.Location = new System.Drawing.Point(647, 371);
      this.makePurchase.Name = "makePurchase";
      this.makePurchase.Size = new System.Drawing.Size(393, 31);
      this.makePurchase.TabIndex = 6;
      this.makePurchase.Text = "Purchase";
      this.makePurchase.UseVisualStyleBackColor = true;
      this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
      // 
      // VendorListboxLabel
      // 
      this.VendorListboxLabel.AutoSize = true;
      this.VendorListboxLabel.Location = new System.Drawing.Point(15, 430);
      this.VendorListboxLabel.Name = "VendorListboxLabel";
      this.VendorListboxLabel.Size = new System.Drawing.Size(92, 25);
      this.VendorListboxLabel.TabIndex = 8;
      this.VendorListboxLabel.Text = "Vendors";
      // 
      // vendorListbox
      // 
      this.vendorListbox.FormattingEnabled = true;
      this.vendorListbox.ItemHeight = 25;
      this.vendorListbox.Location = new System.Drawing.Point(20, 458);
      this.vendorListbox.Name = "vendorListbox";
      this.vendorListbox.Size = new System.Drawing.Size(393, 229);
      this.vendorListbox.TabIndex = 7;
      // 
      // storeProfitLabel
      // 
      this.storeProfitLabel.AutoSize = true;
      this.storeProfitLabel.Location = new System.Drawing.Point(642, 430);
      this.storeProfitLabel.Name = "storeProfitLabel";
      this.storeProfitLabel.Size = new System.Drawing.Size(119, 25);
      this.storeProfitLabel.TabIndex = 9;
      this.storeProfitLabel.Text = "Store Profit";
      // 
      // storeProfitValue
      // 
      this.storeProfitValue.AutoSize = true;
      this.storeProfitValue.Location = new System.Drawing.Point(799, 430);
      this.storeProfitValue.Name = "storeProfitValue";
      this.storeProfitValue.Size = new System.Drawing.Size(66, 25);
      this.storeProfitValue.TabIndex = 10;
      this.storeProfitValue.Text = "$0.00";
      // 
      // ConsignmentShop
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1052, 754);
      this.Controls.Add(this.storeProfitValue);
      this.Controls.Add(this.storeProfitLabel);
      this.Controls.Add(this.VendorListboxLabel);
      this.Controls.Add(this.vendorListbox);
      this.Controls.Add(this.makePurchase);
      this.Controls.Add(this.shoppingCartListBoxLabel);
      this.Controls.Add(this.shoppingCartListBox);
      this.Controls.Add(this.addToCart);
      this.Controls.Add(this.itemsListboxLabel);
      this.Controls.Add(this.itemsListbox);
      this.Controls.Add(this.headerText);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "ConsignmentShop";
      this.Text = "Consignment Shop Demo";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerText;
    private System.Windows.Forms.ListBox itemsListbox;
    private System.Windows.Forms.Label itemsListboxLabel;
    private System.Windows.Forms.Button addToCart;
    private System.Windows.Forms.Label shoppingCartListBoxLabel;
    private System.Windows.Forms.ListBox shoppingCartListBox;
    private System.Windows.Forms.Button makePurchase;
    private System.Windows.Forms.Label VendorListboxLabel;
    private System.Windows.Forms.ListBox vendorListbox;
    private System.Windows.Forms.Label storeProfitLabel;
    private System.Windows.Forms.Label storeProfitValue;
  }
}

