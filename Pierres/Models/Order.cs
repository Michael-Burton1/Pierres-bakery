using System.Collections.Generic;

namespace Pierres.Models
{
  public class Order
  {
    public string Details { get; set; }
    public string Date { get; set; }
    public double Price { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string details, string date, double price)
    {
      Details = details;
      Date = date;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }


    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}