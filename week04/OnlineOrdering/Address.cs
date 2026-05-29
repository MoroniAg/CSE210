using System;

namespace OnlineOrdering
{
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _stateOrProvince;
        private string _country;

        public Address(string street, string city, string stateOrProvince, string country)
        {
            _streetAddress = street;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _country = country;
        }

        public bool IsInUSA()
        {
            if (string.IsNullOrEmpty(_country)) return false;
            var country = _country.Trim().ToUpper();
            return country == "USA" || country == "UNITED STATES" || country == "UNITED STATES OF AMERICA" || country == "EE. UU.";
        }

        public void Display()
        {
            Console.WriteLine($"{_streetAddress}");
            Console.WriteLine($"{_city}, {_stateOrProvince}");
            Console.WriteLine($"{_country}");
        }

        public override string ToString()
        {
            return $"{_streetAddress} - {_city}, {_stateOrProvince} - {_country}";
        }
    }
}
