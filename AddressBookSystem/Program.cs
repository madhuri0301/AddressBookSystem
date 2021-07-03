using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name;
            int choice = 0;
            string[] details;
            bool flag = true;
            string addBookName ;

            SwitchAddressBook multipleAddressBooks = new SwitchAddressBook();
            AddressBook addressBook = null;

            Console.WriteLine("Welcome to The Address Book System");
            while (true)
            {
                try
                {
                    Console.WriteLine("1.Add Address Book \n2.Open Address Book");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter name of Address Book: ");
                            addBookName = Console.ReadLine();
                            multipleAddressBooks.AddAddressBook(addBookName);
                            addressBook = multipleAddressBooks.GetAddressBook(addBookName);
                            flag = true;
                            break;
                        case 2:
                            Console.WriteLine("Enter name of Address Book: ");
                            addBookName = Console.ReadLine();
                            addressBook = multipleAddressBooks.GetAddressBook(addBookName);
                            flag = true;
                            if (addressBook == null)
                            {
                                Console.WriteLine("No such Address Book!");
                                flag = false;
                            }
                            break;
                        default:
                            flag = false;
                            Console.WriteLine("Invalid Choice!");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid data entered! Error! " + e.Message + "\n" + e.StackTrace);
                }


                while (flag)
                {
                    try
                    {
                        Console.WriteLine("1.Add Contact\n2.Edit Contact\n3.Remove a contact\n4.Search Person By City Or State\n5.Exit");
                        choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the details separated by comma");
                                Console.WriteLine("First Name, Last Name, Address, City, State, ZipCode,Phone No, emailId");
                                details = Console.ReadLine().Split(",");

                                string message = addressBook.AddContact(details[0], details[1], details[2], details[3], details[4], details[5], details[6], details[7]);

                                Console.WriteLine(message);
                                break;
                            case 2:
                                Console.WriteLine("Enter the name to edit");
                                name = Console.ReadLine().Split(" ");

                                if (addressBook.CheckName(name[0], name[1]) == true)
                                {
                                    Console.WriteLine("Enter the following details separated by comma");
                                    Console.WriteLine("FirstName,LastName,Address, City, State, ZipCode,Phone No emailId");
                                    details = Console.ReadLine().Split(",");
                                    addressBook.EditContact(details[0], details[1], details[2], details[3], details[4], details[5], details[6], details[7]);
                                    Console.WriteLine("Details editted successfully");
                                }
                                else
                                {
                                    Console.WriteLine("No such contact found");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Enter the name to be removed");
                                name = Console.ReadLine().Split(" ");
                                if (addressBook.CheckName(name[0], name[1]) == true)
                                {
                                    addressBook.RemoveContact(name[0], name[1]);
                                    Console.WriteLine("Contact Removed Successfully");
                                }
                                else
                                {
                                    Console.WriteLine("No such contact found");
                                }
                                break;

                            case 4:
                                Console.WriteLine("Enter City or State");
                                string cityOrState = Console.ReadLine();

                                multipleAddressBooks.SearchPersonOverMultipleAddressBook(cityOrState);
                                break;

                            case 5:
                                flag = false;
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid data entered. Error: " + e.Message + "\n" + e.StackTrace);
                    }
                }
            }
        }
    }
}
