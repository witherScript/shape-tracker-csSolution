using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class TriangleTests:IDisposable
  {
    public void Dispose()
    {
      Triangle.ClearAll();
    }
    [TestMethod]
    public void TriangleConstructor_Creates_InstanceOfTriangle_Triangle()
    {
      Triangle newTriangle = new Triangle(2,3,4);
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      int length1 = 3; //Arrange
      int length2 = 5;
      int length3 = 6;
      Triangle newTriangle = new Triangle(length1, length2, length3);

      int result = newTriangle.Side1; //Act

      Assert.AreEqual(length1, result); //Assert
    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      Triangle newTriangle = new Triangle(3,4,5); //Arrange
      int newLength1 = 44;

      newTriangle.Side1 = newLength1; //Act

      Assert.AreEqual(newLength1, newTriangle.Side1);
    }
    [TestMethod]
    public void GetSide2_GetsValueOfSide2_Int()
    {
      Triangle newTriangle = new Triangle(3, 4, 5);
      Assert.AreEqual(4, newTriangle.Side2);
    }
    [TestMethod]
    public void SetSide2_SetsValueOfSide2_Void()
    {
      Triangle newTriangle = new Triangle(2,4,4);
      int newSide2Length = 5;
      newTriangle.Side2 = newSide2Length;
      Assert.AreEqual(newSide2Length, newTriangle.Side2);
    }
    [TestMethod]
    public void GetSide3_GetsValueOfSide3_Int()
    {
      Triangle newTriangle = new Triangle(2,3,4);
      Assert.AreEqual(4, newTriangle.GetSide3());
    }
    [TestMethod]
    public void SetSide3_SetsValueOfSide3_Void()
    {
      Triangle newTriangle = new Triangle(2,3,4);
      
      int newSide3Length = 18;
      newTriangle.SetSide3(newSide3Length);

      Assert.AreEqual(newSide3Length, newTriangle.GetSide3());
    }
    [TestMethod]
    public void CheckType_ReturnsNotATriangle_String()
    {
      Triangle notATriangle = new Triangle(3,4,88);
      string triType = notATriangle.CheckType();
      Assert.AreEqual("not a triangle", triType);
    }
    [TestMethod]
    public void CheckType_ReturnsScalene_String()
    {
      Triangle scaleneTriangle = new Triangle(11,12,13);
      string triType = scaleneTriangle.CheckType();
      Assert.AreEqual("scalene", triType);
    }
    [TestMethod]
    public void CheckType_ReturnsIsosceles_String()
    {
      Triangle isoscelesTriangle = new Triangle(11,11,13);
      string triType = isoscelesTriangle.CheckType();
      Assert.AreEqual("isosceles", triType);
    }
    [TestMethod]
    public void CheckType_ReturnsEquilateral_String()
    {
      Triangle equilateralTriangle = new Triangle(11,11,11);
      string triType = equilateralTriangle.CheckType();
      Assert.AreEqual("equilateral", triType);
    }
    [TestMethod]
    public void GetAll_ReturnsAllTriangleInstances_List()
    {
      Triangle first = new Triangle(2,3,4);
      Triangle second = new Triangle(3,4,5);
      Triangle third = new Triangle(5,6,7);

      List<Triangle> expected = new List<Triangle>{first, second, third};

      List<Triangle> actual = Triangle.GetAll();

      CollectionAssert.AreEqual(expected, actual);
    }
  }

}