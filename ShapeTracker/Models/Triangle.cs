using System.Collections.Generic;

namespace ShapeTracker.Models
{
  public class Triangle
  {
    private int _side1;
    public int Side1
    {
      get {return _side1;}
      set {_side1 = value;}
    }
    public int Side2 {get; set;}
    private int _side3;

    public Triangle(int length1, int length2, int length3)
    {
      _side1 = length1;
      Side2 = length2;
      _side3 = length3;
    }

    public int GetSide3()
    {
      return _side3;
    }

    public void SetSide3(int length3)
    {
      _side3 = length3;
    }
    
    public string CheckType()
    {
      if ((_side1 > (Side2 + _side3)) || (Side2 > (_side1 + _side3)) || (_side3 > (_side1 + Side2)))
      {
        return "not a triangle";
      }
      else if(_side1!=Side2 && _side1!=Side2 && Side2!=_side3)
      {
        return "scalene";
      }
      else if ((_side1==Side2 && Side2 != _side3) || (_side1 == _side3 && Side2 != _side3) || (Side2 == _side3 && _side3 != _side1))
      {
        return "isosceles";
      }
      else if (_side1 == Side2 && Side2 == _side3)
      {
        return "equilateral";
      }
      return "";
    }
  }
  
}