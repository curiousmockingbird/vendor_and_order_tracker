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
      Vendor vendor1 = new Vendor("Mathews", "Small business from around the corner");
      //Act
      //Assert
      Assert.AreEqual(typeof(Vendor), vendor1.GetType());
    }

    [TestMethod]
    public void SetVendorName_SetsNameForVendor_String()
    {
      //Arrange
      Vendor vendor1 = new Vendor("Matthews", "Small business from around the corner");
      //Act
      string result = vendor1.Name;
      //Assert
      Assert.AreEqual("Matthews", result);
    }

    [TestMethod]
    public void SetVendorDescription_SetsDescriptionForVendor_String()
    {
      //Arrange
      Vendor vendor1 = new Vendor("Matthews", "Small business from around the corner");
      //Act
      string result = vendor1.Name;
      //Assert
      Assert.AreEqual("Matthews", result);
    }
  }
}