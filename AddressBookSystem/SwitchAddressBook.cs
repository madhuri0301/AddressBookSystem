using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class SwitchAddressBook
    {
        Dictionary<string, ContactDetails> switchaddressbook = new Dictionary<string, ContactDetails>();

        public void AddNewAddressBook(string addressBookName, ContactDetails addressBook)
        {
            switchaddressbook.Add(addressBookName, addressBook);
        }

        public ContactDetails GetAddressBook(string name)
        {
            foreach (var item in switchaddressbook)
            {
                if (item.Key == name)
                    return item.Value;
            }
            return null;
        }
    }
}
