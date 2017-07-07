using System;
using System.Collections.Generic;

namespace AllMyBusiness.Domain
{
  public class Customer
  {
    private ICollection<Address> _addresses;
    private ICollection<Order> _orders;

    public Customer()
    {
      FirstName = "";
      LastName = "";
      DateOfBirth = DateTime.Today;
      _orders = new List<Order>();
      _addresses = new List<Address>();
    }

    public int CustomerId { get; set; }
  
   
    public CustomerCreditCard CreditCard { get; set; }
    public CreditProfile CreditProfile { get; set; }

    public ICollection<Order> Orders
    {
      get { return _orders; }
      set { _orders = value; }
    }

    public ICollection<Address> Addresses
    {
      get { return _addresses; }
      set { _addresses = value; }
    }

    public string FullName
    {
      get { return LastName.Trim() + ", " + FirstName; }
    }

    public string CustomerCookie { get; set; }
  }
}