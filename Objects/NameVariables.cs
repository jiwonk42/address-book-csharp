using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private string _address;
    private int _id;
    private static List<Contact> _contact = new List<Contact> {};

    public Contact(string name, string phone, string address)
    {
      _name = name;
      _phone = phone;
      _address = address;
      _contact.Add(this);
      _id = _contact.Count;
    }
  }
}
