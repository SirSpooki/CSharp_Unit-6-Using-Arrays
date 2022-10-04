using System;
using static System.Console;
using System.Globalization;
class ResortPrices
{
   static void Main()
   {
      int [] nights = {2, 4, 7, 99999};
      int [] cost =   {200, 180, 160, 145};

      WriteLine("Enter number of days staying: ");
      int days = Convert.ToInt32(ReadLine());

      int x = 0;
      while(x < nights.Length && days > nights[x])
        {
          ++x;
        }
        double pricePerNight = cost[x];
        string costString = pricePerNight.ToString("C", CultureInfo.GetCultureInfo("en-US"));

        double ovrCost = pricePerNight * days;
        string ovrCostString = ovrCost.ToString("C", CultureInfo.GetCultureInfo("en-US"));
      WriteLine($"Price per night is {costString}");
      WriteLine($"Total for {days} night(s) is {ovrCostString}");
   }
}
