using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class ContactDetails
    {
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
    }

}

