using Xunit;
namespace LeapYear
{
  public class Test
  {
    [Fact] //For XUnit.
    public void IsLeapYear_ForNumbersDivisibleByFour_isTrue()
    {
      //Test code goes here.
      LeapYear year = new LeapYear(); //instantiate a LeapYear object named year.
      Assert.Equal(true, year.IsLeapYearTrue(2012));
    }
  }
}
