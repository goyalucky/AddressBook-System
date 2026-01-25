using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    public class AddressBook
    {
        private List<Contact> contacts = new List<Contact>();

        // UC7: Prevent Duplicate Contact
        public void AddContact(Contact contact)
        {
            if (contacts.Contains(contact))
            {
                Console.WriteLine("Duplicate contact found! Contact not added.");
                return;
            }

            contacts.Add(contact);
            Console.WriteLine("Contact added successfully.");
        }

        // UC3: Edit Contact
        public void EditContact(string firstName, string lastName)
        {
            foreach (Contact contact in contacts)
            {
                if (contact.FirstName == firstName && contact.LastName == lastName)
                {
                    Console.Write("Enter new Address: ");
                    contact.Address = Console.ReadLine();

                    Console.Write("Enter new City: ");
                    contact.City = Console.ReadLine();

                    Console.Write("Enter new State: ");
                    contact.State = Console.ReadLine();

                    Console.Write("Enter new Zip: ");
                    contact.Zip = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter new Phone: ");
                    contact.Phone = Console.ReadLine();

                    Console.Write("Enter new Email: ");
                    contact.Email = Console.ReadLine();

                    Console.WriteLine("Contact updated successfully.");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }

        // UC4: Delete Contact
        public void DeleteContact(string firstName, string lastName)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].FirstName == firstName &&
                    contacts[i].LastName == lastName)
                {
                    contacts.RemoveAt(i);
                    Console.WriteLine("Contact deleted successfully.");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }
    }
}
