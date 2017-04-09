﻿using ContactsApp.model;
using System.Collections.Generic;

namespace ContactsApp.Services
{
    public interface IContactService
    {
        List<Contact> FindAllContacts();
        Contact FindContactById(int id);
        void SaveContact(Contact contact);
    }
}