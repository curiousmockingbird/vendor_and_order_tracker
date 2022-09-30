using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business.Models;
using System.Collections.Generic;
using System;

namespace Business.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
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

    [TestMethod]
    public void GetVendors_ReturnsEmptyList_VendorsList()
    {
      // Arrange
      List<Vendor> newList = new List<Vendor> { };
      // Act
      List<Vendor> result = Vendor.GetVendors();
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetVendors_ReturnsVendorsList_VendorList()
    {
      // Arrange
      Vendor vendor1 = new Vendor("Matthews", "Small business from around the corner");
      Vendor vendor2 = new Vendor("Olga's Cafe", "Small business in Downtown");
      Vendor vendor3 = new Vendor("Cat cafe", "Cat Cafe and non-profit animal shelter");
      List<Vendor> newList = new List<Vendor> { vendor1, vendor2, vendor3 };
      // Act
      List<Vendor> result = Vendor.GetVendors();
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      Order order1 = new Order("Matt's order", "Cookies and pastries", 30, "Sep 20, 2022");
      List<Order> newList = new List<Order> { order1 };
      Vendor vendor1 = new Vendor("Matthews", "Small business from around the corner");
      vendor1.AddOrder(order1);
      //Act
      List<Vendor> result = vendor1.Orders;
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}