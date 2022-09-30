using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business.Models;
using System;

namespace Business.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void CreateVendorConstructor_CreatesVendorConstructor_Vendor()
    {
      //Arrange
      Vendor vendor1 = new Vendor();
      //Act
      //Assert
      Assert.AreEqual(typeof(Vendor), vendor1.GetType());
    }
  }
}