using System;
using TriangleTracker.Triangle;

namespace TriangleMain
{
  public class TriangleTracker
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
      Console.WriteLine("Your Triangle is " + userTriangle.TriangleType());
    }
  }
}