// Lists items for sale and their prices
using static System.Console;
using System.Globalization;

class DebugSix01
{
   static void Main()
   {
      string[] items = {"Belt", "Tie", "Scarf", "Cufflinks"};
      double[] prices = {29.00, 35.95, 18.50, 112.99};
      WriteLine("Items for sale:");
      for(int x = 0; x < items.Length; ++x)
         WriteLine("{0} for {1}", items[x], prices[x].ToString("C", CultureInfo.GetCultureInfo("en-US")));
   }
}
