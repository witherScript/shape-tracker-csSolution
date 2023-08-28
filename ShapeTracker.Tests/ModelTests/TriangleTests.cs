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
      Triangle newTriangle = new Triangle(2,3);
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      int length1 = 3; //Arrange
      int length2 = 5;
      Triangle newTriangle = new Triangle(length1, length2);

      int result = newTriangle.Side1; //Act

      Assert.AreEqual(length1, result); //Assert
    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      Triangle newTriangle = new Triangle(3,4); //Arrange
      int newLength1 = 44;

      newTriangle.Side1 = newLength1; //Act

      Assert.AreEqual(newLength1, newTriangle.Side1);
    }
    [TestMethod]
    public void GetSide2_GetsValueOfSide2_Int()
    {
      Triangle newTriangle = new Triangle(3, 4);
      Assert.AreEqual(4, newTriangle.Side2);
    }
  }

}