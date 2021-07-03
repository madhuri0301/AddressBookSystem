using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    public class ContactDetails
    {
        List<ContactDetails> contacts = new List<ContactDetails>();
        // Creating setter and getter for each property  
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipCode { get; set; }
        public long phoneNumber { get; set; }
        public string emailId { get; set; }

        public ContactDetails()
        {

        }
        public ContactDetails(string firstName, string lastName, string address, string city, string state, int zipCode, long phoneNumber, string emailId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.emailId = emailId;

        }
        public void display()
        {
            Console.WriteLine(firstName + " " + lastName + " " + address + " " + city + " " + state + " " + zipCode + " " + phoneNumber + " " + emailId);
        }
        public void AddNewContact()
        {
            ContactDetails contact = new ContactDetails();
            Console.Write("Enter First Name: ");
            contact.firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            contact.lastName = Console.ReadLine();
            Console.Write("Enter Address:");
            contact.address = Console.ReadLine();
            Console.Write("Enter City: ");
            contact.city = Console.ReadLine();
            Console.Write("Enter State: ");
            contact.state = Console.ReadLine();
            Console.Write("Enter ZIP Code: ");
            contact.zipCode = int.Parse(Console.ReadLine());
            Console.Write("Enter Phone Number: ");
            contact.phoneNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter Email Id: ");
            contact.emailId = Console.ReadLine();
            Console.WriteLine();

            contacts.Add(contact);
            Console.WriteLine("**New Contact added successfully**");
            Console.WriteLine();
        }
        public void DisplayContact()
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine("First Name:" + contacts[i].firstName);
                Console.WriteLine("Last Name:" + contacts[i].lastName);
                Console.WriteLine("Address:" + contacts[i].address);
                Console.WriteLine("City:" + contacts[i].city);
                Console.WriteLine("State:" + contacts[i].state);
                Console.WriteLine("Zip Code:" + contacts[i].zipCode);
                Console.WriteLine("Phone No:" + contacts[i].phoneNumber);
                Console.WriteLine("Email ID:" + contacts[i].emailId);
                Console.WriteLine();

            }
        }
    }
}
