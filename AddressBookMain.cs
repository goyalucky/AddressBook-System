using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");

            // UC6: Multiple Address Books
            Dictionary<string, AddressBook> addressBookMap =
                new Dictionary<string, AddressBook>();

            bool addMoreBooks = true;

            while (addMoreBooks)
            {
                Console.Write("\nEnter Address Book Name: ");
                string bookName = Console.ReadLine();

                if (!addressBookMap.ContainsKey(bookName))
                {
                    addressBookMap[bookName] = new AddressBook();
                    Console.WriteLine("Address Book created successfully.");
                }

                AddressBook addressBook = addressBookMap[bookName];
                bool addMoreContacts = true;

                // UC5: Add multiple contacts
                while (addMoreContacts)
                {
                    Contact contact = new Contact();

                    Console.Write("Enter First Name: ");
                    contact.FirstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    contact.LastName = Console.ReadLine();

                    Console.Write("Enter Address: ");
                    contact.Address = Console.ReadLine();

                    Console.Write("Enter City: ");
                    contact.City = Console.ReadLine();

                    Console.Write("Enter State: ");
                    contact.State = Console.ReadLine();

                    Console.Write("Enter Zip: ");
                    contact.Zip = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Phone: ");
                    contact.Phone = Console.ReadLine();

                    Console.Write("Enter Email: ");
                    contact.Email = Console.ReadLine();

                    addressBook.AddContact(contact);

                    Console.Write("Add another contact? (Y/N): ");
                    if (Console.ReadLine().ToUpper() != "Y")
                        addMoreContacts = false;
                }

                Console.Write("Add another Address Book? (Y/N): ");
                if (Console.ReadLine().ToUpper() != "Y")
                    addMoreBooks = false;
            }

            //  UC8: Search by City or State
            Console.Write("\nSearch person by City or State (C/S): ");
            string choice = Console.ReadLine().ToUpper();

            if (choice == "C")
            {
                Console.Write("Enter City: ");
                string city = Console.ReadLine();
                Search(addressBookMap, city, true);
            }
            else if (choice == "S")
            {
                Console.Write("Enter State: ");
                string state = Console.ReadLine();
                Search(addressBookMap, state, false);
            }

            Console.WriteLine("\nProgram Ended.");
        }

        // UC8 Search Logic
        static void Search(
            Dictionary<string, AddressBook> addressBookMap,
            string value,
            bool searchByCity)
        {
            Console.WriteLine("\nSearch Results:");
            bool found = false;

            foreach (var entry in addressBookMap)
            {
                foreach (var contact in entry.Value.GetContacts())
                {
                    if ((searchByCity && contact.City.Equals(value, StringComparison.OrdinalIgnoreCase)) ||
                        (!searchByCity && contact.State.Equals(value, StringComparison.OrdinalIgnoreCase)))
                    {
                        Console.WriteLine(
                            $"[{entry.Key}] {contact.FirstName} {contact.LastName} - " +
                            $"{contact.City}, {contact.State}");
                        found = true;
                    }
                }
            }

            if (!found)
                Console.WriteLine("No matching records found.");
        }
    }
}
