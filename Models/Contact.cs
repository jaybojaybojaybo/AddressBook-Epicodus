using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private int _id;

    private static List<Contact> _instances = new List<Contact> {};

    public Contact(string name)
    {
      _name = name;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetName();
    {
      return _name;
    }
    public void SetName(string name)
    {
      _name = name;
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }

    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public int GetId()
    {
      return _id;
    }
  }
}
