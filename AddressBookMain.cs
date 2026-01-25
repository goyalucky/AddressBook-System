using System;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            AddressBook addressBook = new AddressBook();
            bool addMore = true;

            // UC5: Add Multiple Contacts
            while (addMore)
            {
                Contact contact = new Contact();

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
                Console.WriteLine("Contact added successfully ✔");

                Console.Write("\nDo you want to add another contact? (Y/N): ");
                string choice = Console.ReadLine().ToUpper();

                if (choice != "Y")
                    addMore = false;
            }

            // UC3: Edit Contact
            Console.Write("\nEnter First Name to Edit: ");
            string editFirstName = Console.ReadLine();

            Console.Write("Enter Last Name to Edit: ");
            string editLastName = Console.ReadLine();

            addressBook.EditContact(editFirstName, editLastName);

            // UC4: Delete Contact
            Console.Write("\nEnter First Name to Delete: ");
            string deleteFirstName = Console.ReadLine();

            Console.Write("Enter Last Name to Delete: ");
            string deleteLastName = Console.ReadLine();

            addressBook.DeleteContact(deleteFirstName, deleteLastName);

            Console.WriteLine("\nThank you for using Address Book!");
        }
    }
}
