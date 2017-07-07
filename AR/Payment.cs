using System;

namespace AR.Domain
{
  public class Payment {
    protected internal static Payment Create( Guid orderId, decimal amount, DateTime date)
    {
      return new Payment( orderId, amount, date);
    }

    public Guid PaymentId { get; set; }
    public Guid OrderId { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }

    private Payment( Guid orderId, decimal amount, DateTime date)
    {
      PaymentId = Guid.NewGuid();
      OrderId = orderId;
      Amount = amount;
      Date = date;
    }
  }
}