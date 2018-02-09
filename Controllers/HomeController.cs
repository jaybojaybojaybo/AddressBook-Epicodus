using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AddressBook.Models;

namespace AddressBook.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Contact> allContacts = Contact.GetAll();
      return View(allContacts);
    }

    [HttpPost("/contacts/List/Clear")]
    public ActionResult ContactListClear()
    {
      Contact.ClearAll();
      List<Contact> allContacts = Contact.GetAll();
      return View("Index", allContacts);
    }
  }
}
