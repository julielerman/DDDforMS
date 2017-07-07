using System;

namespace AllMyBusiness.Domain
{
  public class Payment {
    public int PaymentId { get; set; }
    public int OrderId { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    // public Order Order { get; set; }
  }
}