using System;
using AR.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AR.Test
{
  [TestClass]
  public class ARDomainTests
  {
    [TestMethod]
    public void CanCreateOrder()
    {
      var incomingOrderId = Guid.NewGuid();
      var order = Order.Create(incomingOrderId, DateTime.Now, Guid.NewGuid(), 100);
      Assert.AreEqual(incomingOrderId,order.Id);
    }
  }
}
