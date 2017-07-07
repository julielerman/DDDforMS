using AR.Domain;

using System;
using System.Collections.Generic;

using System.Web.Http;

namespace AR.Service.Controllers
{
  [Route("api/[controller]")]
  public class AccountReceivableController : ApiController
  {
    private readonly SomeRepo _someRepo;

    public AccountReceivableController(SomeRepo someRepo) {
      _someRepo = someRepo;
    }

   

    [HttpPost]
    public void RecordOrder(DateTime orderDate, Guid orderId, decimal amount, Guid customerId) {
      var order=Order.Create(orderId, orderDate, customerId, amount);
      //persist to data store
      _someRepo.RecordOrder(order);
    }

    [HttpPost]
    public void RecordPayment(Guid orderId, decimal paymentAmount, DateTime dateOfPayment) {
      var order = _someRepo.GetOrder(orderId);

      order.PaymentMade(dateOfPayment, paymentAmount);
      //if order is now paid in full, there could be logic to raise that event
    }
  }
}