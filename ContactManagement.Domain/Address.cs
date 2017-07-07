

using System;

namespace ContactManagement.Domain
{
  public class Address
  {
    public static Address Create(string street, string city, string stateProvince, Guid contactId)
    {
      return new Address(street, city, stateProvince, contactId);
    }

    private Address(string street, string city, string stateProvince, Guid contactId)
    {
      AddressId =  Guid.NewGuid();
      Street = street;
      City = city;
      StateProvince = stateProvince;
    
      ContactId = contactId;
    }

    public Guid AddressId { get; private set; }
    public string Street { get; private set; }
    public string City { get; private set; }
    public string StateProvince { get; private set; }
   // public string PostalCode { get; private set; }
    public Guid ContactId { get; private set; }
  }
} 