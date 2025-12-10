using System;

class Program
{
    static void Main(string[] args)
    {
        // Addresses
        Address addrUSA = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address addrInt = new Address("45 Rue Victor Hugo", "Paris", "Île-de-France", "France");

        // Customers
        Customer customerUSA = new Customer("Alice Johnson", addrUSA);
        Customer customerIntl = new Customer("Carlos Silva", addrInt);

        // Order 1 (USA)
        Order order1 = new Order(customerUSA);
        order1.AddProduct(new Product("Notebook", "NB001", 2.50, 4));
        order1.AddProduct(new Product("Pen", "PEN123", 1.10, 3));
        order1.AddProduct(new Product("Backpack", "BAG900", 25.00, 1));

        // Order 2 (International)
        Order order2 = new Order(customerIntl);
        order2.AddProduct(new Product("Water Bottle", "WB777", 12.99, 2));
        order2.AddProduct(new Product("Hat", "HAT555", 8.50, 1));

        // Display results
        ShowOrderSummary("Order 1 (USA)", order1);
        ShowOrderSummary("Order 2 (International)", order2);
    }

    static void ShowOrderSummary(string title, Order order)
    {
        Console.WriteLine($"--- {title} ---");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
        Console.WriteLine();
    }
}