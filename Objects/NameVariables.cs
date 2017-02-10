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

    public string GetName()
    {
      return _name;
    }

    public string GetPhone()
    {
      return _phone;
    }

    public string GetAddress()
    {
      return _address;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Contact> GetAll()
    {
      return _contact;
    }

    public static void ClearAll()
    {
      _contact.Clear();
    }

    public static Contact Find(int id)
    {
      return _contact[id - 1];
    }
  }
}
