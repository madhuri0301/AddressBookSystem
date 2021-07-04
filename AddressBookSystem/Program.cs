using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            int choice;
            string addBookName = "";

            SwitchAddressBook multipleAddressBooks = new SwitchAddressBook();
            Operations op = new Operations();
            AddressBook addressBook = null;

            Console.WriteLine("Welcome to The Address Book System");
            while (true)
            {
                Console.WriteLine("1.Add Address Book \n 2.Edit Or Add Contact in Address Book \n 3.View Persons By City \n 4.View Persons By State \n 5.Count By City \n 6.Count By State \n 7.Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter name of Address Book");
                        addBookName = Console.ReadLine();
                        multipleAddressBooks.AddAddressBook(addBookName);

                        break;
                    case 2:
                        Console.WriteLine("Enter Address Book to Store Contacts");
                        addBookName = Console.ReadLine();
                        addressBook = multipleAddressBooks.GetAddressBook(addBookName);

                        if (addressBook != null)
                        {
                            op.EditAddOrDeleteContact(addressBook);

                        }
                        else
                        {
                            Console.WriteLine("No such Adress Book");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter City");
                        string city = Console.ReadLine();
                        multipleAddressBooks.SetContactByCityDictionary();

                        multipleAddressBooks.ViewPersonsByCity(city);
                        break;
                    case 4:
                        Console.WriteLine("Enter State");
                        string state = Console.ReadLine();

                        multipleAddressBooks.SetContactByStateDictionary();
                        multipleAddressBooks.ViewPersonsByState(state);
                        break;
                    case 5:
                        multipleAddressBooks.SetContactByCityDictionary();
                        foreach (var contactByCity in multipleAddressBooks.ContactByCity)
                        {
                            Console.WriteLine("City :" + contactByCity.Key + "   Count :" + contactByCity.Value.Count);

                        }
                        break;
                    case 6:
                        multipleAddressBooks.SetContactByStateDictionary();
                        foreach (var contactByState in multipleAddressBooks.ContactByState)
                        {
                            Console.WriteLine("State :" + contactByState.Key + "   Count :" + contactByState.Value.Count);

                        }
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }         
        }
    }
}



