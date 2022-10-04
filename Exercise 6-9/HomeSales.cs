using System;
using static System.Console;
using System.Globalization;
class HomeSales
{
   static void Main()
   {
     double Danielle = 0, Edward = 0, Francis = 0, Total = 0;
     double [] accSales = {Danielle, Edward, Francis, Total};
     char [] initials = {'d','D' , 'e','E', 'f','F'};
     string [] names = {"Danielle", "Edward", "Francis", "Total"};
     char user;

     WriteLine("Enter a salesperson initial (D, E, or F) >>");
     user = Convert.ToChar(ReadLine());

     while(user != 'z' && user != 'Z')
        {
          Array.Sort(initials);
          int x = 0;
          x = Array.BinarySearch(initials, user);

          if (x == 0 || x == 3)
            {
              WriteLine("Enter amount of sale");
              accSales[0] += Convert.ToDouble(ReadLine());
            }
          if (x == 1 || x == 4)
            {
              WriteLine("Enter amount of sale");
              accSales[1] += Convert.ToDouble(ReadLine());
            }
          if (x == 2 || x == 6)
            {
              WriteLine("Enter amount of sale");
              accSales[2] += Convert.ToDouble(ReadLine());
            }
          else if(x < 0)
            {
              WriteLine("Sorry - invalid salesperson");
            }

          WriteLine("Enter next salesperson initial (D, E, or F) OR Z to quit >>");
          user = Convert.ToChar(ReadLine());
        }

      accSales[3] = accSales[0] + accSales[1] + accSales[2];

        for (int L = 0; L < accSales.Length; ++L)
          {
            WriteLine("{0} sold      {1}",names[L], accSales[L].ToString("C", CultureInfo.GetCultureInfo("en-US")));
          }
   }
}
