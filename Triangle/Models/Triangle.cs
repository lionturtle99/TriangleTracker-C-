namespace Triangle
{
  public class TheThreeTriangles
  {
    public string IsItATriangle(int a, int b, int c)
    {
      if (a == b && a == c)
      {
        return "It is a equilateral triangle";
      }
      else if (a == b && a != c)
      {
        return "It is a isosceles triangle.";
      }
      else
      {
        return "it is not a triangle";
      }
    }
  }
}