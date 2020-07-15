using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class Numbers
  {
    public int UserNumbers { get; }
    private static List<Numbers> _instances = new List<Numbers> {};
    public Numbers(int userNumbers)
    {
      UserNumbers = userNumbers;
      _instances.Add(this);
    }

    public static List<Numbers> CalculateList()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}