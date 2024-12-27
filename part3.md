Learning objectives

Use operators to create Boolean expressions that test for comparison and equality.
Use built-in methods of the string class to perform better evaluations on strings.
Use the negation operator to test for the opposite of a given condition.
Use the conditional operator to perform an inline evaluation.

What is an expression?
An expression is any combination of values (literal or variable), operators, and methods that return a single value. A statement is a complete instruction in C#, and statements comprise one or more expressions. For example, the following if statement contains a single expression that returns a single value:

`if (myName == "Luiz")`

In this case, when you're developing an if selection statement, you'll be using an expression that returns either true or false. Developers refer to this type of expression as a Boolean expression. When your code includes a Boolean expression, return value is always a single true or false value.

Evaluating equality and inequality
One of the most common code evaluations is a check to see whether two values are equal. When checking for equality, you'll locate the equality operator == between the two values being checked. If the values on either side of the equality operator are equivalent, then the expression will return true. Otherwise, it will return false.

Conversely, you might also need to check whether two values aren't equal. To check for inequality, you'll use the inequality operator != between the two values.

Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

Output:
True
False
False
True

Before you check two string values for equality, especially when one or both values were entered by a user, you should:

Make sure both strings are all upper-case or all lower-case using the ToUpper() or ToLower() helper method on any string value.
Remove any leading or trailing blank spaces using the Trim() helper method on any string value.

You can improve the previous equality check by chaining these two helper methods on both values, as shown in the following code listing:

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Output: True

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");

Output:
False
True
True
False

Evaluating comparisons
When working with numeric data types, you might want to determine if a value is larger or smaller than another value. Use the following operators to perform these types of comparisons:

Greater than >
Less than <
Greater than or equal to >=
Less than or equal to <=
Naturally, the == and != operators that you used to compare string values above will also work when comparing numeric data types.

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

Output:
False
True
True
True

Use a method that returns a Boolean
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

Output:
True
False

What is logical negation?
The term "Logical Negation" refers to the unary negation operator !. Some people call this operator the "not operator". When you place the ! operator before a conditional expression (or any code that's evaluated to either true or false), it forces your code to reverse its evaluation of the operand. When logical negation is applied, the evaluation produces true , if the operand evaluates to false , and false , if the operand evaluates to true.

Here is an example that might help you to see the connection between these ideas. The following two lines of code produce the same result. The second line is more compact.

// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

Use the Logical Negation operator

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

Output:
False
True

Inequality operator versus logical negation
The inequality operator != includes a ! character, but should not be confused with logical negation. The inequality operator returns true if its operands aren't equal, and returns false if the operands are equal. For the operands of the built-in types, the expression x != y produces the same result as the expression !(x == y) (an example of logical negation).

The following code sample demonstrates the use of the != operator:

int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False

Here's the main takeaways you learned about evaluating Boolean expressions so far:

There are many different kinds of expressions that evaluate to either true or false.
Evaluate equality using the == operator.
Evaluating equality of strings requires you to consider the possibility that the strings have different case and leading or trailing spaces. Depending on your situation, use the ToLower() or ToUpper() helper methods, and the Trim() helper method to improve the likelihood that two strings are equal.
Evaluate inequality using the != operator.
Evaluate greater than, less than and similar operations using comparison operators like >, <, >=, and <=.
If a method returns a bool, it can be used as a Boolean expression.
Use the logical negation operator ! to evaluate the opposite of a given expression.

What is the conditional operator?
The conditional operator ?: evaluates a Boolean expression and returns one of two results depending on whether the Boolean expression evaluates to true or false. The conditional operator is commonly referred to as the ternary conditional operator.

Here's the basic form:
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

Example Use Case:
Suppose you need to quickly determine whether a customer's purchase is eligible for a promotional discount. The details for the promotion indicate that when a purchase value is greater than 1000 euros, the purchase is eligible for a 100 euro discount. If the purchase amount is 1000 euros or less, the purchase is eligible for a 50 euro discount.

While you could certainly use the if ... elseif ... else branching construct to express this business rule, using the conditional operator to evaluate eligibility for the promotional discount might be a better choice. The conditional operator uses a compact format that saves a few lines of code and possibly makes the intent of the code clearer.

int saleAmount = 1001;
// The following line of code is stating that if the saleAmount is greater than 1000, then the discount is 100, otherwise the discount is 50.
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

Output: Discount: 100

Use the conditional operator inline
You can compact this code even more by eliminating the temporary variable discount.

int saleAmount = 1001;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

Output: Discount: 100

You should remember the following facts about the conditional operator:

You can use the conditional operator to reduce the size of your code, but you should ensure that the resulting code is easily readable.
You can use the conditional operator when you need to return a value that's based on a binary condition. Your code will return the first option when the condition evaluates to true, and it will return the second option when the condition evaluates to false.

Review the solution to the conditional operator challenge activity

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

or

// this is the same as the previous code, but it is more concise
Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

Decision logic challenge
In this challenge, you'll implement decision logic based on a series of business rules. The business rules specify the access that will be granted to users based on their role-based permissions and their career level. Code branches will display a different message to the user depending on their permissions and level.

Your application will be using a combination of permission and level to apply/evaluate the business rules in this challenge scenario. The full list of conditions for business rules is specified in the next step. Your completed solution must use permission and level.

# Business Rules for Access Levels

The following are the business rules that your solution must satisfy:

## Rules

1. **Admin Users**
   - If the user is an **Admin** with a **level greater than 55**, output the message:
     ```plaintext
     Welcome, Super Admin user.
     ```
   - If the user is an **Admin** with a **level less than or equal to 55**, output the message:
     ```plaintext
     Welcome, Admin user.
     ```

2. **Manager Users**
   - If the user is a **Manager** with a **level of 20 or greater**, output the message:
     ```plaintext
     Contact an Admin for access.
     ```
   - If the user is a **Manager** with a **level less than 20**, output the message:
     ```plaintext
     You do not have sufficient privileges.
     ```

3. **Other Users**
   - If the user is **not an Admin or a Manager**, output the message:
     ```plaintext
     You do not have sufficient privileges.
     ```

---

Make sure your solution adheres to these rules when determining the appropriate output for each user role and level.

// Boolean Expressions Challenge - Decision Logic Challenge
string permission = "Admin|Manager";
int level = 56;

if (permission.Contains("Admin"))
{
  if (level > 55)
  {
    Console.WriteLine("Welcome, Super Admin user.");
  }
  else
  {
    Console.WriteLine("Welcome, Admin user.");
  }
}
else if (permission.Contains("Manager"))
{
  if (level >= 20)
  {
    Console.WriteLine("Contact an Admin for access.");
  }
  else
  {
    Console.WriteLine("You do not have sufficient privileges.");
  }
}
else
{
  Console.WriteLine("You do not have sufficient privileges.");
}

Remember:

Logical negation: The ! operator reverses the evaluation of a conditional expression.
`Console.WriteLine(!value);`

Conditional operator: The ?: operator evaluates a Boolean expression and returns one of two results depending on whether the Boolean expression evaluates to true or false.
`int value = amount >= 10 ? 10 : 20;`

Control Variable Scope and Logic Using Code Blocks in C#

Learning objectives
In this module, you will:

Understand the impact of declaring and initializing variables inside and outside of code blocks.
Improve the readability code blocks in if statements.

// variable inside the code block
// bool flag = true;
// if (flag)
// {
//   int value = 10;
//   Console.WriteLine($"Inside the code block: {value}");
// }
Output: Inside the code block: 10

// attempt to access variable outside the code block in which it is declared
bool flag = true;
if (flag)
{
  int value = 10;
  Console.WriteLine($"Inside the code block: {value}");
}
Console.WriteLine($"Outside the code block: {value}");

The above code block will produce a compilation error because the variable value is declared inside the code block and is not accessible outside of the code block.

This error is generated because a variable that's declared inside a code block is only accessible (can only be seen) within that code block. Since a variable cannot be accessed outside the code block in which it's declared, value cannot be accessed from line 7 of your code.

A variable that's declared in a method code block is referred to as a local variable. You may see the term local variable used when reviewing articles that discuss variable scope.

// attempt to access variable outside the code block in which it is declared
bool flag = true;
int value;

if (flag)
{
  int value = 10;
  Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");

Output: error CS0136: A local variable named 'value' cannot be declared in this scope because it would give a different meaning to 'value', which is already used in a 'child' scope to denote something else.
- if the code line `value = 10` was located above the `if` statement, the code would compile and run without errors.

Corrected code block and variable scope:
bool flag = true;
int value = 0;

if (flag)
{
  Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");

Output:
Inside the code block: 0
Outside the code block: 10

Check the Knowledge:
 A developer writes some code that includes an if statement code block. They initialize one integer variable to a value of 5 above (outside) of the code block. They initialize a second integer variable to a value of 6 on the first line inside of the code block. The Boolean expression for the code block evaluates to true if the first integer variable has a value greater than 0. On the second line inside the code block, they assign the sum of the two values to the first variable. On the first line after the code block, they write code to display the value of the first integer. What is the result when the code statement used to display the first integer is executed?  (example code)

```csharp
int firstValue = 5; // Initialized outside the code block

if (firstValue > 0) // Boolean expression evaluates to true if firstValue > 0
{
    int secondValue = 6; // Initialize second integer variable to 6
    firstValue = firstValue + secondValue; // Assign the sum of the two values to firstValue
}

Console.WriteLine(firstValue); // Display the value of firstValue
```

### Explanation:

1. **Initialization Outside the Block:**
   - `firstValue` is initialized to `5` outside of the `if` block.

2. **Boolean Condition:**
   - The condition `firstValue > 0` evaluates to `true` because `5 > 0`.

3. **Inside the Block:**
   - `secondValue` is initialized to `6`.
   - `firstValue` is updated to the sum of `firstValue` (`5`) and `secondValue` (`6`), so `firstValue` becomes `11`.

4. **Outside the Block:**
   - The `Console.WriteLine` statement displays the updated value of `firstValue`, which is `11`.

if-elseif-else statement blocks
// modified for readability
string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");


Recap
Here are a few important things to remember about if statement code blocks and readability:

If you realize you have only one line of code listed within the code blocks of an if-elseif-else statement, you can remove the curly braces of the code block and white space. Microsoft recommends that curly braces be used consistently for all of the code blocks of an if-elseif-else statement (either present or removed consistently).
Only remove the curly braces of a code block when it makes the code more readable. It's always acceptable to include curly braces.
Only remove the line feed if it makes the code more readable. Microsoft suggests that your code will be more readable when each statement is placed on its own code line.

Variable scope challenge
In this challenge, you'll use what you've learned about code blocks and variable scope to fix the poorly written code sample provided. There are many improvements that you can make. Good luck!

Code challenge: update problematic code in the code editor

Original code:
```csharp
int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
       bool found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
```

My Modification Code:
```csharp
int[] numbers = { 4, 8, 15, 16, 23, 42, };
int total = 0;

foreach (int number in numbers)
{
  total += number;

  if (number == 42)
  {
    bool found = true;
      if (found)
      {
        Console.WriteLine("Set contains 42");
      }
  }
}

Console.WriteLine($"Total: {total}");
```

Solution Code:
```csharp
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
```

The biggest changes to the problematic code included:

Moving the declaration of the total and found variables outside of the foreach statement.
Initializing both the total and found variables with sensible default values.
Removing the code blocks (curly braces) from the if statements.
No matter how you formatted the code, when you run the code, you should see the following output:
Set contains 42
Total: 108

**Branch the flow of code using the switch-case construct in C#**

Learning objectives
In this module, you will:

Use the switch-case construct to match a variable or expression against several possible outcomes.
Convert code that uses an if-elseif-else construct into a switch-case construct.

Exercise - Implement a switch statement
200 XP
11 minutes
A switch statement is a C# selection statement that provides an alternative to an if-elseif-else branching construct. The switch statement provides advantages over an if-elseif-else construct when evaluating a single value against a list of known matching values.

Consider the following scenario:

- You're working on an application related to food nutrition. A section of the code deals with fruits.
- Your code includes a variable named fruit that's used to hold the name of different types of fruit.
- You have a list of the 20 fruits that your application is focused on.
- You want to branch your code based on the value assigned to fruit.

In this scenario, you can use a switch statement to create a separate branch for each type of fruit.

How does a switch statement work?
The switch statement chooses one section of code to execute from a list of possible switch sections. The selected switch section is chosen based on a pattern match with the statement's match expression.

Consider the following code sample that shows the basic structure of switch statement:

```csharp
switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
}
```
The match expression (which may also be referred to as the switch expression) is the value following the switch keyword, in this case (fruit). Each switch section is defined by a case pattern. Case patterns are constructed using the keyword case followed by a value. The first case pattern in this example is: case "apple":. Case patterns are Boolean expressions that evaluate to either true or false. Each switch section includes a small number of code lines that will be executed if the case pattern is a match for the match expression. In this example, if fruit is assigned a value of "apple", the first case pattern will evaluate as true and that switch section will be executed.

A switch statement must include at least one switch section, but will normally contain three or more switch sections.

The switch is best used when:

You have a single value (variable or expression) that you want to match against many possible values.
For any given match, you need to execute a couple of lines of code at most.

**example code**
```csharp
int employeeLevel = 400;
string employeeName = "Andrew Carroll";

string title = "";

switch (employeeLevel)
{
  case 100:
    title = "Junior Associate";
    break;
  case 200:
    title = "Senior Associate";
    break;
  case 300:
    title = "Manager";
    break;
  case 400:
    title = "Senior Manager";
    break;
  default:
    title = "Associate";
    break;
}

Console.WriteLine($"{employeeName} is a {title}.");
```
Output: Andrew Carroll is a Senior Manager.

In our example:

the switch expression is (employeeLevel)
each switch section has a single switch label (case or default).
the matching switch section is defined by case: 400, since employeeLevel = 400.

Note:
if the employeeLevel is assigned 401 or 307 the output will default to Associate because there is no case for those values.

**Switch-case construct challenge**
```csharp
// SKU = Stock Keeping Unit.
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

// creates product array ["01", "MN", "L"]
string[] product = sku.Split('-');
string type = "";
string color = "";
string size = "";

Console.WriteLine($"Initial Values: {product[0]}, {product[1]}, {product[2]}");

switch (product[0])
{
  case "01":
    type = "Sweat shirt";
    break;
  case "02":
    type = "T-Shirt";
    break;
  case "03":
    type = "Sweat pants";
    break;
  default:
    type = "Other";
    break;
}

switch (product[1])
{
  case "BL":
    color = "Black";
    break;
  case "MN":
    color = "Maroon";
    break;
  case "WH":
    color = "White";
    break;
  default:
    color = "Other";
    break;
}

switch (product[2])
{
  case "S":
    size = "Small";
    break;
  case "M":
    size = "Medium";
    break;
  case "L":
    size = "Large";
    break;
  default: 
    size = "One size fits all";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");
```

**For Statements: Iterate through a code block using for statement in C#**

Learning objectives
In this module, you will:

Use a for statement to loop through a block of code.
Examine the for statement syntax that enables you to control the iteration pattern.

What is the for statement?
The for statement iterates through a code block a specific number of times. This level of control makes the for statement unique among the other iteration statements. The foreach statement iterates through a block of code once for each item in a sequence of data like an array or collection. The while statement iterates through a block of code until a condition is met.

Furthermore, the for statement gives you much more control over the process of iteration by exposing the conditions for iteration.

**A basic FOR statement**
```csharp
for (int i = 0; i < 10; i++)
{
  Console.WriteLine(i);
}
```
Output: 1 2 3 4 5 6 7 8 9 (given vertically in the terminal)

The for statement includes the following six parts:

- The for keyword.
- A set of parentheses that defines the conditions of for iteration. The parentheses contain three distinct parts, separated by the end of statement operator, a semi-colon.
- The first part defines and initializes the iterator variable. In this example: int i = 0. This section is referred to as the initializer.
- The second part defines the completion condition. In this example: i < 10. In other words, the runtime will continue to iterate over the code in the code block below the for statement while i is less than 10. When i becomes equal to 10, the runtime stops executing the for statement's code block. The docs refer to this section as the condition.
- The third part defines the action to take after each iteration. In this case, after each iteration, i++ will increment the value of i by 1. The docs refer to this section as the iterator.
- Finally, the code block. The code block contains the code that will be executed for each iteration. Notice that the value of i is referenced inside of the code block. The docs refer to this section as the body.

Change the iteration conditions
As we stated at the outset, the for statement has two unique qualities among iteration statements.

The for statement should be used when you know the number of times you need to iterate through a block of code ahead of time.
The for statement allows you to control the way in which each iteration is handled.
What if we needed to iterate through a block of code, but want to count down instead of counting up?

Use the Visual Studio Code Editor to update your code as follows:
```csharp
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
```
Output: 10 9 8 7 6 5 4 3 2 1 0 (given vertically in the terminal)

By changing the three parts of the for statement, we change its behavior.

We initialize the iteration variable to 10.
We change the completion condition to exit the for statement when i is less than 0.
We change the pattern of the iterator to subtract 1 from i each time we complete an iteration.

*experiment with the iterator's pattern*
```csharp
for (int i = 0; i < 10; i += 3)
{
  Console.WriteLine(i);
}
```
Output: 0 3 6 9 (given vertically in the terminal)

In this example, we initialize the iteration variable to 0. We change the completion condition to exit the for statement when i is less than 10. We change the pattern of the iterator to add 3 to i each time we complete an iteration.

**Use break to break the iteration**
```csharp
for (int i = 0; i < 10; i++)
{
  Console.WriteLine(i);
  if (i == 7) break;
}
```
Output: 0 1 2 3 4 5 6 7 (given vertically in the terminal)

Take a minute to review the use of the break keyword in your updated code.

We first saw the break keyword in the module "Branch the flow of code using the switch-case construct in C#". As it turns out, we can use the break keyword to exit out of iteration statements as well.

**Loop through each element of an array**
```csharp
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
  Console.WriteLine(names[i]);
}
```
Output: Michael David Eddie Alex (given vertically in the terminal)

First off, notice that we have instantiated a string array named names that contains four names.

Next, notice that we are using the Array.Length property to get the number of elements in the array, and that we are using this value to initialize our iterator variable (int i = names.Length - 1). We subtract 1 from the value because the index number for array elements is zero-based (the index numbers of the four elements are 0-3).

Finally, notice we have chosen iterate through the array backwards--something that we are unable to do with the foreach statement. We use the value of the iteration variable inside the code block to specify the index number of the array elements (names[i]).

```csharp
// this for loop will print the names in forward order
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
{
  Console.WriteLine(names[i]);
}
```
Output: Alex Eddie David Michael (given vertically in the terminal)

**Examine the limitation of the foreach statement**
```csharp
string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}
```
Output: Cannot assign to name because it is a 'foreach iteration variable'

In other words, you can't reassign the value of name because it is part of the foreach iteration's inner implementation.

**Overcoming the limitation of the foreach statement using the for statement**
```csharp
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);
```
Output: Alex Eddie Sammy Michael (given vertically in the terminal)

```csharp
// This is the "same" code but formatted differently.  It depends on your readability preference.
string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}
```

Here are a few of the takeaways from this unit:

The for iteration statement allows you to iterate through a block of code a specific number of times.
The for iteration statement allows you to control every aspect of the iteration's mechanics by altering the three conditions inside the parentheses: the initializer, condition, and iterator.
It's common to use the for statement when you need to control how you want to iterate through each item in an array.
If your code block has only one line of code, you can eliminate the curly braces and white space if you wish.

**FIZZBUZZ Challenge**
FizzBuzz challenge
FizzBuzz is a popular coding challenge and interview question. It exercises your understanding of the for statement, the if statement, the % remainder operator, and your command of basic logic.

Code challenge - implement the FizzBuzz challenge rules
Here are the FizzBuzz rules that you need to implement in your code project:

Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
When the current value is divisible by 3, print the term Fizz next to the number.
When the current value is divisible by 5, print the term Buzz next to the number.
When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.

```csharp
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
```

**Add looping logic to your code using the do-while and while statements in C#**

Learning objectives
After you complete this module, you'll be able to:

Write code that uses the do-while statement to iterate through a code block

Write code that uses the while statement to iterate through a code block

Use the continue statement to step directly to the Boolean evaluation

The do-while and while statements allow us to control the flow of code execution by looping through a block of code until a condition is met. When working with the foreach statement, we iterate once for each item in sequence, such as an array. The for statement allows us to iterate a pre-determined number of times, and control the process of iteration. The do-while and while statements allow us to iterate through a block of code with the intent that the logic inside of the code block will affect when we can stop iterating.

Suppose you want to accept and process user input. You want to continue accepting and processing input until the user presses the q key for "quit". You can use the do-while and the while statements to keep iterating through the logic to accept user input and process it until the user is ready to stop.

In this module, you'll use the do-while statement and the while statement to iterate through code block. You'll understand when to choose one over the other. You'll use the continue statement to skip processing the remainder of code in the code block and go directly to the Boolean evaluation of the while statement.

By the end of this module, you will be able to confidently use the do-while and while statements to add looping logic to your application.

Learning objectives
In this module, you will:

Write code that uses the do-while statement to iterate through a code block.
Write code that uses the while statement to iterate through a code block.
Use the continue statement to step directly to the Boolean evaluation.

What is the do-while statement?
The do-while statement executes a statement or a block of statements while a specified Boolean expression evaluates to true. Because that expression is evaluated after each execution of the loop, a do-while loop executes one or more times.

```csharp
do
{
    // This code executes at least one time
} while (true);
```
The flow of execution starts inside of the curly brace. The code executes at least one time, then the Boolean expression next to the while keyword is evaluated. If the Boolean expression returns true, the code block is executed again.

By hard coding the Boolean expression to true, we've created an infinite loop--a loop that will never end, at least, not as it's currently written. We would need a way to break out of the loop inside of the code block. We'll discuss the exit criteria of a do-while in a bit.

**Write a do-while statement to break when a certain random number is generated**
Let's write code that will keep generating random numbers between 1 and 10 until we generate the number 7. It could take just one iteration to get a 7, or it could take dozens of iterations.

```csharp
Random random = new();
int current = 0;

do
{
  current = random.Next(1, 11);
  Console.WriteLine(current);
} while (current != 7);
```
Output: this will generate random integers until 7 is generated.

Take a minute to review your code.

A key learning for this first task is that the code block of a do-while loop will execute at least once. It could iterate a large number of times, and it is unlikely that we know ahead of time how many iterations there will be.

It's also important to notice that the code inside of the code block is influencing whether to continue iterating through the code block or not. A code block that influences the exit criteria is a primary reason to select a do-while or while statements rather than one of the other iteration statements. Both the foreach and for rely on factors that are external to the code block to determine the number of code block iterations.

**Write a while statement that iterates only while a random number is greater than some value**

```csharp
Random random = new();
int current = random.Next(1, 11);

while (current >= 3)
{
  Console.WriteLine(current);
  current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
```

Take a minute to review your code.

At the top code, we use random to initialize our int variable named current. Our next active code line is our while statement.

Our while statement will iterate based on the Boolean expression (current >= 3). We don't know what value will be assigned to current, but there are possibilities that affect our while loop:

If current is initialized to a value greater than or equal to 3, then the Boolean expression will return true, and the flow of execution will enter the code block. Inside the code block, the first thing that we do is write the value of current to the console. Next, still inside the code block, we update the value of current with a new random value. At this point, control goes back to the top of the while statement where the Boolean expression is evaluated. This process continues until the Boolean expression returns false and the flow of execution breaks from the code block.
If current is initialized (at the top of our code) to a value less than 3, then the Boolean expression will return false, and the code block will never execute.
The final code line writes the value of current to the console. This code runs whether the iteration code block was executed or not, and is our chance to write the final value of current to the console.

**Use the continue statement to step directly to the Boolean expression**

```csharp
Random random = new();
int current = random.Next(1, 11);

do
{
  current = random.Next(1, 11);

  if (current >=8) continue;

  Console.WriteLine(current);
} while (current != 7);
```

Take a minute to review your code.

Notice that we've switched back to a do-while. A do-while ensures that the loop will iterate at least once.

The first thing that we do inside the code block is to assign a new random value to current. Next, we check to see if current is greater than or equal to 8. If this expression returns true, the continue key word will transfer control to the end of the code block and the while will evaluate (current != 7). So, the loop will continue to iterate as long as the value of current is not equal to 7.

The key to this step of the exercise is the line of code containing the continue key word:
```csharp
if (current >= 8) continue;
```

Since our code that writes the value of current to the console is located after the if (current >= 8) continue;, our code ensures that a value of current that is greater than or equal to 8 will never be written to the output window.

Consider the difference between the continue and break statements.

As you saw in this last step, the continue statement transfers execution to the end of the current iteration. This behavior is different than the behavior we saw with the break statement. The break statement terminates the iteration (or switch) and transfers control to the statement that follows the terminated statement. If there is no statement after the terminated statement, then control transfers to the end of the file or method.

**Recap**
There's a few important ideas you should take away from this unit:

- The do-while statement iterates through a code block at least once, and might continue to iterate based on a Boolean expression. The evaluation of the Boolean expression usually depends on some value generated or retrieved inside of the code block.
- The while statement evaluates a Boolean expression first, and continues to iterate through the code block as long as the Boolean expression evaluates to true.
- The continue keyword to step immediately to the Boolean expression.

**Trivia**
A do-while statement executes a code block zero or more times.

**Role playing game battle challenge**
In some role playing games, the player's character battles non-player characters, which are usually monsters or the "bad guys". Sometimes, a battle consists of each character generating a random value using dice and that value is subtracted from the opponent's health score. Once either character's health reaches zero, they lose the game.

In this challenge, we boil down that interaction to its essence. A hero and a monster start with the same health score. During the hero's turn, they generate a random value that is subtracted from the monster's health. If the monster's health is greater than zero, they take their turn and attack the hero. As long as both the hero and the monster have health greater than zero, the battle resumes.

Code challenge - write code to implement the game rules
Here are the rules for the battle game that you need to implement in your code project:

- You must use either the do-while statement or the while statement as an outer game loop.
- The hero and the monster start with 10 health points.
- All attacks are a value between 1 and 10.
- The hero attacks first.
- Print the amount of health the monster lost and their remaining health.
- If the monster's health is greater than 0, it can attack the hero.
- Print the amount of health the hero lost and their remaining health.
- Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
- Print the winner.

```csharp
// Hero RPG
int Andrew = 100;
int monster = 50;

Random dice = new();

do
{
  int roll = dice.Next(1, 11);
  monster -=roll;
  Console.WriteLine($"Andrew hits the monster for {roll} points. The monster has {monster} health left.");

  if (monster <=0) continue;

  roll = dice.Next(1, 11);
  Andrew -= roll;
  Console.WriteLine($"The monster hits Andrew for {roll} points. Andrew has {Andrew} health left.");      
} while (Andrew > 0 && monster > 0);

Console.WriteLine(Andrew > 0 ? "Andrew wins!" : "The monster wins!");
```

**Exercise - Complete a challenge activity to differentiate between do and while iteration statements**

**Examine the difference between do and while statement iterations**

As you have seen, C# supports four types of iteration statements: for, foreach, do-while, and while. Microsoft's language reference documentation describes these statements as follows:

- The for statement: executes its body while a specified Boolean expression (the 'condition') evaluates to true.
- The foreach statement: enumerates the elements of a collection and executes its body for each element of the collection.
- The do-while statement: conditionally executes its body one or more times.
- The while statement: conditionally executes its body zero or more times.

The for and foreach iterations seem to be clearly differentiated from each other and from the do-while and while iterations. The definitions for the do-while and while statements, however, appear to be quite similar. Knowing when to choose between a do-while and a while seems more arbitrary, and can even be a bit confusing. Some challenge projects may help to make the differences clear.

In this challenge, you'll be presented with conditions for three separate coding projects. Each project will require you to implement an iteration code block using either a do-while or a while statement. You'll need to evaluate the specified conditions in order to choose between the do-while and while statements. You can switch after you start if your first choice isn't working out as well as you had hoped.

**NOTE**
The conditions for your coding project can be used to help you select between the do-while and while statements. What you know, or don't know, about the Boolean expression that will be evaluated can sometimes help you to select between the do-while and while statements. In this challenge exercise, the project conditions include information that will be used to construct the Boolean expression.

**Manage user input during this challenge**
When using a Console.ReadLine() statement to obtain user input, it's common practice to use a nullable type string (designated string?) for the input variable and then evaluate the value entered by the user. The following code sample uses a nullable type string to capture user input. The iteration continues while the user-supplied value is null:

```csharp
string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);  // (readResult == null) is the Boolean expression
```
What’s Happening?

1. do-while Loop:
- The do block runs at least once, prompting the user for input using Console.ReadLine().
- After executing the do block, the while condition (readResult == null) is checked.

2. Boolean Statement:
- readResult == null is a Boolean expression that evaluates to:
  - true if readResult is null (no input or the user pressed Enter without typing anything).
  - false if readResult contains a value (any user input).
- The loop continues as long as the condition evaluates to true.

3. Purpose:
- This ensures the program keeps asking for input until the user provides a valid (non-null) string.

**Key Points**
- Boolean Expression: readResult == null
- Meaning: "Keep looping while readResult is null."
- This technique is common for validating user input and ensuring that the program doesn't proceed with invalid or missing data.

The Boolean expression evaluated by the while statement can be used to ensure user input meets a specified requirement. For example, if a prompt asks the user to enter a string that includes at least three characters, the following code could be used:

```csharp
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);
```

If you want to use Console.ReadLine() input for numeric values, you need to convert the string value to a numeric type.

The int.TryParse() method can be used to convert a string value to an integer. The method uses two parameters, a string that will be evaluated and the name of an integer variable that will be assigned a value. The method returns a Boolean value. The following code sample demonstrates using the int.TryParse() method:

```csharp
// capture user input in a string variable named readResult
int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);
```

If the string value assigned to readResult represents a valid integer, the value will be assigned to the integer variable named numericValue, and true will be assigned to the Boolean variable named validNumber. If the value assigned to readResult doesn't represent a valid integer, validNumber will be assigned a value of false. For example, if readResult is equal to "7", the value 7 will be assigned to numericValue.

**Code project 1 - write code that validates integer input**
Here are the conditions that your first coding project must implement:
- Your solution must include either a do-while or while iteration.
- Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

-Inside the iteration block:
  - Your solution must use a Console.ReadLine() statement to obtain input from the user.
  - Your solution must ensure that the input is a valid representation of an integer.
  - If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
  - Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.

-Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

**High-Level Code Outline**
Here’s what the structure of the final code might look like, without implementation details:

```csharp
// 1. Initialization
string? userInput; // To store raw input
int validatedInput; // To store parsed integer

// 2. Prompt user
Console.WriteLine("Enter an integer between 5 and 10:");

// 3. Iteration block
do
{
    // Obtain input from user (Console.ReadLine)
    
    // Validate input (int.TryParse)
    // If invalid: Display error message and continue
    
    // Check range (5 to 10)
    // If out of range: Display error message and continue

} while (/* Loop condition to ensure valid input */);

// 4. Acknowledge valid input
Console.WriteLine($"Your input ({validatedInput}) has been accepted.");
```

**The Integer Validation Code for Project 1**
```csharp
// Code Project 1 - Validate Integer Input
    // Prompt the user for input
    Console.WriteLine("Enter a number between 5 & 10:");  

    // Step 2: initialize variables
    string? userInput;
    int validatedInput;

    // Step 3: Loop until the user enters a valid number (Iteration block)
    do
    {
      // 3a: Get user input
      userInput = Console.ReadLine();

      // 3b: Validate input
      if (!int.TryParse(userInput, out validatedInput))
      {
        Console.WriteLine("Sorry, that's not a valid number. Please try again.");
        continue; // Skip the rest of the loop
      }

      // 3c: Check if the number is between 5 & 10
      if (validatedInput < 5 || validatedInput > 10)
      {
        Console.WriteLine($"Sorry, {validatedInput} is not between 5 & 10. Please try again.");  // Skip to the next iteration
      }
    } while (validatedInput < 5 || validatedInput > 10);

    // Step 4: Acknowledge valid input
    Console.WriteLine($"Your input, {validatedInput}, is valid. Thank you!");
```
Output:
Starting doWhile:
Enter a number between 5 & 10:
4
Sorry, 4 is not between 5 & 10. Please try again.
2
Sorry, 2 is not between 5 & 10. Please try again.
11
Sorry, 11 is not between 5 & 10. Please try again.
6
Your input, 6, is valid. Thank you!
...Ending doWhile...

**Key Concepts We Used**
- Console.ReadLine(): To capture user input.
- int.TryParse(): To check if the input is a valid integer.
- do-while Loop: Ensures the code runs at least once and keeps looping until the conditions are met.
- Error Messages: Provide clear feedback for invalid or out-of-range input.

**Code project 2 - write code that validates string input**
Here are the conditions that your second coding project must implement:
- Your solution must include either a do-while or while iteration.
- Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.
- Inside the iteration block:
  - Your solution must use a Console.ReadLine() statement to obtain input from the user.
  - Your solution must ensure that the value entered matches one of the three role options.
  - Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
  - Your solution should use the ToLower() method on the input value to ignore case.
  - If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
- Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

Example Output:
Enter your role name (Administrator, Manager, or User)
Admin
The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
   Administrator
Your input value (Administrator) has been accepted.

1. Problem Analysis
The goal is to:
- Prompt the user for a role name: Administrator, Manager, or User.
- Validate the input to ensure it:
  - Matches one of the three role names.
  - Ignores leading/trailing spaces (use Trim()).
  - Ignores case sensitivity (use ToLower()).
- Repeat the prompt until the input is valid.
- Inform the user when valid input is accepted.

2. Key Requirements
- Iteration: Use a do-while or while loop to keep asking for input until a valid role is provided.
- Input Handling:
  - Use Console.ReadLine() to capture the user input.
  - Apply Trim() to remove extra spaces.
  - Apply ToLower() to simplify case-insensitive comparison.
- Validation:
  - Check if the trimmed, lowercase input matches any of the valid roles ("administrator", "manager", "user").
- Feedback:
  - Display a message if the input is invalid.
  - Display a success message when valid input is provided.

3. Logical Steps
Here’s how we can break it down:

- Initialization:
  - Declare a variable (userRole) to hold the raw user input.
  - Declare a Boolean (isValid) or directly use a do-while loop condition to control iteration.

- Prompt Before the Loop:
  - Use Console.WriteLine() to instruct the user to enter one of the valid roles.

- Inside the Loop:
  - Capture input using Console.ReadLine().
  - Use Trim() to clean up the input.
  - Use ToLower() to make validation case-insensitive.
  - Check if the cleaned input matches one of the valid role names.
  - If invalid, display an error message and prompt the user again.

- After the Loop:
  - Once valid input is provided, display a success message.

4. High-Level Code Outline
```csharp
// 1. Initialization
string? userRole; // Nullable string to store user input
bool isValid;     // Flag for controlling the loop

// 2. Prompt user
Console.WriteLine("Enter your role name (Administrator, Manager, or User):");

// 3. Iteration block
do
{
    // Get input from user (Console.ReadLine)

    // Clean the input (Trim and ToLower)

    // Check if input matches any valid role
    // If invalid: Display an error message

} while (!isValid); // Loop until the input is valid

// 4. Success message
Console.WriteLine($"Your input value ({userRole}) has been accepted.");
```
5. Consider Edge Cases
- Input with extra spaces: " Administrator ".
- Case-insensitive matches: "adminiSTrator".
- Completely invalid input: "guest" or empty string.

6. Final Code Solution
```csharp
// Code Project 2 - Validate String input
// Step 1: Initialize variables
string? userRole;
bool isValid = false; // To track if input is valid

// Step 2: Prompt user
Console.WriteLine("Enter your role (Admin, Manager, or User):");

// Step 3: Iteration block
do
{
  // 3a: Get user input
  userRole = Console.ReadLine();

  // 3b: Clean input
  userRole = userRole?.Trim().ToLower(); // Handle null, trim whitespace, and convert to lowercase for case-insensitive comparison

  // 3c: Validate input
  if (userRole == "admin" || userRole == "manager" || userRole == "user")
  {
    isValid = true; // valid input
  }
  else
  {
    Console.WriteLine($"The role name you entered, \"{userRole}\", is not valid.  Enter your role (Admin, Manager, or User):");
  }
} while (!isValid); // Repeat until input is valid

// Step 4: Acknowledge valid input
Console.WriteLine($"Your role, {userRole}, has been verified and accepted.  Thank you!");
```
Output:
Starting doWhile:
Enter your role (Admin, Manager, or User):
turd
The role name you entered, "turd", is not valid.  Enter your role (Admin, Manager, or User):
Manager
Your role, manager, has been verified and accepted.  Thank you!
...Ending doWhile...

**Key Concepts We Used**
- Console.ReadLine(): To capture user input.
- Trim(): To remove unnecessary spaces around the input.
- ToLower(): To make comparisons case-insensitive.
- Logical OR (||): To check if the input matches any of the valid role names.
- do-while Loop: To ensure the user is prompted at least once and keeps being prompted until the input is valid.

**Code project 3 - Write code that processes the contents of a string array**
Here are the conditions that your third coding project must implement:
- your solution must use the following string array to represent the input to your coding logic:
```csharp
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
```

- Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.
- Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named myString.
- In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.
- Your solution must include an inner do-while or while loop that can be used to process the myString variable.
- In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.
- In the inner loop, your solution must not display the period character.
- In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.

Example Output:
I like pizza
I like roast chicken
I like salad
I like all three of the menu choices

1. Problem Analysis
The program needs to:
- Process an array of strings (myStrings), where each string may contain multiple sentences separated by periods (.).
- Extract each sentence from the string.
- Remove the period (.) from the sentences.
- Display each sentence individually on a new line.

2. Key Requirements
Outer Loop:
- Use a foreach or for loop to iterate over each string in the array.
- Use IndexOf(".") to find the position of the first period in the current string (myString).

Inner Loop:
- Use a do-while or while loop to extract sentences:
  - Use Substring() to extract the sentence up to the period.
  - Use TrimStart() to remove any leading whitespace from the sentence.
  - Use Remove() to modify the string and remove the processed sentence from it.
- End Condition for Inner Loop:
  -Stop when there are no more periods in the string (IndexOf(".") returns -1).
- Output:
  - Write each extracted sentence to the console, excluding the period.

3. Logical Steps
Here’s how we’ll structure the logic:
- Initialize the Array:
  - Use the provided myStrings array.

- Outer Loop:
  - Iterate over each string in myStrings using a foreach or for loop.
  - Declare periodLocation to store the position of the first period.

- Inner Loop:
  - Inside the inner loop:
    - Use IndexOf(".") to find the first period.
    - Extract the sentence up to the period using Substring(0, periodLocation).
    - Use TrimStart() to clean up leading spaces in the sentence.
    - Display the sentence without the period.
    - Use Remove() to modify the string, removing the extracted sentence and the period.
  - Repeat until no more periods are found.

Output:
- Once all sentences are processed, move to the next string in the array.

4. High-Level Code Outline
```csharp
// 1. Initialize the array
string[] myStrings = new string[2] 
{ 
    "I like pizza. I like roast chicken. I like salad", 
    "I like all three of the menu choices" 
};

// 2. Outer loop
foreach (string myString in myStrings)
{
    // Declare a variable to hold the current string
    string currentString = myString;

    // Find the first period location
    int periodLocation;

    // 3. Inner loop
    do
    {
        // Find the period
        periodLocation = currentString.IndexOf(".");

        if (periodLocation != -1)
        {
            // Extract sentence, remove period, and trim
            string sentence = currentString.Substring(0, periodLocation).TrimStart();

            // Display the sentence
            Console.WriteLine(sentence);

            // Remove the processed sentence from the string
            currentString = currentString.Remove(0, periodLocation + 1);
        }

    } while (periodLocation != -1); // Continue until no more periods
}
```

5. Final Code Solution
```csharp
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
```
Output:
Starting doWhile:
I like pizza
I like burritos
I like steak
I like all three of the menu choices
...Ending doWhile...

**Key Concepts We Used**
- IndexOf(): To locate the period in the string.
- Substring(): To extract the sentence up to the period.
- TrimStart(): To clean up any leading spaces in the extracted sentence.
- Remove(): To remove the processed sentence and the period from the string.
- Nested Loops: An outer foreach loop for each string and an inner do-while loop for processing sentences within each string.

**Trivia**
A developer needs to iterate through an array of items. The number of items in the array is unknown. The code inside the iteration code block examines each item sequentially to select an item that matches specified criteria. The index number of the selected array element isn't important. The selected item is referenced multiple times within the code block. Which type of iteration statement is best suited for this scenario?
- foreach
  - The foreach statement is ideal for iterating through an array when the index number isn't needed and the order of the items isn't important. It simplifies the code and provides a cleaner way to access each item in the array.

A developer needs to capture a list of items from the user. The user will enter the keyboard combination ctrl + Esc to exit. Which is the best iteration statement for this purpose? 
- do-while
  - The do-while statement is ideal for scenarios where the code block must execute at least once and the loop continues based on a condition. In this case, the loop should continue until the user enters the exit command.