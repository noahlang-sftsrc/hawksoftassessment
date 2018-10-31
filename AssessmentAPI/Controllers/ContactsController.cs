using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentAPI.Data;
using AssessmentAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentAPI.Controllers
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        // GET api/contacts
        [HttpGet]
        public ActionResult<List<Contact>> GetAll()
        {
            var contacts = _contactService.GetContacts();
            if (contacts.Count == 0)
            {
                return NotFound();
            }

            return contacts;
        }

        // GET api/contacts/5
        [HttpGet("{id}")]
        public ActionResult<Contact> Get(int id)
        {
            var contact = _contactService.GetContact(id);

            if (contact == null)
            {
                return NotFound();
            }

            return contact;
        }

        // POST api/contacts
        [HttpPost("add")]
        public void Add([FromBody] Contact value)
        {
            _contactService.AddContact(value);
        }

        // PUT api/contacts/5
        [HttpPut("update/{id}")]
        public void Update(int id, [FromBody] Contact value)
        {
            _contactService.UpdateContact(value);
        }

        // DELETE api/contacts/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _contactService.DeleteContact(id);
        }
    }
}
