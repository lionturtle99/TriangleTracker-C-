using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TheThreeTrianglesTests
  {
    [TestMethod]
    public void IsItATriangle_TwoSidesGreaterThanOther_True()
    {
      TheThreeTriangles testTheThreeTriangles = new TheThreeTriangles();
      Assert.AreEqual(true, testTheThreeTriangles.IsItATriangle(1, 2, 3));
    }
  }
}