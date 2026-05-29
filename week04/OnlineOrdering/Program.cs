using System;
using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - customer in USA
        var shippingAddressAlice = new Address("123 Main St", "Anytown", "CA", "USA");
        var customerAlice = new Customer("Alice", shippingAddressAlice);
        var orderForAlice = new Order(customerAlice);
        orderForAlice.AddProduct(new Product("Widget", "W-100", 3.50, 5));
        orderForAlice.AddProduct(new Product("Gadget", "G-200", 7.25, 2));
        orderForAlice.Display();

        // Order 2 - international customer
        var shippingAddressBob = new Address("456 Elm Rd", "London", "UK", "United Kingdom");
        var customerBob = new Customer("Bob", shippingAddressBob);
        var orderForBob = new Order(customerBob);
        orderForBob.AddProduct(new Product("Thingamajig", "T-300", 12.00, 1));
        orderForBob.AddProduct(new Product("Doohickey", "D-400", 4.75, 3));
        orderForBob.AddProduct(new Product("Whatsit", "W-500", 9.99, 2));
        orderForBob.AddProduct(new Product("Gizmo", "G-600", 15.00, 1));
        orderForBob.Display();
    }
}