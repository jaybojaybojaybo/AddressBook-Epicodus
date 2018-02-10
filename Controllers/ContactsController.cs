using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AddressBook.Models;

namespace AddressBook.Controllers
{
  public class ContactsController : Controller
  {
    [HttpGet("/contacts")]
    public ActionResult Index()
    {
      List<Contact> allContacts = Contact.GetAll();
      return View("~/Views/Home/Index.cshtml", allContacts);
    }

    [HttpGet("/contacts/new")]
    public ActionResult CreateForm()
    {
      List<Contact> allContacts = Contact.GetAll();
      return View(allContacts);
    }

    [HttpPost("/contacts")]
    public ActionResult Create()
    {
      Contact newContact = new Contact(
        Request.Form["contactName"],
        Request.Form["contactPhone"],
        Request.Form["contactAddress"]
        );
      List<Contact> allContacts = Contact.GetAll();
      return View("~/Views/Home/Index.cshtml", allContacts);
    }

    [HttpGet("/contacts/{id}")]
    public ActionResult Details(int id)
    {
      Contact newContact = Contact.Find(id);
      return View(newContact);
    }

    [HttpPost("/remove/{id}")]
    public ActionResult RemoveContact(int id)
    {
      Contact deletedContact = Contact.Find(id);
      int deletedId = id - 1;
      deletedContact.ClearContact(deletedId);
      List<Contact> allContacts = Contact.GetAll();
      return View("~/Views/Home/Index.cshtml", allContacts);
    }
  }
}
