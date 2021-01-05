using System;

namespace Bills.Domain.ValueObjects
{
    public class Address
    {
        public Address(string street, 
                       string number, 
                       string neighborhood, 
                       string city, 
                       string state, 
                       string country, 
                       string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;

            if (!IsValid())
                throw new Exception("Invalid address.");
        }

        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

        private bool IsValid()
        {
            if (Street.Length < 0)
                return false;

            if (City.Length < 0)
                return false;

            if (ZipCode.Length > 20)
                return false;

            return true;
        }
    }
}
