using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace contact_list.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactListController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Contact> GetContacts()
        {
            Contact[] contacts = new Contact[]
            {
                    new Contact { id = 1, fullname = "Renjith", email = "rmshaji@gmail.com"},
                    new Contact { id = 2, fullname = "SHamnad", email = "shamnad@mail.com"},
                    new Contact { id = 3, fullname = "vishnu", email = "vishnu@gmail.com "},
                    new Contact { id = 4, fullname = "Dona", email = "dona@gmail.com "},
                    new Contact { id = 5, fullname = "praphul", email = "praphul@gmail.in "},
            };
            return contacts;
        }

        public class Contact
        {
            public int id { get; set; }
            public string fullname { get; set; }
            public string email { get; set; }
        }
    }
}