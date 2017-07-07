using System;
using System.Collections.Generic;

namespace ContactManagement.Domain
{
  public class Contact
  {
    public static Contact Create( string firstName, string lastName, string street, string city, string state)
    {
      return new Contact( firstName, lastName, street,city,state);
    }
    public static Contact Create( string firstName, string lastName) {
      return new Contact( firstName, lastName);
    }

  


    private Contact(string firstName, string lastName,  string street, string city, string state)
    {
      ContactId = Guid.NewGuid();
      FirstName = firstName;
      LastName = lastName;

      Addresses.Add(Address.Create(street, city, state, ContactId));

    }
  private Contact(string firstName, string lastName) {
    ContactId = Guid.NewGuid();
    FirstName = firstName;
    LastName = lastName;


  }
  public Guid ContactId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ContactDetail ContactDetail { get; private set; }

    public ICollection<Address> Addresses { get; set; }

    public string FullName => LastName.Trim() + ", " + FirstName;
  }
}