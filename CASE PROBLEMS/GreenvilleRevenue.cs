namespace GreenvilleRevenueAssignment
{
using System;
using System.Collections.ObjectModel;
using static System.Console;

class GreenvilleRevenue
{
static void Main()
{

const int MIN_CONTESTANTS = 0;
const int MAX_CONTESTANTS = 30;
string entryString;
int numThisYear;
int numLastYear;

//variables for name, user choice and sentinel value i.e. exit code
string contestentName, userChoice, enteredCode;
//collection to hold singers, dancer, musicians and other
Collection<string> singers = new Collection<string>();
Collection<string> dancers = new Collection<string>();
Collection<string> musicians = new Collection<string>();
Collection<string> others = new Collection<string>();

Write("Enter number of contestants last year >> ");
entryString = ReadLine();
numLastYear = Convert.ToInt32(entryString);
while (numLastYear < MIN_CONTESTANTS || numLastYear > MAX_CONTESTANTS)
{
WriteLine("Number must be between {0} and {1}", MIN_CONTESTANTS, MAX_CONTESTANTS);
Write("Enter number of contestants last year >> ");
entryString = ReadLine();
numLastYear = Convert.ToInt32(entryString);
}

Write("Enter number of contestants this year >> ");
entryString = ReadLine();
numThisYear = Convert.ToInt32(entryString);
while (numThisYear < MIN_CONTESTANTS || numThisYear > MAX_CONTESTANTS)
{
WriteLine("Number must be between {0} and {1}", MIN_CONTESTANTS, MAX_CONTESTANTS);
Write("Enter number of contestants this year >> ");
entryString = ReadLine();
numThisYear = Convert.ToInt32(entryString);
}

//Added code for taking names, choice from the user
for (int index = 0; index < numThisYear; index++)
{
//Take input from the user for name and code of the contestant
Write("Enter name of contestant: ");
contestentName = ReadLine();
Write("Enter Code: (S)inging, (D)ancing, (M)usical instrument, (O)ther: ");
userChoice = ReadLine().ToLower();

//ask to re-eneter if not a valid code
while (!(userChoice.Equals("s") || userChoice.Equals("d") || userChoice.Equals("m") || userChoice.Equals("o")))
{
WriteLine("{0} is not a valid code",userChoice);
Write("Enter Code again: (S)inging, (D)ancing, (M)usical instrument, (O)ther: ");
userChoice = ReadLine();
}

//based on the choice of code, add data to corresponding list
switch (userChoice)
{
case "s":
singers.Add(contestentName);
break;
case "d":
dancers.Add(contestentName);
break;
case "m":
musicians.Add(contestentName);
break;
case "o":
others.Add(contestentName);
break;
default:
break;
}
}

//display the required output
WriteLine("The types of talent are:");
WriteLine("Singing {0}", singers.Count);
WriteLine("Dancing {0}", dancers.Count);
WriteLine("Musical instrument {0}", musicians.Count);
WriteLine("Other {0}",others.Count);

//serach for a talent code, If Z is entered then EXIT
while (true)
{
Write("Enter code to display contestants: ");
enteredCode = ReadLine();
//if entered code is Z, then break the loop
if (enteredCode.Equals("Z"))
break;

//display the corresponding list based on the code entered
switch (enteredCode.ToUpper())
{
case "S":
WriteLine("Contestants with talent Singing are:");
OutputContestantNames(singers);
break;
case "D":
WriteLine("Contestants with talent Dancing are:");
OutputContestantNames(dancers);
break;
case "M":
WriteLine("Contestants with talent Musical instrument are:");
OutputContestantNames(musicians);
break;
case "O":
WriteLine("Contestants with talent Other are:");
OutputContestantNames(others);
break;
default:
WriteLine("{0} is not a valid code",enteredCode);
break;
}
}

ReadLine();
}

/// <summary>
/// iterate over list to print the names
/// </summary>
/// <param name="names"></param>
static void OutputContestantNames(Collection<string> names)
{
foreach (var name in names)
{
WriteLine(name);
}
}
}
}
