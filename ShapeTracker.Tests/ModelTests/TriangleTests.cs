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
      Triangle newTriangle = new Triangle();
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }
  }

}