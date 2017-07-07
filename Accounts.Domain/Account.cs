using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using SharedKernel;

namespace CustomerAccounts.Domain

{
  public class Account : Entity
  {
    public static Account Create(Guid customerId, string customerFirstName, string customerLastName,
      Address billingAddress)
    {
      var account = new Account(Guid.NewGuid());
      account.FirstName = customerFirstName;
      account.LastName = customerLastName;
      account.BillingAddress = billingAddress;
      return account;
    }


    private Account(Guid id)
      : base(id)
    {
    }


    public Guid CustomerId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public CustomerCreditCard CreditCard { get; private set; }
    public CreditProfile CreditProfile { get; private set; }
    public Address BillingAddress { get; private set; }



    public string FullName
    {
      get { return LastName.Trim() + ", " + FirstName; }
    }

    public void ProvideCreditCardInfo(CustomerCreditCard card)
    {
      CreditCard = card;
    }

    public void ProvideCreditProfile(CreditProfile profile)
    {
      CreditProfile = profile;
    }
  }
}