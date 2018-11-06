using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManager.Models;
//using Microsoft.AspNetCore.Http;
using System.Web;
using ContactManager.Data;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Services
{
    public class ContactRepository
    {
        private const string CacheKey = "ContactStore";
        private readonly ContactContext _context;
        public ContactRepository(ContactContext context)
        {
            _context = context;
        }
        public Contact[] GetAllContacts()
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
        public bool SaveContact(Contact contact)
        {

            if (_context != null)
            {
                try
                {
                    _context.Add(contact);

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }

            return false;
        }
    }
}
