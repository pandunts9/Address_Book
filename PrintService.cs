using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    class PrintService
    {
        public void PrintContact(Contact contact)
        {
            Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}\n" +
                $"Email: {contact.Email}\nAddress: {contact.Adress}\nPhone: {contact.PhoneNumber}");
        }
        public void PrintAll(List<Contact> contacts)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                PrintContact(contacts[i]);
            }
        }
    }
}
