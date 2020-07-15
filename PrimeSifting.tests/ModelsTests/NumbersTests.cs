using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PrimeSifting.Models;
using System;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class NumbersTests
  {
    [TestMethod]
    public void NumbersConstructor_CreatesInstanceOfItem_Item()
    {
      Numbers newNumbers = new Numbers();
      Assert.AreEqual(typeof(Numbers), newNumbers.GetType());
    }
    [TestMethod]
      public void GetNumber_ReturnsNumber_Int()
    {
      int userNumbers = 5;
      Numbers newNumbers = new Numbers(userNumbers);
      int result = newNumbers.UserNumbers;
      Assert.AreEqual(description, result);
    }

  }
}