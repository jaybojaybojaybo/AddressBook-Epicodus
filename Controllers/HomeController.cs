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
      return View();
    }
  }
}
