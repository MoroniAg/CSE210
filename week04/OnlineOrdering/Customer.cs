using System;

namespace OnlineOrdering
{
    public class Customer
    {
        private string _customerName;
        private Address _address;

        public Customer(string name, Address address)
            {
                _customerName = name;
                _address = address;
            }

        public bool IsInUSA()
        {
            return _address != null && _address.IsInUSA();
        }

        public Address GetAddress()
        {
            return _address;
        }

        public string GetCustomerName()
        {
            return _customerName;
        }
    }
}
