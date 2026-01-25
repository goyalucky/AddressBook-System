using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    public class AddressBook
    {
        private List<Contact> contacts = new List<Contact>();

        // UC7 & UC9: Modified to return bool to facilitate dictionary updates in Main
        public bool AddContact(Contact contact)
        {
            if (contacts.Contains(contact))
            {
                Console.WriteLine("Duplicate contact found! Contact not added.");
                return false;
            }

            contacts.Add(contact);
            Console.WriteLine("Contact added successfully.");
            return true;
        }

        // UC3: Edit Contact
        public void EditContact(string firstName, string lastName)
        {
            foreach (Contact contact in contacts)
            {
                if (contact.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) && 
                    contact.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter new Address: "); contact.Address = Console.ReadLine();
                    Console.Write("Enter new City: "); contact.City = Console.ReadLine();
                    Console.Write("Enter new State: "); contact.State = Console.ReadLine();
                    Console.Write("Enter new Zip: "); contact.Zip = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter new Phone: "); contact.Phone = Console.ReadLine();
                    Console.Write("Enter new Email: "); contact.Email = Console.ReadLine();

                    Console.WriteLine("Contact updated successfully.");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }

        // UC4: Delete Contact
        public void DeleteContact(string firstName, string lastName)
        {
            Contact contactToRemove = contacts.Find(c => 
                c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) && 
                c.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));

            if (contactToRemove != null)
            {
                contacts.Remove(contactToRemove);
                Console.WriteLine("Contact deleted successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        // UC8 & UC9: Expose contact list for searching and dictionary mapping
        public List<Contact> GetContacts()
        {
            return contacts;
        }
    }
}