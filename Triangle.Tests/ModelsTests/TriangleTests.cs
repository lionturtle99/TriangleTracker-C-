using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TheThreeTrianglesTests
  {
    TheThreeTriangles testTheThreeTriangles = new TheThreeTriangles();
    
    [TestMethod]
    public void IsItATriangle_TwoSidesLessThanOther_String()
    {
      Assert.AreEqual("it is not a triangle", testTheThreeTriangles.IsItATriangle(1, 2, 5));
    }

    [TestMethod]
    public void IsItATriangle_TwoSidesGreaterThanOther_String()
    {
      Assert.AreEqual("it is a type of triangle", testTheThreeTriangles.IsItATriangle(3,3,4));
    }
  }
}