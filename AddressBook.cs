using System;
using System.Collections.Generic;
using System.Linq; // Added for sorting logic

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

        // UC11: Ability to sort the entries in the address book alphabetically by Person’s name
        public void SortByName()
        {
            // Use Collection Library for Sorting
            contacts = contacts.OrderBy(c => c.FirstName).ThenBy(c => c.LastName).ToList();
            Console.WriteLine("\nAddress Book sorted alphabetically by name.");
            DisplaySortedContacts();
        }

        // UC 12: Write functions to sort person by City, State or Zip
        public void SortByCity()
        {
            contacts = contacts.OrderBy(c => c.City).ToList();
            Console.WriteLine("\nAddress Book sorted by City.");
            DisplaySortedContacts();
        }

        public void SortByState()
        {
            contacts = contacts.OrderBy(c => c.State).ToList();
            Console.WriteLine("\nAddress Book sorted by State.");
            DisplaySortedContacts();
        }

        public void SortByZip()
        {
            contacts = contacts.OrderBy(c => c.Zip).ToList();
            Console.WriteLine("\nAddress Book sorted by Zip.");
            DisplaySortedContacts();
        }

        // Helper to Print Person Entry in Console using overridden toString method
        private void DisplaySortedContacts()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.ToString());
            }
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

        // UC8 & UC9: Expose contact list
        public List<Contact> GetContacts()
        {
            return contacts;
        }
    }
}