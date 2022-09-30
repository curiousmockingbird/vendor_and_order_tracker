using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business.Models;
using System;

namespace Business.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void CreateOrderConstructor_CreatesOrderConstructor_Order()
    {
      //Arrange
      Order order1 = new Order("Matt's order", "Cookies and pastries", 30, "Sep 20, 2022");
      //Act
      //Assert
      Assert.AreEqual(typeof(Order), order1.GetType());
    }

    [TestMethod]
    public void SetOrderTitle_SetsOrderTitle_String()
    {
      //Arrange
      Order order1 = new Order("Matt's order", "Cookies and pastries", 30, "Sep 20, 2022");
      //Act
      string result = order1.Title;
      //Assert
      Assert.AreEqual("Matt's order", result);
    }

    [TestMethod]
    public void SetOrderDescription_SetsOrderDescription_String()
    {
      //Arrange
      Order order1 = new Order("Matt's order", "Cookies and pastries", 30, "Sep 20, 2022");
      //Act
      string result = order1.Description;
      //Assert
      Assert.AreEqual("Cookies and pastries", result);
    }

    [TestMethod]
    public void SetOrderPrice_SetsOrderPrice_Int()
    {
      //Arrange
      Order order1 = new Order("Matt's order", "Cookies and pastries", 30, "Sep 20, 2022");
      //Act
      int result = order1.Price;
      //Assert
      Assert.AreEqual(30, result);
    }

    [TestMethod]
    public void SetOrderDate_SetsOrderDate_String()
    {
      //Arrange
      Order order1 = new Order("Matt's order", "Cookies and pastries", 30, "Sep 20, 2022");
      //Act
      string result = order1.Date;
      //Assert
      Assert.AreEqual("Sep 20, 2022", result);
    }
  }
}