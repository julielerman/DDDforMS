using System;
using AR.Domain;

namespace AR.Service.Controllers
{
  public class SomeRepo
  {
    public Order GetOrder(Guid orderId)
    {
      //fake an order retrieved from some data store
      return Order.Create(orderId, DateTime.Now, Guid.NewGuid(), 100);
    }

    public void RecordOrder(Order order)
    {
      //persist the order data into some data store

      //or with an event store system, record the event (added, with the data)

      //or ...
      
    }
  }
}