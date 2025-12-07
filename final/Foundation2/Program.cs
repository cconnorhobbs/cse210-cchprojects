using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Connor Hobbs", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LP100", 799.99, 1));
        order1.AddProduct(new Product("Mouse", "MS200", 25.50, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}\n");

        Address address2 = new Address("50 King Road", "London", "N/A", "UK");
        Customer customer2 = new Customer("James Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "HD300", 199.99, 1));
        order2.AddProduct(new Product("Keyboard", "KB400", 89.99, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}
