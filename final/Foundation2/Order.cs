using System.Collections.Generic;

public class Order
{
  private List<Product> _products = new List<Product>();
  private Customer _customer;

  public Order(Customer customer)
  {
    _customer = customer;
  }

  public void AddProduct(Product product)
  {
    _products.Add(product);
  }

  public double GetTotalCost()
  {
    double subtotal = 0;
    foreach (Product product in _products)
    {
      subtotal += product.GetTotalCost();
    }

    double shipping = _customer.LivesInUSA() ? 5 : 35;
    return subtotal + shipping;
  }

  public string GetPackingLabel()
  {
    List<string> lines = new List<string>();
    foreach (Product product in _products)
    {
      lines.Add($"{product.GetName()} (ID: {product.GetProductId()})");
    }
    return string.Join("\n", lines);
  }

  public string GetShippingLabel()
  {
    return _customer.GetShippingLabel();
  }
}