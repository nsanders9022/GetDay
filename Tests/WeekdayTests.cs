using Xunit;
using System;
using System.Collections.Generic;
using WeekdayApp.Objects;

namespace WeekdayApp
{
  public class WeekdayTest
  {
    [Fact]
    public void FindDay_DisplayDay_Day()
    {
      //Arrange
      string date = "7/11/14";

      //Act
      Weekday newDay = new Weekday(date);

      //Assert
      Assert.Equal("Friday", newDay.FindDay());
    }
  }
}
