using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void Triangle_CanInputThreeSides_True()
    {
      Triangle testTriangle = new Triangle(3, 4, 5);
      Assert.AreEqual(true, testTriangle.SideOne == 3);
    }

    [TestMethod]
    public void IsValid_CheckIfTriangleIsValid_True()
    {
      Triangle testTriangle = new Triangle(3, 4, 5);
      Assert.AreEqual(true, testTriangle.IsValid());
    }

    [TestMethod]
    public void IsValid_CheckIfTriangleIsInvalid_False()
    {
      Triangle testTriangle = new Triangle(2, 2, 8);
      Assert.AreEqual(false, testTriangle.IsValid());
    }
  }
}
