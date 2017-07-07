using System;
using System.Collections.Generic;

namespace AllMyBusiness.Domain
{
  public class Order
  {
    public static Order Create(Guid orderId, DateTime orderDate, int customerId, decimal orderTotal)
    {
      return new Order(orderId, orderDate, customerId, orderTotal);
    }

    private ICollection<LineItem> _lineItems;

    public Order()
    {
      OrderDate = DateTime.Now.Date;
      _lineItems = new List<LineItem>();
    }

    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
     public int CustomerId { get; set; }
    

    public Customer Customer { get; set; }

    public ICollection<LineItem> LineItems
    {
      get { return _lineItems; }
      set { _lineItems = value; }
    }
  }
}