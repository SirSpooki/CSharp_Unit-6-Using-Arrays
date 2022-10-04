using System;
using static System.Console;
class TypingGrades
{
   static void Main()
   {
      int [] wordsTyped = {15, 30, 50, 75,99999};
      char [] grades = {'F', 'D', 'C', 'B', 'A'};

      WriteLine("Enter number of words typed: ");
      int words = Convert.ToInt32(ReadLine());

      int sub = 0;

      while(sub < wordsTyped.Length && words > wordsTyped[sub])
        ++sub;
      char grade = grades[sub];
      WriteLine($"Typing {words} words per minute: Grade {grade}");
   }
}
