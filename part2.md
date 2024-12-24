The structure of a CLI command consists of the following three parts:

`dotnet new console -o ./CsharpProjects/TestProject`

The driver: dotnet in this example.
The command: new console in this example.
The command arguments: -o ./CsharpProjects/TestProject in this example.

Some Commands:
`dotnet new console -o ./CsharpProjects/TestProject`
- Creates a new console application in the TestProject directory.

`dotnet build`
- Builds the project.

`dotnet run`
- Runs the project.

Write code that calls methods in the .NET Class Library.
Use an instance of .NET Class Library classes to call methods that maintain state.
Use Intellisense in Visual Studio Code to learn more about a method, including its overloaded versions, its return value type, and its input parameter data types.
Use learn.microsoft.com to research what a method does, its overloaded versions, its return value type, its input parameters and what each parameter represents, and more.


Stateful vs Stateless methods
- Stateful (instance) methods keep track of their state in fields, which are variables defined on the class. Each new instance of the class gets its own copy of those fields in which to store state.
- Stateless methods don't rely on the current state of the application to work properly. In other words, stateless methods are implemented so that they can work without referencing or changing any values already stored in memory. Stateless methods are also known as static methods.  Console.Write() is an example of a stateless method because it doesn't rely on anything else in the application to work properly.

Random dice = new Random();  // could also be Random dice = new()
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

Outputs a random number between 1 and 6.

The new operator does several important things:

It first requests an address in the computer's memory large enough to store a new object based on the Random class.
It creates the new object, and stores it at the memory address.
It returns the memory address so that it can be saved in the dice object.

How can you determine whether you need to create an instance of a class before calling its methods?
One approach for determining whether a method is stateful or stateless is to consult the documentation. The documentation includes examples that show whether the method must be called from the object instance or directly from the class.

To call methods of a class in the .NET Class Library, you use the format ClassName.MethodName(), where the . symbol is the member access operator to access a method defined on the class, and the () symbols are the method invocation operators.
When calling a stateless method, you don't need to create a new instance of its class first.
When calling a stateful method, you need to create an instance of the class, and access the method on the object.
Use the new operator to create a new instance of a class.
An instance of a class is called an object.

In the dice scenario, you assigned the return value of Random.Next() to the roll variable:
int roll = dice.Next(1, 7);

NOTE:
Often times, the terms 'parameter' and 'argument' are used interchangeably. However, 'parameter' refers to the variable that's being used inside the method. An 'argument' is the value that's passed when the method is called.

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

The first code line creates an instance of the Random class named dice. The second code line uses the dice.Next(1, 7) method to assign a random value to an integer named roll. Notice that the calling statement provides two arguments separated by a , symbol. The Next() method includes a method signature that accepts two parameters of type int. These parameters are used to configure the lower and upper boundaries for the random number that's returned. The final code line uses the Console.WriteLine() method to print the value of roll to the console.

The arguments passed to a method must be the same data type as the corresponding parameters defined by the method. If you attempt to pass an incorrectly typed argument to a method, the C# compiler will catch your mistake and force you to update your calling statement before your code will compile and run. Type checking is one way that C# and .NET use to prevent end-users from experiencing errors at runtime.

int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

In this example, you're invoking three separate overloaded versions of the WriteLine() method.

The first WriteLine() method uses a method signature that defines an int parameter.
The second WriteLine() method uses a method signature that defines zero parameters.
The third WriteLine() method uses a method signature that defines a string parameter.

The following exercise calls the Random.Next() method to generate random integer values with different levels of constraint:

Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

Output:
First roll: 1595344858
Second roll: 82
Third roll: 72

Take a minute to examine the code.

The first version of the Next() method doesn't set an upper and lower boundary, so the method will return values ranging from 0 to 2,147,483,647, which is the maximum value an int can store.

The second version of the Next() method specifies the maximum value as an upper boundary, so in this case, you can expect a random value between 0 and 100.

The third version of the Next() method specifies both the minimum and maximum values, so in this case, you can expect a random value between 50 and 100.

EXERCISE: FIND THE LARGER OF TWO NUMBERS USING SYSTEM.MATH CLASS
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);

Output:
600

What is an object?
- An instance of a class

Which of the following statements is true?
- The .NET Class Library contains definitions for data types used in C#.

Which of the following symbols represents the method invocation operator required to execute a method?
- ()

In this module, you will:

Write code that evaluates conditions by using the statements if, else, and else if.
Build Boolean expressions to evaluate a condition.
Combine Boolean expressions using logical operators.
Nest code blocks within other code blocks.

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

Output: Dice roll: 6 + 2 + 6 = 14

To begin, you create a new instance of the System.Random class and store a reference to the object in a variable named dice. Then, you call the Random.Next() method on the dice object three times, providing both the lower and upper bounds to restrict the possible values between 1 and 6 (the upper bound is exclusive). You save the three random numbers in the variables roll1, roll2, and roll3, respectively.

Next, you sum the three dice rolls and save the value into an integer variable named total.

Finally, you use the WriteLine() method to display the three values using string interpolation.

if (total > 14) {
  Console.WriteLine("You win!");
}

if (total < 15) {
  Console.WriteLine("Sorry, you lose.");
}

Output:
Dice roll: 3 + 2 + 3 = 8
Sorry, you lose.

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
  Console.WriteLine("You rolled dubs babyyyyyyy!  +2 bonus to total!");
  total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3)) {
  Console.WriteLine("You rolled trips foool!  DANG!  +6 bonus to total!");
  total += 6;
}

if (total >= 15) {
  Console.WriteLine("You win!");
}

if (total < 15) {
  Console.WriteLine("Sorry, you lose.");
}

Output:
Dice roll: 4 + 6 + 6 = 16
You win!
You rolled dubs babyyyyyyy!  +2 bonus to total!

More Nested If Else Statements:
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// roll1 = 3;
// roll2 = 3;
// roll3 = 1;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
      Console.WriteLine("You rolled trips foool!  DANG!  +6 bonus to total!");
      total += 6;
    }
    else {
      Console.WriteLine("You rolled doubles! +2 bonus to total!");
      total += 2;
    }
    Console.WriteLine($"Your total including the bonus: {total}");
}

if (total >= 16) {
  Console.WriteLine("You win a new car!");
}
else if (total >= 10) {
  Console.WriteLine("You win a new laptop!");
}
else if (total == 7) {
  Console.WriteLine("You win a trip for two!");
}
else {
  Console.WriteLine("You win a mitten!");
}

Output:
Dice roll: 3 + 3 + 1 = 7
You rolled doubles! +2 bonus to total!
Your total including the bonus: 9
You win a mitten!

BOOLEAN

string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("toggle"))
{
  Console.WriteLine("What does the fox say?");
}
else
{
  Console.WriteLine("Eat a dick");
}

Output:
True
Eat a dick

Other Boolean experssions:
==, the "equals" operator, to test for equality
>, the "greater than" operator, to test that the value on the left is greater than the value on the right
<, the "less than" operator, to test that the value on the left is less than the value on the right
>=, the "greater than or equal to" operator
<=, the "less than or equal to" operator

BUSINESS RULES EXERCISE:

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
Console.WriteLine(daysUntilExpiration);
if (daysUntilExpiration == 0) {
  Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1) {
  Console.WriteLine("Your subscription expires within a day!.");
  discountPercentage = 20;
}
else if (daysUntilExpiration <= 5) {
  Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
}
else if (daysUntilExpiration <= 10) {
  Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0) {
  Console.WriteLine($"Renew now and save {discountPercentage}%.");
}

Output:
1
Your subscription expires within a day!
Renew now and save 20%.

In this module you will:

Create and initialize a new array.
Assign and retrieve the values of array elements.
Iterate through each element of an array using the foreach statement.

Get started with array basics
What is an array?
An array is a collection of individual data elements accessible through a single variable name. You use a zero-based numeric index to access each element of an array. Arrays allow you to create a collection of data values that shares a common purpose or characteristics under a single variable name for easier processing.

Declaring arrays and accessing array elements
An array is a special type of variable that can hold multiple values of the same data type. The declaration syntax is slightly different for an array because you have to specify both the data type and the size of the array.

`string[] fraudulentOrderIDs = new string[3];`

The new operator creates a new instance of an array in the computer's memory that can hold three string values. For more information about the new keyword, see the module "Call methods from the .NET Class Library using C#".

Notice that the first set of square brackets [] merely tells the compiler that the variable named fraudulentOrderIDs is an array, but the second set of square brackets [3] indicates the number of elements that the array can hold.

string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000"; // This will throw an exception

// initial build: dotnet build creates the obj folder

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// run with dotnet run
Output:
First: A123
Second: B456
Third: C789

Added:
fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

New Output:
First: A123
Second: B456
Third: C789
Reassign First: F000

Modification to the code (DRY):

string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Output:
First: A123
Second: B456
Third: C789
Reassign First: F000

Here's the most important things to remember when working with arrays:

An array is a special variable that holds a collection of related data elements.
You should memorize the basic format of an array variable declaration.
Access each element of an array to set or get its values using a zero-based index inside of square brackets.
If you attempt to access an index outside of the boundary of the array, you get a run time exception.
The Length property gives you a programmatic way to determine the number of elements in an array.

FOR EACH:
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names) {
  Console.WriteLine(name);
}

Output: Rowena Robin Bao

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory) 
{
  sum += items;
}

Console.WriteLine($"We have {sum} items in inventory.");

Output: We have 1775 items in inventory.

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory) 
{
  sum += items;
  bin++;
  Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");

Output: 
Bin 1 = 200 items (Running total: 200)
Bin 2 = 450 items (Running total: 650)
Bin 3 = 700 items (Running total: 1350)
Bin 4 = 175 items (Running total: 1525)
Bin 5 = 250 items (Running total: 1775)
We have 1775 items in inventory.

Recap
Here's a few things to remember about foreach statements and incrementing values that you learned in this unit:

Use the foreach statement to iterate through each element in an array, executing the associated code block once for each element in the array.
The foreach statement sets the value of the current element in the array to a temporary variable, which you can use in the body of the code block.
Use the ++ increment operator to add 1 to the current value of a variable.

string[] newIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string id in newIDs) {
  if (id.StartsWith("B")) {
    Console.WriteLine(id);
  }
}

Output: B123 B177 B179

Learning objectives
In this module, you will:

Choose a descriptive name for variables that describe their purpose and intent.
Use code comments to temporarily instruct the compiler to ignore lines of code.
Use code comments to describe higher-level requirements or purpose for a passage of code.
Write code that effectively uses whitespace to convey the relationship of lines of code.

Variable name rules
There are some variable naming rules that are enforced by the C# compiler.

Variable names can contain alphanumeric characters and the underscore (_) character. Special characters like the pound #, the dash -, and the dollar sign $ are not allowed.
Variable names must begin with an alphabetical letter or an underscore, not a number. Using an underscore character to start a variable name is typically reserved for private instance fields. A link to further reading can be found in the module summary.
Variable names must NOT be a C# keyword. For example, these variable name declarations won't be allowed: float float; or string string;.
Variable names are case-sensitive, meaning that string MyValue; and string myValue; are two different variables.
Variable name conventions
Conventions are suggestions that are agreed upon by the software development community. While you're free to decide not to follow these conventions, they're so popular that it might make it difficult for other developers to understand your code. You should practice adopting these conventions and make them part of your own coding habits.

Variable names should use camel case, which is a style of writing that uses a lower-case letter at the beginning of the first word and an upper-case letter at the beginning of each subsequent word. For example: string thisIsCamelCase;.
Variable names should be descriptive and meaningful in your application. You should choose a name for your variable that represents the kind of data it will hold (not the data type). For example: bool orderComplete;, NOT bool isComplete;.
Variable names should be one or more entire words appended together. Don't use contractions because the name of the variable may be unclear to others who are reading your code. For example: decimal orderAmount;, NOT decimal odrAmt;.
Variable names shouldn't include the data type of the variable. You might see some advice to use a style like string strMyValue;. It was a popular style years ago. However, most developers don't follow this advice anymore and there are good reasons not to use it.

Examples:
char userOption;

int gameScore;

float particlesPerMillion;

bool processedCustomer;

/*
  The following code creates five random OrderIDs to test the 
  fraud detection process.  OrderIDs consist of a letter from A
  to E, and a three digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
  int prefixValue = random.Next(65, 70);
  string prefix = Convert.ToChar(prefixValue).ToString();
  string suffix = random.Next(1, 1000).ToString("000");

  orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
  Console.WriteLine(orderID);
}

Output:
A381
C291
B599
B560
E314

The main takeaways from this exercise:

Use code comments to leave meaningful notes to yourself about the problem your code solves.
Don't use code comments that explain how C# or the .NET Class Library works.
Use code comments when temporarily trying alternative solutions until you're ready to commit to the new code solution, at which point you can delete the old code.
Never trust comments. They may not reflect the current state of the code after many changes and updates.

FOREACH & if-elseif-else GUIDED PROJECT

Learning objectives
In this module, you'll practice how to:

Use Visual Studio Code to develop a C# console application that uses foreach loops to access array data.
Use if statements to evaluate expressions and create code branches.

