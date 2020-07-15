using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class Numbers
  {
    public int UserNumbers { get; }
    private static List<int> _instances = new List<int> {};
    public Numbers(int userNumbers)
    {
      UserNumbers = userNumbers;
      _instances.Add(userNumbers);
    }
    
    public static List<int> CalculateList(int UserNumbers)
    {
      for (int index = UserNumbers; index > 1; index--)
      {
        _instances.Add(index);
      }
      return _instances;
    }

    public static List<int> GetsMultiples(List<int> _instances)
    {//10 9 8 7 6 5 4 3 2
      for (int i = 0; i < _instances.Count; i++)  //10
      {
        for (int x = 1; x < _instances.Count; x++)//9, 8
        {
          if (_instances[i] % _instances[x] == 0)
          {
            _instances.RemoveAt(_instances[i]);
            break;
          }
          Console.WriteLine(_instances[x]);
        }
      }
      return _instances;
    }
    
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}