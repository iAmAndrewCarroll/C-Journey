// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

// int saleAmount = 1001;
// The following line of code is stating that if the saleAmount is greater than 1000, then the discount is 100, otherwise the discount is 50.
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// Review the solution to the conditional operator challenge activity

// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");

// this is the same as the previous code, but it is more concise
// Random coin = new Random();
// Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

// Boolean Expressions Challenge - Decision Logic Challenge
// string permission = "Admin|Manager";
// int level = 56;

// if (permission.Contains("Admin"))
// {
//   if (level > 55)
//   {
//     Console.WriteLine("Welcome, Super Admin user.");
//   }
//   else
//   {
//     Console.WriteLine("Welcome, Admin user.");
//   }
// }
// else if (permission.Contains("Manager"))
// {
//   if (level >= 20)
//   {
//     Console.WriteLine("Contact an Admin for access.");
//   }
//   else
//   {
//     Console.WriteLine("You do not have sufficient privileges.");
//   }
// }
// else
// {
//   Console.WriteLine("You do not have sufficient privileges.");
// }

// Code Blocks & Variable Scope

// variable inside the code block
// bool flag = true;
// if (flag)
// {
//   int value = 10;
//   Console.WriteLine($"Inside the code block: {value}");
// }

// attempt to access variable outside the code block in which it is declared
// bool flag = true;
// int value = 0;

// if (flag)
// {
//   Console.WriteLine($"Inside the code block: {value}");
// }

// value = 10;
// Console.WriteLine($"Outside the code block: {value}");

// Example of an if statement that uses a code block
// bool flag = true;
// if (flag)
// {
//   Console.WriteLine(flag);
// }

// improved for readability
// bool flag = true;
// if (flag) Console.WriteLine(flag);

// a larger if-elseif-else statement
// string name = "steve";
// if (name == "bob") Console.WriteLine("Found Bob");
// else if (name == "steve") Console.WriteLine("Found Steve");
// else Console.WriteLine("Found Chuck");

// // modified for readability
// string name = "steve";

// if (name == "bob")
//     Console.WriteLine("Found Bob");
// else if (name == "steve") 
//     Console.WriteLine("Found Steve");
// else
//     Console.WriteLine("Found Chuck");

// // Inefficient code for the code challenge
// int[] numbers = { 4, 8, 15, 16, 23, 42 };

// foreach (int number in numbers)
// {
//     int total;

//     total += number;

//     if (number == 42)
//     {
//        bool found = true;

//     }

// }

// if (found) 
// {
//     Console.WriteLine("Set contains 42");

// }

// Console.WriteLine($"Total: {total}");

// // Efficient code for the code challenge

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {
//     total += number;
//     if (number == 42)
//         found = true;
// }

// if (found)
//     Console.WriteLine("Set contains 42");

// Console.WriteLine($"Total: {total}");