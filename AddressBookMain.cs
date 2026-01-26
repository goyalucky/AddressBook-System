using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        // UC9: Dictionaries to maintain Persons by City and State
        public static Dictionary<string, List<Contact>> cityPersonsMap = new Dictionary<string, List<Contact>>();
        public static Dictionary<string, List<Contact>> statePersonsMap = new Dictionary<string, List<Contact>>();

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");

            // UC6: Multiple Address Books
            Dictionary<string, AddressBook> addressBookMap = new Dictionary<string, AddressBook>();

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

                    Console.Write("Enter First Name: "); contact.FirstName = Console.ReadLine();
                    Console.Write("Enter Last Name: "); contact.LastName = Console.ReadLine();
                    Console.Write("Enter Address: "); contact.Address = Console.ReadLine();
                    Console.Write("Enter City: "); contact.City = Console.ReadLine();
                    Console.Write("Enter State: "); contact.State = Console.ReadLine();
                    Console.Write("Enter Zip: "); contact.Zip = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Phone: "); contact.Phone = Console.ReadLine();
                    Console.Write("Enter Email: "); contact.Email = Console.ReadLine();

                    // UC7 & UC9 Logic: Only map to dictionaries if added successfully
                    if (addressBook.AddContact(contact))
                    {
                        MaintainLocationDictionaries(contact);
                    }

                    Console.Write("Add another contact? (Y/N): ");
                    if (Console.ReadLine().ToUpper() != "Y")
                        addMoreContacts = false;
                }

                Console.Write("Add another Address Book? (Y/N): ");
                if (Console.ReadLine().ToUpper() != "Y")
                    addMoreBooks = false;
            }

            // UC8: Search Logic
            Console.WriteLine("\n--- UC8: Search Logic ---");
            Console.Write("Search person by City or State (C/S): ");
            string searchChoice = Console.ReadLine().ToUpper();

            if (searchChoice == "C")
            {
                Console.Write("Enter City: ");
                string city = Console.ReadLine();
                Search(addressBookMap, city, true);
            }
            else if (searchChoice == "S")
            {
                Console.Write("Enter State: ");
                string state = Console.ReadLine();
                Search(addressBookMap, state, false);
            }

            // UC9: View Logic
            Console.WriteLine("\n--- UC9: View by City or State (Dictionary Library) ---");
            Console.Write("View all persons grouped by City or State? (C/S): ");
            string viewChoice = Console.ReadLine().ToUpper();
            if (viewChoice == "C" || viewChoice == "S")
            {
                ViewByLocation(viewChoice == "C");
            }

            // UC 10: Count Logic
            Console.WriteLine("\n--- UC 10: Count by City or State ---");
            DisplayCountByLocation();

            // UC 11: Sorting Logic
            Console.WriteLine("UC 11: Sort Entries by Name");
            Console.Write("Do you want to view sorted Address Books? (Y/N): ");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                foreach (var entry in addressBookMap)
                {
                    Console.WriteLine($"\nAddress Book: {entry.Key}");
                    entry.Value.SortByName();
                }
            }

            Console.WriteLine("\nProgram Ended.");
        }

        // UC9: Helper method to maintain Dictionaries
        static void MaintainLocationDictionaries(Contact contact)
        {
            if (!cityPersonsMap.ContainsKey(contact.City))
                cityPersonsMap[contact.City] = new List<Contact>();
            cityPersonsMap[contact.City].Add(contact);

            if (!statePersonsMap.ContainsKey(contact.State))
                statePersonsMap[contact.State] = new List<Contact>();
            statePersonsMap[contact.State].Add(contact);
        }

        // UC9: View Logic
        static void ViewByLocation(bool byCity)
        {
            var map = byCity ? cityPersonsMap : statePersonsMap;
            foreach (var entry in map)
            {
                Console.WriteLine($"\n{(byCity ? "City" : "State")}: {entry.Key}");
                foreach (var contact in entry.Value)
                {
                    Console.WriteLine($"- {contact.FirstName} {contact.LastName}");
                }
            }
        }

        // UC 10: Count Logic using Dictionary
        static void DisplayCountByLocation()
        {
            Console.WriteLine("\nCounts by City:");
            foreach (var entry in cityPersonsMap)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value.Count} person(s)");
            }

            Console.WriteLine("\nCounts by State:");
            foreach (var entry in statePersonsMap)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value.Count} person(s)");
            }
        }

        // UC8 Search Logic
        static void Search(Dictionary<string, AddressBook> addressBookMap, string value, bool searchByCity)
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
                        Console.WriteLine($"[{entry.Key}] {contact.FirstName} {contact.LastName} - {contact.City}, {contact.State}");
                        found = true;
                    }
                }
            }
            if (!found) Console.WriteLine("No matching records found.");
        }
    }
}