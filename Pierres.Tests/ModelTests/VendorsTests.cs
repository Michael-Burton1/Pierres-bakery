using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Pierres.Models;
using System.Collections.Generic;

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
      Vendor vendor1 = new Vendor("Yogi's house of pancakes:Y-HOP?");
      Assert.AreEqual(typeof(Vendor), vendor1.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = new Vendor(name);
      Vendor newVendor = new Vendor(name);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_RetunsVendorId_Int()
    {
      string name = "Count Chocula's Discount Chocolate Biscuits";
      Vendor NewVendor = new Vendor(name);

      int result = NewVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_RetunsAllVendorsObjectsa_VendorsList()
    {
      string name1 = "Freddy Kruger's Killer Bread";
      string name2 = "Cardi B's WAP: Waffles and Pancakes";
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);

      Vendor reuslt = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }
  }

}