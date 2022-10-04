using System;
using static System.Console;
class TemperaturesComparison
{
   static void Main()
   {
      int[] temperatures = new int[5];
      int sumTemps = 0;
      int user;
      bool print1 = false, print2 = false,print3=false;

      for(int x = 0; x < temperatures.Length; ++x)
        {
          WriteLine("Input Daily Temperature:");
          user = Convert.ToInt32(ReadLine());

          if((user < -30) || (user > 130))
            {
              WriteLine("Temperature out of range, please re-enter (-30 - 130)");
              user = Convert.ToInt32(ReadLine());
            }
              temperatures[x] = user;
              sumTemps += user;
        }

      for(int x = 1; x < temperatures.Length; ++x)
        {
          if (temperatures[x-1] < temperatures[x] )
            {
                print1 = true;
            }
          if (temperatures[x-1] > temperatures[x])
            {
              print2 = true;
            }
          if (print1 && print2)
            {
              print3 = true;
            }
        }
        if (print3)
            {
                Write($"It's a mixed bag:   ");
            }
        else if (print1)
            {
                Write($"Getting warmer:   ");
            }
        else if (print2)
            {
                Write($"Getting cooler:   ");
            }
        
        foreach(var item in temperatures)
          {
            Write("   "+item.ToString());
          }
        double average = (double)sumTemps/temperatures.Length;
        WriteLine($"\nAverage: {average}");
        
   }
}

/*

*/
