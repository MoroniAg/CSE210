using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;
        private double _shippingCost;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
            _shippingCost = CalculateShippingCost();

        }

        public void AddProduct(Product p)
        {
            if (p == null) return;
            _products.Add(p);
        }

        public double GetTotalPrice()
        {
            double subtotal = 0;
            foreach (var product in _products)
            {
                subtotal += product.GetTotalCost();
            }
            return subtotal + _shippingCost;
        }

        public string GetPackingLabel()
        {
            string label = "--- Packing Label ---\n";
            foreach (var product in _products)
            {
                label += $"{product.GetProductInfo()}\n";
            }
            return label.TrimEnd();
        }

        public string GetShippingLabel()
        {
            string shippingLabel = "--- Shipping Label ---\n";
            var address = _customer?.GetAddress();
            if (_customer == null || address == null) return "";
            shippingLabel += $"Customer: {_customer.GetCustomerName()}\n";
            shippingLabel += $"Address: {address}\n";
            return shippingLabel.TrimEnd();
        }

        private double CalculateShippingCost()
        {
            if (_customer == null || _customer.GetAddress() == null) return 0;
            return _customer.IsInUSA() ? 5.00 : 35.00;
        }

        public void Display()
        {
            Console.WriteLine("\nOrder Details");
            Console.WriteLine(GetPackingLabel());
            Console.WriteLine(GetShippingLabel());
            Console.WriteLine("--- Summary ---");
            Console.WriteLine($"Shipping Cost: ${_shippingCost:0.00}");
            Console.WriteLine($"Total Price: ${GetTotalPrice():0.00}");
        }
    }
}
