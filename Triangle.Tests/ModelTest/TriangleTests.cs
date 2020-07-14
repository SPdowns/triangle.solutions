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
    
    [TestMethod]
    public void IsEquilateral_CheckIfTriangleIsNotEquilateral_False()
    {
      Triangle testTriangle = new Triangle(2, 3, 4);
      Assert.AreEqual(false, testTriangle.IsEquilateral());
    }
    
    [TestMethod]
    public void IsEquilateral_CheckIfTriangleIsEquilateral_True()
    {
      Triangle testTriangle = new Triangle(3, 3, 3);
      Assert.AreEqual(true, testTriangle.IsEquilateral());
    }

    [TestMethod]
    public void IsIsosceles_CheckIfTriangleIsNotIsosceles_False()
    {
      Triangle testTriangle = new Triangle(3, 4, 5);
      Triangle secondTest = new Triangle (3, 3, 3);
      Assert.AreEqual(false, testTriangle.IsIsosceles());
      Assert.AreEqual(false, secondTest.IsIsosceles());
    }

    [TestMethod]
    public void IsIsosceles_CheckIfTriangleIsIsosceles_True()
    {
      Triangle testTriangle = new Triangle(3, 3, 5);
      Assert.AreEqual(true, testTriangle.IsIsosceles());
    }

    [TestMethod]
    public void TriangleType_CheckIfTriangleIsValid_Invalid()
    {
      Triangle testTriangle = new Triangle(1, 2, 9);
      Assert.AreEqual("invalid", testTriangle.TriangleType());
    }

    [TestMethod]
    public void TriangleType_CheckIfTriangleIsEquilateral_Equilateral()
    {
      Triangle testTriangle = new Triangle(3, 3, 3);
      Assert.AreEqual("equilateral", testTriangle.TriangleType());
    }

    [TestMethod]
    public void TriangleType_CheckIfTriangleIsIsosceles_Isoseles()
    {
      Triangle testTriangle = new Triangle(3, 3, 4);
      Assert.AreEqual("isosceles", testTriangle.TriangleType());
    }
  }
}
