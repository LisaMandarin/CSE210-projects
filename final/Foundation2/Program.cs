using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(111, "St. Apple", "Apple City", "Alaska", "USA");
        Customer customer1 = new Customer("Amy Adams", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Key chain", "11-324", 33.1, 2);
        Product product2 = new Product("Door handle", "22-548", 10.24, 1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Address address2 = new Address(222,"St. Banana", "Banana City", "New Yorkl", "Taiwan");
        Customer customer2 = new Customer("Camila Alves", address2);
        Order order2 = new Order(customer2);
        Product product3 = new Product("Disney Princess Blanket", "33-333", 2.6, 3);
        Product product4 = new Product("Surfboard", "44-444", 5.1, 2);
        Product product5 = new Product("Water bottle", "55-555", 3.8, 1);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.BackgroundColor = ConsoleColor.Magenta;
        {
            
        };
        Console.WriteLine($"=========== Order Information ===========");
        Console.WriteLine($"Order 1");
        Console.WriteLine($"  Packing Information\n{order1.DisplayPacking()}");
        Console.WriteLine($"  Shipping Information\n{order1.DisplayShipping()}\n");
        Console.WriteLine($"  Total Amount: {order1.CalculateTotal()}");
        
        Console.WriteLine();

        Console.WriteLine($"Order 2");
        Console.WriteLine($"  Packing Information\n{order2.DisplayPacking()}");
        Console.WriteLine($"  Shipping Information\n{order2.DisplayShipping()}\n");
        Console.WriteLine($"  Total Amount: {order2.CalculateTotal()}");

        


    }
}