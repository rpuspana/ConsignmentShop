using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentClassLibrary
{
  public class Vendor
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Commision { get; set; }

    // *** not ideal for big apps ***
    // how much money this vendor must collect
    // because the store sold his products to customers
    public decimal PaymentDue { get; set; }

    public string Display
    {
      get
      {
        return string.Format("{0} {1} - ${2}", 
                              FirstName,
                              LastName,
                              PaymentDue);
      }
    }

    public Vendor()
    {
      // this.Commission = 0.5;
      Commision = 0.5;
    }
  }
}
