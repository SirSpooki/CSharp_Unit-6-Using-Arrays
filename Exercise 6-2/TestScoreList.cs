using System;
using static System.Console;
class TestScoreList
{
   static void Main()
   {
       int [] testScores = new int [8];
       int sumScores = 0;
       for(int x = 0; x < testScores.Length; ++x)
        {
          WriteLine("Enter test score: ");
          testScores[x] = Convert.ToInt32(ReadLine());
          sumScores += testScores[x];
        }
        double average = (double)sumScores/testScores.Length;

      for(int x = 0; x < testScores.Length; ++x)
        {
          WriteLine($"Test # {x}    {testScores[x]} From average:     {testScores[x] - average}");
        }

      
   }
}

/*foreach(var item in testScores9)
{
    Console.WriteLine(item.ToString());
}
*/
