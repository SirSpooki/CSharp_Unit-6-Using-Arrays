using System;
using static System.Console;
using System.Globalization;
class DeliveryCharges
{
   static void Main()
   {
       string[] zips = {"12789", "54012", "54481", "54982", "60007",
         "60103", "60187", "60188", "71244", "90210"};
      double[] prices = {2.40, 3.00, 3.50, 4.00, 4.50, 5.00,
         5.25, 5.75, 6.10, 10.00};
      
      WriteLine("Enter a Zip Code >>");
      string user = ReadLine();

      int x = Array.BinarySearch(zips, user);

      if(x < 0)
        {
          WriteLine($"Sorry - no delivery to {user}");
        }
      else
        {
          string w = prices[x].ToString("C", CultureInfo.GetCultureInfo("en-US"));
          WriteLine($"Delivery to {user} ok. Delivery charge is {w}");
        }
   }
}
