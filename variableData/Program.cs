// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// int[] data = new int[3];

// string shorenedString = "Hello World!";
// Console.WriteLine(shorenedString);

// int val_A = 2;
// int val_B = val_A;
// val_B = 5;

// Console.WriteLine("--Value Types--");
// Console.WriteLine($"val_A: {val_A}");
// Console.WriteLine($"val_B: {val_B}");

// int[] ref_A = new int[1];
// ref_A[0] = 2;
// int[] ref_B = ref_A;
// ref_B[0] = 5;

// Console.WriteLine("--Reference Types--");
// Console.WriteLine($"ref_A[0]: {ref_A[0]}");
// Console.WriteLine($"ref_B[0]: {ref_B[0]}");

// this code throws an error: Cannot implicitly convert type 'string' to 'int'.  Notice that the variable "result" is declared as an int but we are trying to assign a string value to it.  This is not allowed in C#.
// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

// Note, this code shows "24" but the math did not actually happen.  We concatenated the integer 2 with the string "4" to get "24".  We are declaring the int variable "first" with a value of 2 and a string variable "second" with the string value of "4".
// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);
// Output: 24

/*
Since any int value can easily fit inside of a decimal, the compiler performs the conversion.

The term widening conversion means that you're attempting to convert a value from a data type that could hold less information to a data type that can hold more information. In this case, a value stored in a variable of type int converted to a variable of type decimal, doesn't lose information.

When you know you're performing a widening conversion, you can rely on implicit conversion. The compiler handles implicit conversions.
*/
// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");
// Output:
// int: 3
// decimal: 3

/* Perform a cast:
To perform a cast, you use the casting operator () to surround a data type, then place it next to the variable you want to convert (example: (int)myDecimal). You perform an explicit conversion to the defined cast data type (int).
*/
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// Output:
// decimal: 3.14
// int: 3

/* Determine if your conversion is a "widening conversion" or a "narrowing conversion"
The term narrowing conversion means that you're attempting to convert a value from a data type that can hold more information to a data type that can hold less information. In this case, you may lose information such as precision (that is, the number of values after the decimal point). An example is converting value stored in a variable of type decimal into a variable of type int. If you print the two values, you would possibly notice the loss of information.

When you know you're performing a narrowing conversion, you need to perform a cast. Casting is an instruction to the C# compiler that you know precision may be lost, but you're willing to accept it.

If you're unsure whether you lose data in the conversion, write code to perform a conversion in two different ways and observe the changes. Developers frequently write small tests to better understand the behaviors, as illustrated with the next sample.*/

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

// Output:
// Decimal: 1.23456789
// Float  : 1.2345679

// Use ToString() to convert a number to a string
// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// Output: 57 converted to a string

// Convert a string to an int using the Parse() helper method
// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// Output: 12 // this is the sum of the two strings converted to integers

// Convert a string to a int using the Convert class. This example uses the Convert.ToInt32() method to convert a string to an int and then multiplies the two values.
// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// Output: 35 // this is the product of the two strings converted to integers

/* Why is the method name ToInt32()? Why not ToInt()? System.Int32 is the name of the underlying data type in the .NET Class Library that the C# programming language maps to the keyword int. Because the Convert class is also part of the .NET Class Library, it is called by its full name, not its C# name. By defining data types as part of the .NET Class Library, multiple .NET languages like Visual Basic, F#, IronPython, and others can share the same data types and the same classes in the .NET Class Library.

The ToInt32() method has 19 overloaded versions allowing it to accept virtually every data type.

you used the Convert.ToInt32() method with a string here, but you should probably use TryParse() when possible.

So, when should you use the Convert class? The Convert class is best for converting fractional numbers into whole numbers (int) because it rounds up the way you would expect. */

// Compare casting and converting a decimal into an int
// int value = (int)1.5m; // casting truncates the decimal
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

// Output:
// value: 1
// value2: 2

// casting is truncating the decimal value, while converting is rounding up.  The output of the code is:  

// truncating means that the decimal value is removed, while rounding up means that the decimal value is rounded to the nearest whole number.  In this case, the decimal value 1.5 is rounded up to 2.  The output of the code is:  1 2

// Exercise - Examine the TryParse() method

// string name = "Bob";
// Console.WriteLine(int.Parse(name));
// Output: System.FormatException: 'Input string was not in a correct format.'

// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//   Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//   Console.WriteLine("Unable to report the measurement.");
// }

// Output: Measurement: 102

/* Use the parsed int later in code
To demonstrate that the result variable that was declared earlier, is populated by the out parameter and is also usable later in your code, update your code as follows: */
// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//   Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//   Console.WriteLine("Unable to report the measurement.");
// }
// Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// Output:
// Measurement: 102
// Measurement (w/ offset): 152

// Exercise - Complete a challenge to combine string array values as strings and as integers

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal total = 0m;
// string message = "";

// foreach (var value in values)
// {
//   decimal number; // stores the TryParse "out" value
//   if (decimal.TryParse(value, out number))
//   {
//     total += number;
//   } else
//   {
//     message += value;
//   }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

// Exercise - Complete a challenge to output math operations as specific number types

// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// // Your code here to set result1
// // Hint: You need to round the result to nearest integer (don't just truncate)
// int result1 = Convert.ToInt32(value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// // Your code here to set result2
// decimal result2 = value2 / (decimal)value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// // Your code here to set result3
// float result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// Output:
/*
Divide value1 by value2, display the result as an int: 2
Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
Divide value3 by value1, display the result as a float: 0.3909091
*/

// Create an array of pallets, then sort them
// string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }

// Output:
// Sorted...
// -- A11
// -- A13
// -- B12
// -- B14

// Reverse the order of the pallets:
// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }

// Output:
// Sorted...
// -- A11
// -- A13
// -- B12
// -- B14

// Reversed...
// -- B14
// -- B12
// -- A13
// -- A11

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);
// if (pallets[0] != null) // to avoid the error add an `if` statement prior to accessing an array element that is potentially null
//   Console.WriteLine($"After: {pallets[0].ToLower()}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }

// Resize the array to add more elements
// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }

// Resize the array to remove elements
// string[] pallets = [ "B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 .. count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }

// Reverse, then combine the char array into a new string
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// string result = new string(valueArray);
// Console.WriteLine(result);
// Output: 321cba

// Reverse, then combine all the chars into new comma-separated-value string using `Join()`
// string value = "andrew126";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = string.Join(",", valueArray);
// Console.WriteLine(result);
// Output: 6,2,1,w,e,r,d,n,a

// `Split()` the comma-separated-value string into an array of strings
// string value = "andrew126";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = string.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(",");
// foreach(string item in items)
// {
//   Console.WriteLine(item);
// }
// Output:
// 6,2,1,w,e,r,d,n,a
// 6
// 2
// 1
// w
// e
// r
// d
// n
// a 

// Exercise - Complete a challenge to reverse words in a sentence
/*
The following solution provided is one of many possible solutions. The approach taken to solve this challenge was to break down the solution into four steps:

To create the string array message, split the pangram string on the space character.
Create a new newMessagearray that stores a reversed copy of the "word" string from the message array.
Loop through each element in the message array, reverse it, and store this element in newMessage array.
Join "word" strings from the array newMessage, using a space again, to create the desired single string to write to the console.
*/

// string pangram = "The quick brown fox jumps over the lazy dog";

// // Step 1
// string[] message = pangram.Split(' ');

// // Step 2
// string[] newMessage = new string[message.Length];

// // Step 3
// for (int i = 0; i < message.Length; i++)
// {
//   char[] letters = message[i].ToCharArray();
//   Array.Reverse(letters);
//   newMessage[i] = new string(letters);
// }

// // Step 4
// string result = string.Join(" ", newMessage);
// Console.WriteLine(result);

// Output: ehT kciuq nworb xof spmuj revo eht yzal god

// Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] items = orderStream.Split(',');
// Array.Sort(items);

// foreach (var item in items)
// {
//   if (item.Length == 4)
//   {
//     Console.WriteLine(item);
//   }
//   else
//   {
//     Console.WriteLine(item + "\t- Error");
//   }
// }

// // What is Composit Formatting
// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);

// // a step further
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first);
// Console.WriteLine("{0} {0} {0}!", second);

// What is string interpolation?
// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

// Formatting currency
// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");
// Output: Price: $123.45 (Save $50.00)

// Formatting numbers
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");
// Output: Measurement: 123,456.79 units

// Formatting percentages
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);

// Exercise - Explore string interpolation

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"  Shares: {productShares:N3} Product");
// Console.WriteLine($"    Sub Total: {subtotal:C}");
// Console.WriteLine($"      Tax: {taxPercentage:P2}");
// Console.WriteLine($"    Total Billed: {total:C}");

// Discover Padding & Alignment
// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);

// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));

// Working iwht padded strings
// add the payment ID to the output
// string paymentID = "7698C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentID.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);

// Solution to string interpolation
// string customerName = "Mr Carroll";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Videography";
// decimal newReturn = 0.13125m;
// decimal newProfit = 630000000.0m;

// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += string.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += string.Format("{0:C}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);

// Write code to find parenthesis pairs embedded in a string
// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// openingPosition += 1;

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// Write code to find span tags embedded in a string
// string message = "What is the value <span>between the tags</span>?";

// int openingPosition = message.IndexOf("<span>");
// int closingPosition = message.IndexOf("</span>");

// openingPosition += 6;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// Avoid magic values
// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// IndexOf() and LastIndexOf() methods
// string message = "hello there!";

// int first_h = message.IndexOf('h');
// int last_h = message.LastIndexOf('h');

// Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

// Retrieve the last occurrence of a substring
// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// output: set of parentheses

// Retrieve all instances of substrings inside parentheses

// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//   int openingPosition = message.IndexOf('(');
//   if (openingPosition == -1) break;

//   openingPosition += 1;
//   int closingPosition = message.IndexOf(')');
//   int length = closingPosition - openingPosition;
//   Console.WriteLine(message.Substring(openingPosition, length));

//   // Note the overload of the Substring to return only the remaining unprocessed message
//   message = message.Substring(closingPosition + 1);
// }

// Output:
// What if
// more than
// set of parentheses

// Work with different types of symbol sets with IndexOfAny()
// string message = "Hello, World!";
// char [] charsToFind = { 'a', 'e', 'i' };

// int index = message.IndexOfAny(charsToFind);

// Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}."); 

// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";


// char[] openSymbols = { '[', '{', '(' };

// // You'll use a slightly different technique for iterating through 
// // the characters in the string. This time, use the closing 
// // position of the previous iteration as the starting index for the 
// //next open symbol. So, you need to initialize the closingPosition 
// // variable to zero:

// int closingPosition = 0;

// while (true)
// {
//   int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//   if (openingPosition == -1) break;

//   string currentSymbol = message.Substring(openingPosition, 1);

//   // Now find the matching closing symbol
//   char matchingSymbol = ' ';

//   switch (currentSymbol)
//   {
//     case "[":
//       matchingSymbol = ']';
//       break;
//     case "{":
//       matchingSymbol = '}';
//       break;
//     case "(":
//       matchingSymbol = ')';
//       break;
//   }

//   // To find the closingPosition, use an overload of the IndexOf method to specify 
//   // that the search for the matchingSymbol should start at the openingPosition in the string. 

//   openingPosition += 1;
//   closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//   int length = closingPosition - openingPosition;
//   Console.WriteLine(message.Substring(openingPosition, length));
// }
// // Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// // openingPosition = message.IndexOfAny(openSymbols, startPosition);
// // Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");

// Review the solution to extract, replace, and remove data from an input string

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd= input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);

output:
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>