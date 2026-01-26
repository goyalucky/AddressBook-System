using System;

namespace AddressBookSystem
{
    // Model class for representing the Contact Person
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

        // UC11: Override toString method to finally Print Person Entry in Console
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Address: {Address}, City: {City}, State: {State}, Zip: {Zip}, Phone: {Phone}, Email: {Email}";
        }

        // UC7: Override Equals to check duplicate by Name
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Contact))
                return false;

            Contact other = (Contact)obj;
            return this.FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase)
                && this.LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return (FirstName + LastName).ToLower().GetHashCode();
        }
    }
}