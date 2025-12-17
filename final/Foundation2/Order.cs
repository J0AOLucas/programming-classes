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

    return subtotal + GetShippingCost();
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

  public double GetShippingCost()
  {
    return _customer.LivesInUSA() ? 5 : 35;
  }

  public bool IsDomestic()
  {
    return _customer.LivesInUSA();
  }

  public int GetItemCount()
  {
    int total = 0;
    foreach (Product product in _products)
    {
      total += product.GetQuantity();
    }
    return total;
  }

  public string GetShippingSummary()
  {
    return IsDomestic() ? "Domestic shipping ($5)" : "International shipping ($35)";
  }
}