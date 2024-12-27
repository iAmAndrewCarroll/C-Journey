// for (int i = 0; i < 10; i++)
// {
//   Console.WriteLine(i);
// }

// for (int i = 10; i >= 0; i--)
// {
//   Console.WriteLine(i);
// }

// for (int i = 0; i < 10; i += 3)
// {
//   Console.WriteLine(i);
// }

// for (int i = 0; i < 10; i++)
// {
//   Console.WriteLine(i);
//   if (i == 7) break;
// }

// this for loop will print the names in reverse order
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//   Console.WriteLine(names[i]);
// }

// // This for loop will not change the name "David" to "Sammy"
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// foreach (var name in names)
// {
//   // Can't do this:
//   if (name == "David") name = "Sammy";
// }

// // This for loop will change the name "David" to "Sammy"
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++)
//   if (names[i] == "David") names[i] = "Sammy";

// foreach (var name in names) Console.WriteLine(name);

// // This is the "same" code but formatted differently.  It depends on your readability preference.
// string[] names = { "Alex", "Eddie", "David", "Michael" };

// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == "David")
//     {
//         names[i] = "Sammy";
//     }
// }

// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }

using System;
class Program
{
  static void Main(string[] args)
  {
    // Console.WriteLine("Starting FizzBuzz:");

    // // call the static method Run from the FizzBuzz class
    // FizzBuzz.Run();

    // Console.WriteLine("...Ending FizzBuzz...");

    Console.WriteLine("Starting doWhile:");

    // call the static method Run from the doWhile class
    doWhile.Run();

    Console.WriteLine("...Ending doWhile...");
  }
}