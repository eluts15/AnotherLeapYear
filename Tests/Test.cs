using Xunit;
namespace LeapYear
{
  public class Test
  {


    [Fact]
      public void IsLeapYear_MultipleOfFourHundred_isTrue()
      {
        LeapYear year = new LeapYear();
        Assert.Equal(true, year.IsLeapYearTrue(2000));
      }


    [Fact]
    public void IsLeapYear_MultiplessDivisibleByHundred_isTrue()
    {
      LeapYear year = new LeapYear();
      Assert.Equal(true, year.IsLeapYearTrue(2012));
    }
    [Fact]
    public void IsLeapYear_MultiplesDivisibleByHundred_isFalse()
    {
      LeapYear year = new LeapYear();
      Assert.Equal(true, year.IsLeapYearTrue(1900));
    }


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
  }
}
