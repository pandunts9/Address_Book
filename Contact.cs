using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    class Contact
    {
        public Guid Id { get; } = new Guid();
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Adress { get; set; }
        public int PhoneNumber { get; set; }
        public List<Contact> _contacts;

        public Contact()
        {

        }
        public Contact(string firstName, string lastName, string email,  int phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            _contacts = new List<Contact>();
        }
        public Contact(string firstName,string lastName,string email, string adress, int phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Adress = adress;
            PhoneNumber = phoneNumber;
            _contacts = new List<Contact>();
        }
    }
}
