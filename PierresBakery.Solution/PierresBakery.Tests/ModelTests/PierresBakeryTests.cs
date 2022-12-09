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
  }

  [TestClass]
  public class PastryTests
  {
    // Test methods go here
  }

}
