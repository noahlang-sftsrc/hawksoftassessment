using AssessmentAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentAPI.Services
{
    public interface IContactService
    {
        List<Contact> GetContacts();
        Contact GetContact(int id);
        bool AddContact(Contact contact);
        bool DeleteContact(int id);
        bool UpdateContact(Contact contact);
    }
}
