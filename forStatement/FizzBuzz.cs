using System;

public class FizzBuzz
{
  public static void Run()
  {
    for (int i = 1; i <= 100; i++)
    {
      // if (i % 3 == 0 && i % 5 == 0)   This is equivalent to the next line
      if (i % 15 == 0)
        Console.WriteLine($"{i} - FizzBuzz");
      else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
      else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
      else
        Console.WriteLine(i);
    }
  }
}