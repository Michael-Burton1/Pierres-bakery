using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Pierres.Models;

namespace Pierres.TestTools
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesAnOrderObject_Order()
    {
      Order myOrder = new Order("test", "now", 1);
      Assert.AreEqual(typeof(Order), myOrder.GetType());
    }

    [TestMethod]
    public void GetDetails_retunsOrderDetails_string()
    {
      string details = "12 hot crossed buns";
      string date = "tuesday";
      double price = 10.50;

      Order myOrder = new Order(details, date, price);
      string detailsResult = myOrder.Details;
      string dateResult = myOrder.Date;
      double priceResult = myOrder.Price;

      Assert.AreEqual(details, detailsResult);
      Assert.AreEqual(date, dateResult);
      Assert.AreEqual(price, priceResult);
    }

    [TestMethod]
    public void SetDetails_SetDetails_String()
    {
      string details = "12 Hot cross buns.";
      string date = "tuesday";
      double price = 10.50;
      Order myOrder = new Order(details, date, price);

      string updatedDetails = "24 million hot crossed buns";
      myOrder.Details = updatedDetails;
      string result = myOrder.Details;

      Assert.AreEqual(updatedDetails, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAnEmptyList_OrdersList()
    {
      List<Order> newList = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      String myDetails = "12 hot cross buns";
      String yourDetails = "4 and 20 blackbirds baked into a pie.";
      Order newOrder1 = new Order(myDetails, "wow", 4);
      Order newOrder2 = new Order(yourDetails, "oh no", 8);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}
