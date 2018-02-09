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
      return View();
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
    public ActionResult Details()
    {
      return View();
    }
  }
}
