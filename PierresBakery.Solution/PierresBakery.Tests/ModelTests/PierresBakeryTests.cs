using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod] //1

    public void BreadClassConstructor_MakesInstanceOfBreadClass_TypeClass()
    {
      Bread newBreadOrder = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }

    [TestMethod] //2

    public void GetNumberOfBread_ReturnsIntNumberOfBread_Int()
    {
      Bread newBreadOrder = new Bread(5);
      int expected = 5;
      int result = newBreadOrder.NumberOfBread;
      Assert.AreEqual(expected, result);
    }

    [TestMethod] //3

    public void ComputePrice_ReturnsCostOfFirstLoaf_Int()
    {
      Bread newBreadOrder = new Bread(1);
      int expected = 5;
      int result = newBreadOrder.ComputePrice();
      Assert.AreEqual(expected, result);
    }

    [TestMethod] //4

    public void ComputePrice_ReturnsCostOfSecondLoaf_Int()
    {
      Bread newBreadOrder = new Bread(2);
      int expected = 10;
      int result = newBreadOrder.ComputePrice();
      Assert.AreEqual(expected, result);
    }

    [TestMethod] //5

    public void ComputePrice_ReturnsCostOfThreeLoaves_Int()
    {
      Bread newBreadOrder = new Bread(3);
      int expected = 10; 
      int result = newBreadOrder.ComputePrice(); 
      Assert.AreEqual(expected, result); 
    }

    [TestMethod] //6
    public void ComputePrice_ReturnsCostOfSeveralLoafQuantities_Int()
    {
      Bread newBreadOrder4 = new Bread(4);
      int expected4 = 15; 
      int result4 = newBreadOrder4.ComputePrice(); 
      Assert.AreEqual(expected4, result4);
      
      Bread newBreadOrder5 = new Bread(5);
      int expected5 = 20; 
      int result5 = newBreadOrder5.ComputePrice(); 
      Assert.AreEqual(expected5, result5); 
      
      Bread newBreadOrder6 = new Bread(6);
      int expected6 = 20; 
      int result6 = newBreadOrder6.ComputePrice(); 
      Assert.AreEqual(expected6, result6); 
      
      Bread newBreadOrder7 = new Bread(7);
      int expected7 = 25; 
      int result7 = newBreadOrder7.ComputePrice(); 
      Assert.AreEqual(expected7, result7); 
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod] //7
    
    public void PastryClassConstructor_MakesInstanceOfPastryClass_TypeClass()
    {
      Pastry newPastryOrder = new Pastry(4);
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }

    [TestMethod] //8

    public void GetNumberOfPastry_ReturnsNumberOfPastry_int()
    {
      Pastry newPastryOrder = new Pastry(4);
      int expected = 4;
      int result = newPastryOrder.NumberOfPastry;
      Assert.AreEqual(expected, result);
    }

    [TestMethod] //9

    public void ComputePrice_ReturnsCostOfFirstPastry_Int()
    {
      Pastry newPastryOrder = new Pastry(1);
      int expected = 2;
      int result = newPastryOrder.ComputePrice(); 
      Assert.AreEqual(expected, result); 
    }

    [TestMethod] //10
    public void ComputePrice_ReturnsCostOfThreePastries_Int()
    {
      Pastry newPastryOrder = new Pastry(3);
      int expected = 5;
      int result = newPastryOrder.ComputePrice(); 
      Assert.AreEqual(expected, result); 
    }

    [TestMethod] //11
    
    public void ComputePrice_ReturnsCostOfSeveralDifferentPastryQuantities_Int()
    {
      Pastry newPastryOrder4 = new Pastry(4);
      int expected4 = 7;
      int result4 = newPastryOrder4.ComputePrice(); 
      Assert.AreEqual(expected4, result4); 

      Pastry newPastryOrder5 = new Pastry(5);
      int expected5 = 9;
      int result5 = newPastryOrder5.ComputePrice(); 
      Assert.AreEqual(expected5, result5); 

      Pastry newPastryOrder6 = new Pastry(6);
      int expected6 = 10;
      int result6 = newPastryOrder6.ComputePrice(); 
      Assert.AreEqual(expected6, result6); 

      Pastry newPastryOrder7 = new Pastry(7);
      int expected7 = 12;
      int result7 = newPastryOrder7.ComputePrice(); 
      Assert.AreEqual(expected7, result7); 
    }

    
  }

}
