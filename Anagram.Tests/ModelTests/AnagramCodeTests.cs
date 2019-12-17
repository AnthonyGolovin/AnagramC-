using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using AnagramCoding;

namespace AnagramCoding.Tests
{
  [TestClass]
  public class AnagramChecker
  {
    
    [TestMethod]
    public void AnagramChecker_ReturnsAnagrams_Bread()
    {
        AnagramCode userAna = new AnagramCode();
        List<string> expected = new List <string> {"Beard"};
        List<string> actual = new List <string> ();
        actual =userAna.AnagramChecker("Beard", expected);
        Assert.AreEqual(expected[0], actual[0]);
    }
  }
}