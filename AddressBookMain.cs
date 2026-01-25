using System;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            // UC1: Ability to create a contact by providing values
            Contact contact = new Contact
            {
                FirstName = "Lucky",
                LastName  = "Goyal",
                Address   = "Pushpanjali Upvan Near Jaigurudev",
                City      = "Mathura",
                State     = "Uttar Pradesh",
                Zip       = 281001,
                Phone     = "99976*****",
                Email     = "lg@gmail.com"
            };

            // Display contact details
            Console.WriteLine("\nContact Created Successfully");
            Console.WriteLine($"Name    : {contact.FirstName} {contact.LastName}");
            Console.WriteLine($"Address : {contact.Address}");
            Console.WriteLine($"City    : {contact.City}");
            Console.WriteLine($"State   : {contact.State}");
            Console.WriteLine($"Zip     : {contact.Zip}");
            Console.WriteLine($"Phone   : {contact.Phone}");
            Console.WriteLine($"Email   : {contact.Email}");
        }
    }
}
