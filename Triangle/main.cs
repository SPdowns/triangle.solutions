using System;
using TriangleTracker.Shape;

namespace TriangleTracker.Main
{
  public class TriangleUI
  {
    public static void Main()
    {
      Console.WriteLine("Enter the length of Side 1:");
      string stringSideOne = Console.ReadLine();
      Console.WriteLine("Enter the length of Side 2:");
      string stringSideTwo = Console.ReadLine();
      Console.WriteLine("Enter the length of Side 3:");
      string stringSideThree = Console.ReadLine();

      int sideOne = int.Parse(stringSideOne);
      int sideTwo = int.Parse(stringSideTwo);
      int sideThree = int.Parse(stringSideThree);

      Triangle userTriangle = new Triangle(sideOne, sideTwo, sideThree);
      string triangleType = userTriangle.TriangleType();
      Console.WriteLine("Your Triangle is " + triangleType);
      if (triangleType != 'invalid')
      {
        Console.WriteLine("Your triangle has a perimeter of " + userTriangle.Perimeter().ToString());
        Console.WriteLine("Your triangle has an area of " + userTriangle.Area().ToString());
      }
    }
  }
}