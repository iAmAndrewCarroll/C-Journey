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

