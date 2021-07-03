using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AddressBookSystem
{
    public class ContactDetails
    {
        public string firstName, lastName, address, city, state, zipCode, phoneNo, emailId;

        public ContactDetails()
        {
            firstName = "";
            lastName = "";
            address = "";
            city = "";
            state = "";
            zipCode = "";
            phoneNo = "";
            emailId = "";
        }
        public ContactDetails(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNo, string emailId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNo = phoneNo;
            this.emailId = emailId;
        }

    }
}