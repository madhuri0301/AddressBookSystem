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

            //Add New Contact
            contact.AddNewContact();

            //Display entered contacts
            contact.DisplayContact();
        }
    }
}
