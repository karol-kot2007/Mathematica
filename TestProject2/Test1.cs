using Mathematica.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestProject
{
  [TestClass]
  public sealed class Test1
  {
    [TestMethod]
    public void Calculate_TestMethod1()
    {
      int minX = 0; int maxX = 1;
      int a = 2;
      int b = 1;
      var model = new LinearFunctionModel(a, b, minX, maxX);
      
      
      model.Calculate(0, 1);

    
      List<int> expectedValues = new List<int> { 1, 3 }; 
      CollectionAssert.AreEqual(expectedValues, model.Values); 
    }
  }
}