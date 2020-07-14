namespace Triangle
{
  public class Triangle
  {
    public int SideOne { get; set; }
    public int SideTwo { get; set; }
    public int SideThree { get; set; }

    public Triangle(int sideOne, int sideTwo, int sideThree)
    {
      SideOne = sideOne;
      SideTwo = sideTwo;
      SideThree = sideThree;
    }

    public bool IsValid()
    {
      if (SideOne + SideTwo <= SideThree || SideOne + SideThree <= SideTwo || SideTwo + SideThree <= SideOne)
      {
        return false;
      }
      return true;
    }

    public bool IsEquilateral()
    {
      if (SideOne == SideTwo && SideOne == SideThree)
      {
        return true;
      }
      return false;
    }

    public bool IsIsosceles()
    {
      if ((SideOne == SideTwo || SideTwo == SideThree || SideThree == SideOne) && IsEquilateral() == false)
      {
        return true;
      }
      return false;
    }
  }
}
