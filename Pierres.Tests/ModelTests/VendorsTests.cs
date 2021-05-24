using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres.Models;
using System.Collections.Generic;
using System;

namespace Pierres.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor vendor1 = new Vendor("Yogi's house of pancakes:Y-HOP?", "A pancake house that asks philosphoical questions");
      Assert.AreEqual(typeof(Vendor), vendor1.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Game Of Scones";
      string discription = "A land of 'fire' pastries and ice-ing";

      Vendor newVendor = new Vendor(name, discription);

      string nameResult = newVendor.Name;
      string discriptionResult = newVendor.Discription;

      Assert.AreEqual(name, nameResult);
      Assert.AreEqual(discription, discriptionResult);
    }

    [TestMethod]
    public void GetId_RetunsVendorId_Int()
    {
      string name = "Count Chocula's Discount Chocolate Biscuits";
      string discription = "Biscuits you can sink your teeth into!";
      Vendor newVendor = new Vendor(name, discription);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }



    [TestMethod]
    public void GetAll_RetunsAllVendorsObjectsa_VendorsList()
    {
      string name01 = "Let's get this Bread";
      string discription01 = "We sevice ducks and young professionals";
      string name02 = "Joleen, I'm begging of you plz don't take my ham.";
      string discription02 = "Now serving ham and cheese croissants.";
      Vendor newVendor1 = new Vendor(name01, discription01);
      Vendor newVendor2 = new Vendor(name02, discription02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }



    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Freddy Krugger's Killer Bread";
      string discription1 = "Bread so good you'll be dying to try it";
      string name2 = "Cardi B's Waffles and Pancakes";
      string discription2 = "....better than macaroni in a pot";
      Vendor newVendor1 = new Vendor(name1, discription1);
      Vendor newVendor2 = new Vendor(name2, discription2);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string details = "tons of tortillas.";
      string date = "anytime, really";
      double price = 12.00;
      Order myOrder = new Order(details, date, price);
      List<Order> newList = new List<Order> { myOrder };
      string name = "Admiral Ackbar's snack bar";
      string discription = "It's a wrap!";
      Vendor newVendor = new Vendor(name, discription);
      newVendor.AddOrder(myOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }

}