using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]

    public void BreadClassConstructor_MakesInstanceOfBreadClass_TypeClass()
    {
      Bread newBreadOrder = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }

    [TestMethod]

    public void GetNumberOfBread_ReturnsIntNumberOfBread_Int()
    {
      Bread newBreadOrder = new Bread(5);
      int expected = 5;
      int result = newBreadOrder.NumberOfBread;
      Assert.AreEqual(expected, result);
    }

    [TestMethod]

    public void ComputePrice_ReturnsCostOfFirstLoaf_Int()
    {
      Bread newBreadOrder = new Bread(1);
      int expected = 5;
      int result = newBreadOrder.ComputePrice();
      Assert.AreEqual(expected, result);
    }

  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    
    public void PastryClassConstructor_MakesInstanceOfPastryClass_TypeClass()
    {
      Pastry newPastryOrder = new Pastry(4);
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }

    [TestMethod]

    public void GetNumberOfPastry_ReturnsNumberOfPastry_int()
    {
      Pastry newPastryOrder = new Pastry(4);
      int expected = 4;
      int result = newPastryOrder.NumberOfPastry;
      Assert.AreEqual(expected, result);
    }
    
  }

}
