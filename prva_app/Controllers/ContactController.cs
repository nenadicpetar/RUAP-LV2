using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using prva_app.Services;

namespace prva_app.Controllers
{
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }
        public prva_app.Models.Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }
    }


}
