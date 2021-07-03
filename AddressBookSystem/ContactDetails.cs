using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
        //Function to add new contact
        public void AddNewContact()
        {

            bool check = false;
            ContactDetails contact = new ContactDetails();
            //Firstname Input
            string namePattern = "^[a-zA-Z ]+$";
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            if (!Regex.IsMatch(firstName, namePattern))
                throw new Exception("Name should be alphabetical!");
            else
                contact.firstName = firstName;
            //Lastname Input
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
            if (!Regex.IsMatch(lastName, namePattern))
                throw new Exception("Name should be alphabetical!");
            else
                contact.lastName = lastName;
            ///<summary>
            ///Checking for duplicate entry
            ///</summary>
            foreach (ContactDetails con in contacts)
            {
                if (con.firstName.ToUpper().Equals(firstName.ToUpper()) && con.lastName.ToUpper().Equals(lastName.ToUpper()))
                {
                    Console.WriteLine("Name Alreaqdy exists in the system! Enter Different name!");
                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                //Address Input
                string addressPattern = "^[a-zA-Z0-9 ]+$";
                Console.WriteLine("Enter Address:");
                string address = Console.ReadLine();
                if (!Regex.IsMatch(address, addressPattern))
                    throw new Exception("Address should be in proper format!");
                else
                    contact.address = address;
                //City Input
                Console.WriteLine("Enter City: ");
                string city = Console.ReadLine();
                if (!Regex.IsMatch(city, namePattern))
                    throw new Exception("City name should be in proper format!");
                else
                    contact.city = city;
                //State Input
                Console.WriteLine("Enter State: ");
                string state = Console.ReadLine();
                if (!Regex.IsMatch(state, namePattern))
                    throw new Exception("State should be in proper format!");
                else
                    contact.state = state;
                //Zip code Input
                string zipPattern = "[0-9]{6}";
                Console.WriteLine("Enter ZIP Code: ");
                string zip = Console.ReadLine();
                if (!Regex.IsMatch(zip, zipPattern))
                    throw new Exception("ZIP Code should be a 6 digit number");
                else
                    contact.zipCode = int.Parse(zip);
                //Phone Number Input
                string phonePattern = "[0-9]{10}";
                Console.Write("Enter Phone Number: ");
                string phNumber = Console.ReadLine();
                if (!Regex.IsMatch(phNumber, phonePattern))
                    throw new Exception("Phone number must be a 10 digit number!");
                else
                    contact.phoneNumber = long.Parse(phNumber);

                //EmailId Input
                string mailPattern = @"[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
                Console.Write("Enter Email Id: ");
                string mailId = Console.ReadLine();
                if (!Regex.IsMatch(mailId, mailPattern))
                    throw new Exception("Check Mail address");
                else
                    contact.emailId = mailId;
                //Contact Added
                contacts.Add(contact);
                Console.WriteLine("New Contact added successfully");
            }
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
        public void EditContact()
        {
            Console.WriteLine("Enter the first name of the person: ");
            string fName = Console.ReadLine();
            foreach (ContactDetails c in contacts)
            {
                if (c.firstName.Equals(fName))
                {
                    int editChoice = 0;
                    while (editChoice != 9)
                    {
                        Console.WriteLine("Enter the following choice");
                        Console.WriteLine("1. Edit First Name");
                        Console.WriteLine("2. Edit Last Name");
                        Console.WriteLine("3. Edit Address");
                        Console.WriteLine("4. Edit City");
                        Console.WriteLine("5. Edit State");
                        Console.WriteLine("6. Edit Zip");
                        Console.WriteLine("7. Edit Phone Number");
                        Console.WriteLine("8. Edit E-mail");
                        Console.WriteLine("9. Exit");
                        Console.WriteLine("Enter your choice: ");
                        editChoice = Convert.ToInt32(Console.ReadLine());

                        switch (editChoice)
                        {
                            case 1:
                                Console.WriteLine("1. Edit First Name");
                                string fname = Console.ReadLine();
                                c.firstName = fname;
                                Console.WriteLine("Edited Successfully");
                                break;
                            case 2:
                                Console.WriteLine("1. Edit Last Name");
                                string lname = Console.ReadLine();
                                c.lastName = lname;
                                Console.WriteLine("Edited Successfully");
                                break;
                            case 3:
                                Console.WriteLine("1. Edit Address Name");
                                string aAddress = Console.ReadLine();
                                c.address = aAddress;
                                Console.WriteLine("Edited Successfully");
                                break;
                            case 4:
                                Console.WriteLine("1. Edit City Name");
                                string cCity = Console.ReadLine();
                                c.city = cCity;
                                Console.WriteLine("Edited Successfully");
                                break;
                            case 5:
                                Console.WriteLine("1. Edit State");
                                string sState = Console.ReadLine();
                                c.state = sState;
                                Console.WriteLine("Edited Successfully");
                                break;
                            case 6:
                                Console.WriteLine("1. Edit Zip");
                                int zCode = Convert.ToInt32(Console.ReadLine());
                                c.zipCode = zCode;
                                Console.WriteLine("Edited Successfully");
                                break;
                            case 7:
                                Console.WriteLine("1. Edit Phone Number");
                                long phNum = Convert.ToInt64(Console.ReadLine());
                                c.phoneNumber = phNum;
                                Console.WriteLine("Edited Successfully");
                                break;
                            case 8:
                                Console.WriteLine("1. Edit Email");
                                string mail = Console.ReadLine();
                                c.emailId = mail;
                                Console.WriteLine("Edited Successfully");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid name");
                }

            }
        }
        //Function to Delete Contact 
        public void DeleteContact()
        {
            Console.WriteLine("Enter the first name of the person: ");
            string fName = Console.ReadLine();
            List<ContactDetails> con = new List<ContactDetails>();
            foreach (ContactDetails c in contacts)
            {
                if (c.firstName.Equals(fName))
                {
                    con.Add(c);
                }
            }
            contacts.RemoveAll(i => con.Contains(i));
            Console.WriteLine("Contact Removed Successfully");
        }
    }
}
