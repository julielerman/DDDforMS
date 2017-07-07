using System;

namespace CustomerAccounts.Domain {
  public class CustomerCreditCard {
    public CustomerCreditCard(int customerID, string cardNumber, string bank,string securityCode) {
      LastFourOfNumber = cardNumber.Substring(cardNumber.Length - 4);
      Bank = bank;
      CustomerId = customerID;
      Id = Guid.NewGuid();
      SecurityCode = securityCode;
      //verify
      //SomeExternalService.VerifyCreditCardDetails(cardNumber, bank, customerID, securityCode);
    }
    public Guid Id  { get; private set; }
    public int CustomerId { get; private set; }
    public string LastFourOfNumber { get; private set; }
    public string Bank { get; private set; }
    public string SecurityCode { get; private set; }
  }
}