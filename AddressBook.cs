// UC-2:  Ability to add a new Contact to Address Book

using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    public class AddressBook
    {
        // Collection to store contacts
        private List<Contact> contacts = new List<Contact>();

        // Method to add a new contact
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine("Contact added successfully to Address Book.");
        }
    }
}
