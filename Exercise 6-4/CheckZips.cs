using System;
using static System.Console;
class CheckZips
{
   static void Main()
   {
      string[] zips = {"12789", "54012", "54481", "54982", "60007",
         "60103", "60187", "60188", "71244", "90210"};
      
      WriteLine("Enter a Zip Code >>");
      string user = ReadLine();

      int x = Array.BinarySearch(zips, user);

      if (x < 0)
        {
          WriteLine($"Sorry - no delivery to {user}");
        }
      else
        {
          WriteLine($"Delivery to {user} ok");
        }
   }
}
