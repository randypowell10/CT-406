using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManager.Models;

namespace ContactManager.Data
{
    public class DbInitializer
    {
        public static void Initialize(ContactContext context)
        {
            //context.Database.EnsureCreated();
            if (context.Contacts.Any())
            {
                return;   // DB has been seeded
            }
            var contacts = new Contact[]
            {
            new Contact{Name="Carson"},
            new Contact{Name="Charles"},
            new Contact{Name="George"},
            new Contact{Name="Stephen"}
            };
            foreach (Contact s in contacts)
            {
                context.Contacts.Add(s);
            }
            context.SaveChanges();
        }
    }
}
