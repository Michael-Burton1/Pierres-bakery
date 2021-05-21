using System;
using System.Collections.Generic;

namespace Pierres.Models
{
  public class Order
  {
    public string Details { get; set; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string details)
    {
      Details = details;
      _instances.Add(this);
    }




    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}