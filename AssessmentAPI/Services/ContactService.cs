using AssessmentAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentAPI.Services
{
    public class ContactService : IContactService
    {
        private DataContext _db;
        public ContactService()
        {
            _db = new DataContext();
        }
        public bool AddContact(Contact contact)
        {
            _db.Contacts.Add(contact);
            _db.SaveChanges();

            return true;
        }

        public bool DeleteContact(int id)
        {
            var contactToDelete = _db.Contacts.SingleOrDefault(c => c.ID == id);

            if(contactToDelete != null)
            {
                _db.Contacts.Remove(contactToDelete);
                _db.SaveChanges();
                return true;
            }

            return false;
        }

        public List<Contact> GetContacts()
        {
            return _db.Contacts.ToList();
        }

        public Contact GetContact(int id)
        {
            var contactToGet = _db.Contacts.SingleOrDefault(c => c.ID == id);

            return contactToGet;
        }

        public bool UpdateContact(Contact data)
        {
            var contact = CopyFrom(data);

            if (contact != null)
            {
                _db.SaveChanges();
                return true;
            }

            return false;
        }

        private Contact CopyFrom(Contact data)
        {
            var contactToEdit = _db.Contacts.SingleOrDefault(c => c.ID == data.ID);

            if(contactToEdit != null)
            {
                contactToEdit.FirstName = data.FirstName;
                contactToEdit.LastName = data.LastName;
                contactToEdit.PhoneNumber = data.PhoneNumber;
                contactToEdit.Line1 = data.Line1;
                contactToEdit.Line2 = data.Line2;
                contactToEdit.City = data.City;
                contactToEdit.State = data.State;
                contactToEdit.ZipCode = data.ZipCode;
            }

            return contactToEdit;
        }
    }
}
