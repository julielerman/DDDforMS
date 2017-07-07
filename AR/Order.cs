using System;
using System.Collections.Generic;
using System.Linq;
using SharedKernel;

namespace AR.Domain
{
  public class Order:Entity
  {
    public static Order Create(Guid orderId, DateTime orderDate, Guid customerId, decimal orderTotal)
    {
      var order=new Order(orderId);
      order.OrderDate = orderDate;
      order.CustomerId = customerId;
      order.OrderTotal = orderTotal;

      return order;
    }
    public Order(Guid id)
       : base(id) {
    }

    



    public DateTime OrderDate { get; set; }
     public Guid CustomerId { get; set; }
    public decimal OrderTotal { get; set; }
    public DateTime PaidInFull { get; set; }
    public List<Payment> Payments { get; set; }
    public void PaymentMade(DateTime date, decimal amount)
    {
      Payments.Add(Payment.Create(Id, amount, date));
      if (Payments.Sum(p=>p.Amount)==OrderTotal)
      {
        PaidInFull = date;
      }
    }

  }
}