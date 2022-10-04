using System;
using static System.Console;
using System.Globalization;
class ChatAWhile
{
   static void Main()
   {
      string [] areaCode =   {"262", "414", "608","715", "815", "920"};
      double [] minuteRate = {0.07, 0.10, 0.05, 0.16, 0.24, 0.14};

      WriteLine("Enter Area Code >>");
      string user = ReadLine();

      WriteLine("Enter Call Length in Minutes >>");
      int minutes = Convert.ToInt32(ReadLine());

      int x = Array.BinarySearch(areaCode, user);

      if (x < 0)
        {
          WriteLine($"Sorry - no calls allowed to area {user}");
        }
      else
        {
          string MINCOST = minuteRate[x].ToString("C", CultureInfo.GetCultureInfo("en-US"));
          double TOTCOST = (double)minutes * minuteRate[x];
          string TOTSTRING = TOTCOST.ToString("C", CultureInfo.GetCultureInfo("en-US"));
          WriteLine($"Your phone call to area {user} costs {MINCOST} per minute");
          WriteLine($"For {minutes} minutes the total is {TOTSTRING}");
        }
   }
}
