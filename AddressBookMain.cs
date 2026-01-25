using System;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            // Creating AddressBook object
            AddressBook addressBook = new AddressBook();

            // Creating Contact object
            Contact contact = new Contact();

            // UC2: Adding new contact using console input
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

            Console.Write("Enter Phone Number: ");
            contact.Phone = Console.ReadLine();

            Console.Write("Enter Email: ");
            contact.Email = Console.ReadLine();

            // Adding contact to Address Book
            addressBook.AddContact(contact);

            // UC3: Edit existing contact
            Console.Write("\nEnter First Name to Edit: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name to Edit: ");
            string lastName = Console.ReadLine();
            
            addressBook.EditContact(firstName, lastName);
        }
    }
}
