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

                if (addressBookMap.ContainsKey(bookName))
                {
                    Console.WriteLine("Address Book already exists!");
                }
                else
                {
                    AddressBook addressBook = new AddressBook();
                    addressBookMap.Add(bookName, addressBook);
                    Console.WriteLine("Address Book created successfully.");

                    // UC5: Add Multiple Contacts
                    bool addMoreContacts = true;
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
                        Console.WriteLine("Contact added successfully.");

                        Console.Write("Add another contact? (Y/N): ");
                        if (Console.ReadLine().ToUpper() != "Y")
                            addMoreContacts = false;
                    }
                }

                Console.Write("\nAdd another Address Book? (Y/N): ");
                if (Console.ReadLine().ToUpper() != "Y")
                    addMoreBooks = false;
            }

            Console.WriteLine("\nProgram Ended.");
        }
    }
}
