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
  }
}