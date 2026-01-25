// Ability to create a Contacts in Address Book with first and last names, address, city, state, zip, phone number and email…

using System;

namespace AddressBookSystem
{
    // Model class representing a Contact Person
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string Address   { get; set; }
        public string City      { get; set; }
        public string State     { get; set; }
        public int    Zip       { get; set; }
        public string Phone     { get; set; }
        public string Email     { get; set; }
    }
}
