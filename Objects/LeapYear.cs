namespace LeapYear
{
  public class LeapYear
  {
    //Use-Cases
      public bool IsLeapYearTrue(int year)
      {
        if (year % 100 == 0)
        {
          return false;
        }
        else
        {
          return year % 4 == 0;
        }
      }
  }
}
