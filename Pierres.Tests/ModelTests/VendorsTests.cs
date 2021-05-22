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
      Vendor vendor1 = new Vendor("Test Vendor");
      Assert.AreEqual(typeof(Vendor), vendor1.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = new VendorsTests(name);

      string result = new Vendor.Name;

      Assert.AreEqual(name, result);
    })
}

}