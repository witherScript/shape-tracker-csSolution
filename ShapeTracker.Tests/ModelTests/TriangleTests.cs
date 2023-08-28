using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleConstructor_Creates_InstanceOfTriangle_Triangle()
    {
      Triangle newTriangle = new Triangle(2);
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      int length1 = 3; //Arrange
      Triangle newTriangle = new Triangle(length1);

      int result = newTriangle.Side1; //Act

      Assert.AreEqual(length1, result); //Assert
    }
  }

}