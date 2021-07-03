using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class SwitchAddressBook
    {
        Dictionary<string, AddressBook> addressBooksCollection = new Dictionary<string, AddressBook>();
        public SwitchAddressBook()
        {
            addressBooksCollection = new Dictionary<string, AddressBook>();
        }
        public void AddAddressBook(string name)
        {
            AddressBook addressBook = new AddressBook();
            addressBooksCollection.Add(name, addressBook);

        }
        public AddressBook GetAddressBook(string name)
        {
            if (addressBooksCollection.ContainsKey(name))
            {
                return addressBooksCollection[name];
            }
            return null;
        }
        public void SearchPersonOverMultipleAddressBook(string cityOrState)
        {
            Dictionary<string, AddressBook>.Enumerator enumerator = addressBooksCollection.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine("AddressBook Nmae :" + enumerator.Current.Key);
                Console.WriteLine();
                enumerator.Current.Value.SearchContactByCityOrState(cityOrState);
                Console.WriteLine();
            }
        }
    }
}

