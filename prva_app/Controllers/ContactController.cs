using prva_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prva_app.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public Contact[] Get()
        {
            return new Contact[]
    {
        new Contact
        {
            Id = 1,
            Name = "Glenn Block"
        },
        new Contact
        {
            Id = 2,
            Name = "Dan Roth"
        }
    };
        }
    }

    
}