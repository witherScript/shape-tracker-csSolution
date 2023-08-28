using System;
using ShapeTracker.Models;
using System.Collections.Generic;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("\t*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("\tWelcome to Shape Tracker!");
      Console.WriteLine("\t*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine(" We'll calculate what type of traingle you have based on the lengths of the \n triangle's three sides!");

      Console.WriteLine("Please enter a number: ");
      int length1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter another number: ");
      int length2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter a third number: ");
      int length3 = int.Parse(Console.ReadLine());
      
      
      Triangle tri = new Triangle(length1, length2, length3);
      
      ConfirmOrEditTriangle(tri);    
      
    }
    static void ConfirmOrEditTriangle(Triangle tri)
    {
      Console.WriteLine("You entered the following sides: ");
      Console.WriteLine($"Side 1: {tri.GetSide1()}\n");
      Console.WriteLine($"Side 2: {tri.GetSide2()}\n");
      Console.WriteLine($"Side 3: {tri.GetSide3()}\n");

      Console.WriteLine("Are these the correct values? 1 for yes, 0 for no");
      string response = Console.ReadLine();
      if(response == "1")
      {
        CheckTriangleType(tri);
      }
      else
      {
        Console.WriteLine("Please enter a number: ");
        int length1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter another number: ");
        int length2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a third number: ");
        int length3 = int.Parse(Console.ReadLine());
        
        
        Triangle newTri = new Triangle(length1, length2, length3);
        
        ConfirmOrEditTriangle(newTri);
      }
    }

  
    static void CheckTriangleType(Triangle tri)
    {
      string result = tri.CheckType();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your triangle is " + result + ".");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("What's next?");
      Console.WriteLine("Would you like to check a new triangle (new)?");
      Console.WriteLine("Please enter 'new' to check the type of a new triangle. To exit, enter any key.");
      string userResponse = Console.ReadLine(); 
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}
