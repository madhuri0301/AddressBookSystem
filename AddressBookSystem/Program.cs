using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Address Book System");

            // Create a list of contacts.
            List<ContactDetails> contacts = new List<ContactDetails>();
            ContactDetails contact = new ContactDetails();

            bool flag = true;
            int choice;
            while (flag)
            {
                Console.WriteLine("\n1. Display All Contacts\n2. Add New Contact\n3. Edit a Contact\n4. Exit");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    contact.DisplayContact();
                }
                else if (choice == 2)
                {
                    contact.AddNewContact();
                }
                else if (choice == 3)
                {
                    contact.EditContact();
                }
                else if (choice == 4)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
    }
}