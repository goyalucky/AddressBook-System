using System;
using System.Runtime.InteropServices;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            // Create AddressBook object
            AddressBook addressBook = new AddressBook();

            // Create Contact object
            Contact contact = new Contact();

            // UC2: Add New Contact
            Console.Write("\nEnter First Name: ");
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

            addressBook.AddContact(contact);

            // UC3: Edit Existing Contact 
            Console.Write("\nEnter First Name to Edit: ");
            string editFirstName = Console.ReadLine();

            Console.Write("Enter Last Name to Edit: ");
            string editLastName = Console.ReadLine();

            addressBook.EditContact(editFirstName, editLastName);

            //UC4: Delete Contact 
            Console.Write("\nEnter First Name to Delete: ");
            string deleteFirstName = Console.ReadLine();

            Console.Write("Enter Last Name to Delete: ");
            string deleteLastName = Console.ReadLine();

            addressBook.DeleteContact(deleteFirstName, deleteLastName);
        }
    }
}
