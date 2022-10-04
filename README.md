# CSharp_Unit-6-Using-Arrays
Exercises 6-1 - 6-9

SlayTeam 2023

Exercise Instructions
----------------------------
6-1
--
Write a program named ArrayDemo that stores an array of 10 integers. Until the user enters a sentinel value, allow the user four options:

1.to view the list in order from the first to last position in the stored array,

2.to view the list in order from the last to first position,

3.to choose a specific position to view, or

4.to quit the application.

6-2
--
Write a program named TestScoreList that accepts eight int values representing student test scores. Display each of the values along with a message that indicates how far it is from the average.

6-3
--
Write a program named TemperaturesComparison that allows a user to input five daily Fahrenheit temperatures that must range from −30 to 130; if a temperature is out of range, require the user to reenter it. If no temperature is lower than any previous one, display a message Getting warmer. If every temperature is lower than the previous one, display a message Getting cooler. If the temperatures are not entered in either ascending or descending order, display a message It’s a mixed bag. Finally, display the temperatures in the order they were entered, and then display the average of the temperatures.

6-4
--
Write a program named CheckZips that is used by a package delivery service to check delivery areas. The program contains an array that holds the 10 zip codes of areas to which the company makes deliveries. Prompt a user to enter a zip code, and display a message indicating whether the zip code is in the company’s delivery area.

6-5
--
Write a program called DeliveryCharges for the package delivery service in Exercise 4. The program should again use an array that holds the 10 zip codes of areas to which the company makes deliveries. Create a parallel array containing 10 delivery charges that differ for each zip code. Prompt a user to enter a zip code, and then display either a message indicating the price of delivery to that zip code or a message indicating that the company does not deliver to the requested zip code.

6-6
--
The Chat-A-While phone company provides service to six area codes and charges the per-minute rates for phone calls shown in Figure 6-25. Write a program named ChatAWhile that stores the area codes and rates in parallel arrays and allows a user to enter an area code and the length of time for a call in minutes, and then display the total cost of the call.

6-7
--
The Nimble Fingers Typing School assigns grades based on words typed per minute, as shown in Figure 6-26. Write a program named TypingGrades that allows a user to enter a student’s number of words typed. The output is the letter grade.

6-8
--
Write a program for The Carefree Resort named ResortPrices that prompts the user to enter the number of days for a resort stay. Then display the price per night and the total price. Nightly rates are $200 for one or two nights; $180 for three or four nights; $160 for five, six, or seven nights; and $145 for eight nights or more.

6-9
--
In Chapter 5, you wrote a HomeSales application for three salespeople: Danielle, Edward, and Francis. Now, modify the program to use arrays to store the salesperson names, allowed initials, and accumulated sales values.

Case Problems
-----------------------
1
--
In previous chapters, you created applications for the Greenville Idol competition. Now, modify the version of the GreenvilleRevenue program created in Chapter 5 so that after the user enters the number of contestants in this year’s competition, the user is prompted for the appropriate number of contestant names and a code for each contestant that indicates the type of talent: S for singing, D for dancing, M for playing a musical instrument, or O for other. Make sure that all entered codes are valid, and if not, reprompt the user to enter a correct code. After contestant data entry is complete, display a count of each type of talent. Then, continuously prompt the user for a talent code until the user enters a sentinel value. With each code entry, display a list of the contestants with that code, or display a message that the code is not valid and reprompt the user.

2
--
In previous chapters, you created applications for Marshall’s Murals. Now, modify the version of the MarshallsRevenue program created in Chapter 5 so that after mural data entry is complete, the user is prompted for the appropriate number of customer names for both the interior and exterior murals and a code for each that indicates the mural style: L for landscape, S for seascape, A for abstract, C for children’s, or O for other. When a code is invalid, reprompt the user for a valid code continuously. After data entry is complete, display a count of each type of mural. Then, continuously prompt the user for a mural style code until the user enters a sentinel value. With each code entry, display a list of all the customers with that code and whether their mural is interior or exterior. If the requested code is invalid, display an appropriate message and reprompt the user.
