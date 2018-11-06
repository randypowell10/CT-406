using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContactManager.Models;
using ContactManager.Services;
using ContactManager.Data;

namespace ContactManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        //private ContactRepository contactRepository;
        private readonly ContactContext _context;
        public ContactController(ContactContext context) {
            _context = context;
        }
        [HttpGet]
        public Contact[] Get()
        {
            var contacts = _context.Contacts.ToArray();
            if (_context != null)
            {
                return contacts;
            }

            return new Contact[]
                {
                    new Contact
                    {
                        Id = 0,
                        Name = "Placeholder"
                    }
                };
        }
        [HttpPost]
        public ActionResult Post(Contact contact)
        {
            _context.Add(contact);
            _context.SaveChanges();
            return Ok(contact);
        }
    }
}