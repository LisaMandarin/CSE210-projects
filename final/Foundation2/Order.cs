using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    
    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double CalculateTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.calculatePrice();
        }
        total += _customer.GetShipping();
        return total;
    }
    public string DisplayPacking()
    {
        string packingLabel = "";
        foreach(Product product in _products)
        {
            packingLabel += $"  Product Name(ID): {product.GetName()}({product.GetID()})\n";
        }
        return packingLabel;
    }
    public string DisplayShipping()
    {
        string shippingLabel = $"  Customer: {_customer.GetName()}\n";
        shippingLabel += $"  Shipping Address: \n{_customer.GetAddress()}";
        return shippingLabel;
    }
}