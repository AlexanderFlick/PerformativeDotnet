using System;
using System.Collections.Generic;
using System.Text;

namespace PerformativeDotnet
{
    public class DateParser
    {
        public int GetYearFromDateTime(string dateTimeAsString)
        {
            var dateTime = DateTime.Parse(dateTimeAsString);
            return dateTime.Year;
        }
    }
}
