C#

Console.WriteLine();
- class . method
- class: own’s the method (or, methods live inside of a class)
- . : called the member access operator, ‘navigates’ from the class to the method
- method: always has a set of (), has one job.
    - WriteLine()’s job is to write a line of data to the output console
- ; : end of statement operator
    - statement: a complete instruction in C#
    - the ; tells the compiler that you’ve finished entering the command

character literal
- Console.Write(‘b’) > b

integer literal
- Console.Write(123) > 123

floating point literals
- a floating point number contains a decimal: 123.56
- C# supports three data types to represent decimal numbers
    - float: ~6-9 digits
        - Console.Write(0.25F); > 0.25
        - F is called a literal suffix and tells the compiler you wish to work with a float type.
        - can be upper or lower case 
        - float is least precise, best used with fixed fractional values
    - double: ~15-17 digits
        - just enter a decimal number
        - double literal is the compiler default when a decimal is entered without a literal suffix.
    - decimal: 28-29 digits
        - Console.Write(12.345678m) > 12.345678
        - the m tells the compiler you wish to work with the value of decimal type

Boolean
- Console.WriteLine(true)
- Console.WriteLine(false)
- 
The main takeaway is that there are many data types, but you'll focus on just a few for now:
* string for words, phrases, or any alphanumeric data for presentation, not calculation
* char for a single alphanumeric character
* int for a whole number
* decimal for a number with a fractional component
* bool for a true/false value

A variable is a container for storing a type of value.
- declaring a variable
    - string firstName;
    - creates a variable type ‘string’ called ‘firstName’

Here's a few important considerations about variable names:
* Variable names can contain alphanumeric characters and the underscore character. Special characters like the hash symbol # (also known as the number symbol or pound symbol) or dollar symbol $ are not allowed.
* Variable names must begin with an alphabetical letter or an underscore, not a number.
* Variable names are case-sensitive, meaning that string Value; and string value; are two different variables.
* Variable names must not be a C# keyword. For example, you cannot use the following variable declarations: decimal decimal; or string string;.
Here are some coding conventions for variables:
* Variable names should use camel case, which is a style of writing that uses a lower-case letter at the beginning of the first word and an upper-case letter at the beginning of each subsequent word. For example, string thisIsCamelCase;.
* Variable names should begin with an alphabetical letter. Developers use the underscore for a special purpose, so try to not use that for now.
* Variable names should be descriptive and meaningful in your app. Choose a name for your variable that represents the kind of data it will hold.
* Variable names should be one or more entire words appended together. Don't use contractions or abbreviations because the name of the variable (and therefore, its purpose) may be unclear to others who are reading your code.
* Variable names shouldn't include the data type of the variable. You might see some advice to use a style like string strValue;. That advice is no longer current.
Examples:
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;

Declare variable, assign value, call variable: string firstName;
firstName = "Bob";
Console.WriteLine(firstName);

string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

Initialize the variable:
string firstName = "Bob”;
Console.WriteLine(firstName);

Implicitly typed local variable is created by using the var keyword followed by a variable initialization. For example:
var message = "Hello world!”;
- var: keyword tells C# compiler the data type is implied by the assigned value.  Var is used to save keystrokes when types are lengthy or when they are obvious from the context.
- the variable "message" is immediately set to the string value "Hello world!" the C# compiler understand the intent and treats every instance of message as an instance type of string.
- variables using the 'var' keyword must be initialized at the time of declaration.

The var keyword tells the compiler to infer the data type of the variable based on the value it is initialized to.
You'll likely see the var keyword as you read other people's code; however, you should use the data type when possible.

Example
var firstName = "Bob";
var count = 3;
var temperature = 34.4;

Console.WriteLine($"Hello, {firstName}! You have {count} messages in your inbox.  The temperature is {temperature} celsius.");

Output: Hello, Bob! You have 3 messages in your inbox.  The temperature is 34.4 celsius.

You could also use: var temperature = 34.4m to specify the decimal type.  The m tells the compiler you wish to work with the value of decimal type

Formatting with escape sequences
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

Output:
Generating invoices for customer "Contoso Corp" ...

Invoice: 1021		Complete!
Invoice: 1022		Complete!

Output Directory:

Verbatim String Literal
- a verbatim string literal is a string that is prefixed with the @ symbol
Console.WriteLine(@"     c:\source\repos
     (this is where your code goes)");
Output:
     c:\source\repos
     (this is where your code goes)

Format output using verbatim string literals
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// user command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

Output: showed string literal values for unicode characters

Concatenation
string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

Console.WriteLine($"Hello {firstName}!");

Output: Hello Bob!

String concatenation allows you to combine smaller literal and variable strings into a single string.
Avoid creating intermediate variables if adding them doesn't increase readability.

String Interpolation is a way to construct strings that include variables.  It is a more readable and maintainable way to combine strings and variables.
- previously we wrote `string message = greeting + " " + firstName + "!";`
- with string interpolation, we can write `string message = $"{greeting} {firstName}!";`

Use string interpolation with multiple variables and literal strings
int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);

Output: Update to Windows 11

Now avoid intermediate variables:
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

Output: Update to Windows 11!

Verbatim Literals and String Interpolation
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

Output: C:\Output\First-Project\Data

String interpolation provides an improvement over string concatenation by reducing the number of characters required in some situations.
You can combine string interpolation and verbatim literals by combining the symbols for each and using that as a prefix for the string template.

A Coding Challenge:
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
var ruski = $@"c:\Exercise\{projectName}\ru-RU\data.txt";

var english = "View English output:";
var directory = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($@"{english}
    {directory}

{russianMessage}
    {ruski}");

Output:
View English output:
    c:\Exercise\ACME\data.txt

Посмотреть русский вывод
    c:\Exercise\ACME\ru-RU\data.txt

OR THIS *BETTER* SOLUTION:
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

Output:
View English output:
    c:\Exercise\ACME\data.txt

Посмотреть русский вывод
    c:\Exercise\ACME\ru-RU\data.txt


Exercise - Perform addition with implicit data conversion
Add two numeric values
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

Output: 19

Mix data types to force implicit type conversions

string firstName = "Bob";
int widgetSold = 7;
Console.WriteLine(firstName + " sold " + widgetSold + " widgets.");

Output: Bob sold 7 widgets.

string firstName = "Bob";
int widgetSold = 7;
Console.WriteLine(firstName + " sold " + (widgetSold + 7) + " widgets.");

Output: Bob sold 14 widgets.

Here's what you've learned so far about mathematical operations in C#:

You can perform mathematical-like addition operations on numbers.
Both string concatenation and addition use the plus + symbol. This is called overloading an operator, and the compiler infers the proper use based on the data types it's operating on.
When it can, the C# compiler will implicitly convert an int into a string if it's obvious that the developer is trying to concatenate the string representation of a number for presentation purposes.
Use parentheses to define an order of operations to explicitly tell the compiler that you want to perform certain operations before other operations.

Perform Basic Math Operations
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Diff: " + difference);
Console.WriteLine("Prod: " + product);
Console.WriteLine("Quotient: " + quotient);

Output:
Sum: 12
Diff: 2
Prod: 35
Quotient: 1

Adding code to perfomr division using literal decimal data:
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

Output: Decimal quotient: 1.4

Add code to cast results of integer division:
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

Output: 1.4

Write Code to determine the remainder of a division operation:
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

Output: 
Modulus of 200 / 5 : 0
Modulus of 7 / 5 : 2

Write Code to exercise C#'s order of operations:
int value1 = 3 + 4 * 5;
int value2 = (3 +4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

Output:
23
35

Here's what you've learned so far about mathematical operations in C#:

Use operators like +, -, *, and / to perform basic mathematical operations.
The division of two int values will result in the truncation of any values after the decimal point. To retain values after the decimal point, you need to cast the divisor or dividend (or both) from int into a floating point number like decimal first, then the quotient must be of the same floating point type as well in order to avoid truncation.
Perform a cast operation to temporarily treat a value as if it were a different data type.
Use the % operator to capture the remainder after division.
The order of operations will follow the rules of the acronym PEMDAS.

Exercise - Increment and decrement values
int value = 0; // value is now 0
value = value + 5; // value is now 5
value += 5; // value is now 10

int value = 0; // value is now 0
value = value + 1; // value is now 1
value++ // value is now 2

Write code to increment and decrement values:
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second incrememnt: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

Output:
First increment: 2
Second incrememnt: 3
Third increment: 4
First decrement: 3
Second decrement: 2
Third decrement: 1

Position the increment and decrement operators:
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

Output:
First: 2
Second: 2
Third: 3
Fourth: 4

Here's what you've learned so far about mathematical operations in C#:

Use compound assignment operators like +=, -=, *=, ++, and -- to perform a mathematical operation like increment or decrement, then assign the result into the original variable.
Increment and decrement operators perform differently depending on whether the operator is before or after the operand.

Challenge: Calculatet Celsius given Fahrenheit:
decimal fahrenheit = 94m;
decimal convert = ((fahrenheit - 32) * 5 / 9);
Console.WriteLine("The temperature is " + convert + " Celsius."); 

Output: The temperature is 34.444444444444444444444444444 Celsius.

Given Solution:
int fahrenheit = 94;
decimal convert = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + convert + " Celsius."); 

Output:The temperature is 34.444444444444444444444444447 Celsius.

Guided Project - Calculate and Print Grades

int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

Output:
Student         Grade

Sophia:         94.6    A
Nicolas:        83.6    B
Zahirah:        83.4    B
Jeong:          95.4    A


Guided Project: Calulate Final GPA
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

// Console.WriteLine($"{totalGradePoints} {totalCreditHours}"); this line verified our values.
decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

int leadingDigit = (int) gradePointAverage; // init var stores leading digit of GPA
int firstDigit = (int) (gradePointAverage * 10) % 10;
// In the first half of this operation, you move the decimal one place to the right and cast it to an integer. In the second half, you use the remainder, or modulo, operator to get the remainder of division by 10, which isolates the last digit in the integer.
int secondDigit = (int) (gradePointAverage * 100 ) % 10;

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");
Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{firstDigit}{secondDigit}");

Output (the code is right it just isn't formatting the output here correctly):
Student: Sophia Johnson

Course				     Grade	Credit Hours
English 101			   4		  3
Algebra 101			   3		  3
Biology 101			   3		  4
Computer Science I  3		4
Psychology 101	    4		3

Final GPA:			3.35