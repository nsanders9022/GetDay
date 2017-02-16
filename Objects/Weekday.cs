using System;
using System.Collections.Generic;

namespace WeekdayApp.Objects

{
  public class Weekday
  {
    public string dateString;
    DateTime dateValue;

    //Getter
    public string GetDate()
    {
      return dateString;
    }

    //Constructor
    public Weekday(string newDay)
    {
      dateString = newDay;
    }

    //Method
    public string FindDay()
    {
      string newDay = GetDate();
      dateValue = DateTime.Parse(newDay);
      return dateValue.ToString("dddd");
    }
  }
}
