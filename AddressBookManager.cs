using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    class AddressBookManager
    {
        private static List<Contact> _contacts = new List<Contact>();
        public void Create(Contact contact)
        {
            _contacts.Add(contact);
        }

        public Contact Get(String name)
        {
            for (int i = 0; i < _contacts.Count; i++)
            {
                if (_contacts[i].FirstName == name)
                    return _contacts[i];
            }
            return default(Contact);
        }

        public List<Contact> GetAll()
        {
            return _contacts;
        }

        public void Remove(Contact contact)
        {
            _contacts.Remove(contact);
        }

        public void Update(Contact contact)
        {
            for (int i = 0; i < _contacts.Count; i++)
            {
                if (_contacts[i].Id == contact.Id)
                {
                    _contacts[i] = contact;
                }
            }
        }

    }
}
