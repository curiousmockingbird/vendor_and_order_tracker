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

    [TestMethod]
    public void SetVendorName_SetsNameForVendor_String()
    {
      //Arrange
      Vendor vendor1 = new Vendor("Mathews");
      //Act
      string result = vendor1.Name;
      //Assert
      Assert.AreEqual("Matthews", result);
    }
  }
}