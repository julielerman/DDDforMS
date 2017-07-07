using SharedKernel;

namespace CustomerAccounts.Domain
{
  public class Address:ValueObject<Address>
  {
    public string Street { get; set; }
    public string CountryCode { get; set; }
  }
}