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
      Vendor vendor1 = new Vendor("Michael's house of pancakes:MiHOP");
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
  }

}