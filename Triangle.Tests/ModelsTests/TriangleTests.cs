using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TheThreeTrianglesTests
  {
    [TestMethod]
    public void IsItATriangle_TwoSidesGreaterThanOther_String()
    {
      TheThreeTriangles testTheThreeTriangles = new TheThreeTriangles();
      Assert.AreEqual("it is not a triangle", testTheThreeTriangles.IsItATriangle(1, 2, 5));
    }
  }
}