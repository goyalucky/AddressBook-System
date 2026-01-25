// UC3: Ability to edit existing contact person using their name

using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    public class AddressBook
    {
        private List<Contact> contacts = new List<Contact>();

        // UC2: Add new contact
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        // UC3: Edit existing contact using name
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
    }
}
