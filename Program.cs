using System;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookManager manager = new AddressBookManager();
            PrintService printer = new PrintService();

            Console.WriteLine("Enter contacts count to create!");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter First name!");
                String firstName = Console.ReadLine();
                Console.WriteLine("Enter Last name!");
                String lastName = Console.ReadLine();
                Console.WriteLine("Enter Email!");
                String email = Console.ReadLine();
                Console.WriteLine("Enter Phone number!");
                int phoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Address!(not mandatory) \n press ENTER to skip...");
                String address = Console.ReadLine();
                if(address.Length == 0)
                {
                    manager.Create(new Contact(firstName, lastName, email, phoneNumber));
                }
                else
                {
                    manager.Create(new Contact(firstName, lastName, email,address, phoneNumber));
                }
                Console.Clear();
            }

            printer.PrintAll(manager.GetAll());
            manager.Remove(manager.Get("Ali"));
            printer.PrintContact(manager.Get("Narek"));

            
        }
    }
}
