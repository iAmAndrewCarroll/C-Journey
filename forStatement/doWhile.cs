using System;

public class doWhile
{
  public static void Run()
  {
    // Random random = new();
    // int current = random.Next(1, 11);

    // do
    // {
    //   current = random.Next(1, 11);

    //   if (current >=8) continue;

    //   Console.WriteLine(current);
    // } while (current != 7);

    // Random random = new();
    // int current = random.Next(1, 11);
    
    // while (current >= 3)
    // {
    //   Console.WriteLine(current);
    //   current = random.Next(1, 11);
    // }
    // Console.WriteLine($"Last number: {current}");

    // // Hero RPG
    // int Andrew = 100;
    // int monster = 50;

    // Random dice = new();

    // do
    // {
    //   int roll = dice.Next(1, 11);
    //   monster -=roll;
    //   Console.WriteLine($"Andrew hits the monster for {roll} points. The monster has {monster} health left.");

    //   if (monster <=0) continue;

    //   roll = dice.Next(1, 11);
    //   Andrew -= roll;
    //   Console.WriteLine($"The monster hits Andrew for {roll} points. Andrew has {Andrew} health left.");      
    // } while (Andrew > 0 && monster > 0);

    // Console.WriteLine(Andrew > 0 ? "Andrew wins!" : "The monster wins!");

    // // Code Project 1 - Validate Integer Input
    // // Prompt the user for input
    // Console.WriteLine("Enter a number between 5 & 10:");  

    // // Step 2: initialize variables
    // string? userInput;
    // int validatedInput;

    // // Step 3: Loop until the user enters a valid number (Iteration block)
    // do
    // {
    //   // 3a: Get user input
    //   userInput = Console.ReadLine();

    //   // 3b: Validate input
    //   if (!int.TryParse(userInput, out validatedInput))
    //   {
    //     Console.WriteLine("Sorry, that's not a valid number. Please try again.");
    //     continue; // Skip the rest of the loop
    //   }

    //   // 3c: Check if the number is between 5 & 10
    //   if (validatedInput < 5 || validatedInput > 10)
    //   {
    //     Console.WriteLine($"Sorry, {validatedInput} is not between 5 & 10. Please try again.");  // Skip to the next iteration
    //   }
    // } while (validatedInput < 5 || validatedInput > 10);

    // // Step 4: Acknowledge valid input
    // Console.WriteLine($"Your input, {validatedInput}, is valid. Thank you!");

    // // Code Project 2 - Validate String input
    // // Step 1: Initialize variables
    // string? userRole;
    // bool isValid = false; // To track if input is valid

    // // Step 2: Prompt user
    // Console.WriteLine("Enter your role (Admin, Manager, or User):");

    // // Step 3: Iteration block
    // do
    // {
    //   // 3a: Get user input
    //   userRole = Console.ReadLine();

    //   // 3b: Clean input
    //   userRole = userRole?.Trim().ToLower(); // Handle null, trim whitespace, and convert to lowercase for case-insensitive comparison

    //   // 3c: Validate input
    //   if (userRole == "admin" || userRole == "manager" || userRole == "user")
    //   {
    //     isValid = true; // valid input
    //   }
    //   else
    //   {
    //     Console.WriteLine($"The role name you entered, \"{userRole}\", is not valid.  Enter your role (Admin, Manager, or User):");
    //   }
    // } while (!isValid); // Repeat until input is valid

    // // Step 4: Acknowledge valid input
    // Console.WriteLine($"Your role, {userRole}, has been verified and accepted.  Thank you!");

    // Code Project 3 - Write code that processes the contents of a string array

    // Step 1: Initialize the array
    string[] myStrings = new string[2]
    {
      "I like pizza.  I like burritos.  I like steak.",
      "I like all three of the menu choices."
    };

    // Outer loop
    foreach (string myString in myStrings)
    {
      // Declare a variable to hold the current string
      string currentString = myString;

      // Declare periodLocation
      int periodLocation;

      // Inner Loop
      do
      {
        // Find the period
        periodLocation = currentString.IndexOf(".");

        if (periodLocation != -1)
        {
          // Extract sentence, remove period, and trim whitespace
          string sentence = currentString.Substring(0, periodLocation).TrimStart();

          // Display the sentence
          Console.WriteLine(sentence);

          // Remove the processed sentence from the string
          currentString = currentString.Remove(0, periodLocation + 1);
        }
      } while (periodLocation != -1); // Continue until no more period are found
    }
  }
}