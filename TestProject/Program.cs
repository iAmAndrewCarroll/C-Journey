﻿// // Random dice = new Random();
// // int roll = dice.Next(1, 7);
// // Console.WriteLine(roll);

// // int result = Random.Next();

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

// Write code that generates three random numbers and displays them in output

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// // roll1 = 3;
// // roll2 = 3;
// // roll3 = 1;

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
//     if ((roll1 == roll2) && (roll2 == roll3)) {
//       Console.WriteLine("You rolled trips foool!  DANG!  +6 bonus to total!");
//       total += 6;
//     }
//     else {
//       Console.WriteLine("You rolled doubles! +2 bonus to total!");
//       total += 2;
//     }
//     Console.WriteLine($"Your total including the bonus: {total}");
// }

// if (total >= 16) {
//   Console.WriteLine("You win a new car!");
// }
// else if (total >= 10) {
//   Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7) {
//   Console.WriteLine("You win a trip for two!");
// }
// else {
//   Console.WriteLine("You win a mitten!");
// }


// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("toggle"))
// {
//   Console.WriteLine("What does the fox say?");
// }
// else
// {
//   Console.WriteLine("Eat a dick");
// }

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// // Your code goes here
// Console.WriteLine(daysUntilExpiration);
// if (daysUntilExpiration == 0) {
//   Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1) {
//   Console.WriteLine("Your subscription expires within a day!.");
//   discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5) {
//   Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
// }
// else if (daysUntilExpiration <= 10) {
//   Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0) {
//   Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }
