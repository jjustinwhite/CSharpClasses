using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JWhiteHW2
{
    public class USCalendar
    {
            private DateTime _currentDateTime;

            //Constructor 1 to set _currentDateTime to the current server datetime
            public USCalendar()
            {
                _currentDateTime = DateTime.Now;
            }

            //Constructor 2 to pass in a datetime
            public USCalendar(DateTime dt)
            {
                _currentDateTime = dt;
            }

            //Method 1 - return true/false if it is a weekend or not
            public bool isTodayInWeekend()
            {
                if (_currentDateTime.DayOfWeek == DayOfWeek.Saturday || _currentDateTime.DayOfWeek == DayOfWeek.Sunday) //add saturday/sunday
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //Method 2 - Return true/false if the current year is a leap yaer
            public bool isCurrentYearLeapYear()
            {
                return DateTime.IsLeapYear(_currentDateTime.Year);
            }

            //Method 3 - return number of days in the month represended by date
            public int totalDaysInMonth()
            {
                return  DateTime.DaysInMonth(_currentDateTime.Year, _currentDateTime.Month);
            }

            //Method 4 - Return the name of a US Holiday (or respond 'not a holiday').
            // I could probably refactor this using switch statements for neater code.
            public string getTodayHolidayName()
            {
                String currentMonthName = _currentDateTime.ToString("MMMM");
                String currentDayNumber = _currentDateTime.ToString("dd");

                if (currentMonthName == "January" && currentDayNumber == "01")
                {
                    return "Happy New Year!! It's New Years Day today.";
                }
                else if (currentMonthName == "June" && currentDayNumber == "14")
                {
                    return "Today is Flag Day! This holiday commemorates the day the U.S adopted the flag of the United States, circa 1777.";
                }
                else if (currentMonthName == "July" && currentDayNumber == "04")
                {
                    return "Happy 4th of July! Are you going to watch the fireworks?";
                }
                else if (currentMonthName == "November" && currentDayNumber == "11")
                {
                    return "Today is Veterans Day. Did you know that World War I ended on this date in 1918?";
                }
                else if (currentMonthName == "December" && currentDayNumber == "25")
                {
                    return "Merry Christmas and Happy Holidays! Jesus of Nazareth was born today.";
                }
                else
                {
                    return "Not a holiday today.";
                }
            }
        
    }
}