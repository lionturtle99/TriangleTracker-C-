using System;
using Triangle;

namespace Project
{
  public class program
  {
    public static void Main()
    {
      TheThreeTriangles triangle = new TheThreeTriangles();
      Console.WriteLine("Input three numbers to see if it's a triangle or not");
      Console.WriteLine("This is side a");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("This is side b");
      int b = int.Parse(Console.ReadLine());
      Console.WriteLine("This is side c");
      int c = int.Parse(Console.ReadLine());
      Console.WriteLine(triangle.IsItATriangle(a,b,c));
    }
  }
}