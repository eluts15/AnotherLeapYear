namespace LeapYear
{
  public class LeapYear
  {
    //Use-Cases
      public bool IsLeapYearTrue(int year)
      {
        if (year % 400 == 0)
        {
          return true;
        }
        if (year % 100 == 0)
        {
          return true;
        }
        else
        {
          return year % 4 == 0;
        }
      }
  }
}
