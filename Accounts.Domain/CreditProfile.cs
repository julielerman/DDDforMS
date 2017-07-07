using System;


namespace CustomerAccounts.Domain
{
  public class CreditProfile {
    public Guid Id { get; set; }
    public AccountHolder AccountHolder { get; set; }
  }

  public class AccountHolder {
    public Guid ContactId { get; set; }
  }
}