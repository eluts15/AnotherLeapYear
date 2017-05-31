using Xunit;
namespace LeapYear
{
  public class Test
  {

    [Fact]
    public void IsLeapYear_ForNumbersDivisibleByFour_isTrue()
    {
      //Test code goes here.
      LeapYear year = new LeapYear(); //instantiate a LeapYear object named year.
      Assert.Equal(true, year.IsLeapYearTrue(2012));
    }
    [Fact]
    public void IsLeapYear_ForNumbersDivisibleByFour_isFalse()
    {
      LeapYear year = new LeapYear();
      Assert.Equal(false, year.IsLeapYearTrue(1999));
    }


    [Fact]
    public void IsLeapYear_ForNumbersDivisibleByHundred_isTrue()
    {
      LeapYear year = new LeapYear();
      Assert.Equal(true, year.IsLeapYearTrue(2012));
    }
    [Fact]
    public void IsLeapYear_ForNumbersDivisibleByHundred_isFalse()
    {
      LeapYear year = new LeapYear();
      Assert.Equal(false, year.IsLeapYearTrue(1900));
    }




  }
}
