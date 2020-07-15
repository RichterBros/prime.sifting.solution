using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PrimeSifting.Models;
using System;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class NumbersTests : IDisposable
  {
    public void Dispose()
    {
      Numbers.ClearAll();
    }
    [TestMethod]
    public void NumbersConstructor_CreatesInstanceOfItem_Item()
    {
      Numbers newNumbers = new Numbers(5);
      Assert.AreEqual(typeof(Numbers), newNumbers.GetType());
    }
    [TestMethod]
      public void GetNumber_ReturnsNumber_Int()
    {
      int userNumbers = 5;
      Numbers newNumbers = new Numbers(userNumbers);
      int result = newNumbers.UserNumbers;
      Assert.AreEqual(userNumbers, result);
    }
    [TestMethod]
    public void CalculateList_ReturnsList_NumbersList()
    {
      List<Numbers> numbersList = new List<Numbers> { };
      List<Numbers> result = Numbers.CalculateList();
      CollectionAssert.AreEqual(numbersList, result);
    }
  }
}
