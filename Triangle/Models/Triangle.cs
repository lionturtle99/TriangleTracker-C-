namespace Triangle
{
  public class TheThreeTriangles
  {
    public string IsItATriangle(int a, int b, int c)
    {
      if (a + b < c || a + c < b || b + c < a)
      {
        return "it is not a triangle";
      }
      else
      {
        return "it is a type of triangle";
      }
    }
  }
}