using Mathematica.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ModelTests
{
  [TestClass]
  public sealed class LinearFunctionTest
  {
    [TestMethod]
    public void Calculate_TestMethod1()
    {
      int minX = 0; int maxX = 1;
      int minY = 0; 
      int a = 2;
      int b = 1;
      var model = new LinearFunctionModel(a, b);
      model.Calculate(0, 1);

      List<int> expectedValues = new List<int> { 1, 3 }; 
 //     CollectionAssert.AreEqual(expectedValues, model.Values); 
    }
    [TestMethod]
    public void TestGetY() 
    {
      int a = 2; 
      int b = 1;
      var model = new LinearFunctionModel(a ,b);
      int y = model.GetY(0);
      int y2 = model.GetY(1); 
      Assert.AreEqual(1, y);
      Assert.AreEqual(3, y2);
    }
  }
}