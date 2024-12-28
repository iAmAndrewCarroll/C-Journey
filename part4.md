**Work With Variable Data in C# Console Applications**

**Learning objectives**

In this module, you will:

- Learn the fundamental differences between value types and reference types.
- Describe the properties of many new numeric data types, including new integral types and floating point types.
Write code that returns the maximum and minimum values that numeric data types can store.
- Use the new keyword to create new instances of a reference type.
- Determine which data type you should choose for a given application.

# Working with MinValue and MaxValue Properties for Integral Types

## **Signed Integral Types**
To see the value ranges for signed integral types, follow these steps:

1. Open **Visual Studio Code** and ensure `Program.cs` is displayed in the Editor panel.  
   - If `Program.cs` contains code, delete all lines to start fresh.

2. Type the following code into the Editor:
   <!-- 
   Console.WriteLine("Signed integral types:");

   Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
   Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
   Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
   Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
   -->

3. Save the file by selecting **File > Save** in Visual Studio Code.

4. Open the Terminal:
   - Right-click the `TestProject` folder in the **EXPLORER** panel and select **Open in Integrated Terminal**.

5. Run your code:
   <!-- 
   dotnet run
   -->

6. If you see the error "Couldn't find a project to run," ensure the Terminal is in the correct folder (e.g., `TestProject`).

### **Expected Output**
<!-- 
Signed integral types:
sbyte  : -128 to 127
short  : -32768 to 32767
int    : -2147483648 to 2147483647
long   : -9223372036854775808 to 9223372036854775807
-->

For most non-scientific applications, the `int` type is sufficient since it handles values from -2.14 billion to +2.14 billion.

---

## **Unsigned Integral Types**
Unsigned types represent only positive numbers. To work with unsigned types:

1. Add the following code below the previous section:
   <!--
   Console.WriteLine("");
   Console.WriteLine("Unsigned integral types:");

   Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
   Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
   Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
   Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
   -->

2. Save your changes and run the program again.

### **Expected Output**
<!-- 
Signed integral types:
sbyte  : -128 to 127
short  : -32768 to 32767
int    : -2147483648 to 2147483647
long   : -9223372036854775808 to 9223372036854775807

Unsigned integral types:
byte   : 0 to 255
ushort : 0 to 65535
uint   : 0 to 4294967295
ulong  : 0 to 18446744073709551615
-->

---

## **Key Notes**
1. **Signed Types**:
   - Use 1 bit to represent the sign (positive or negative).
   - Examples: `sbyte`, `short`, `int`, `long`.

2. **Unsigned Types**:
   - Use all bits to represent positive values only.
   - Examples: `byte`, `ushort`, `uint`, `ulong`.

3. **Practical Use Cases**:
   - The `byte` type (0 to 255) is ideal for representing binary data, such as data stored in files or transferred across networks.

4. **Evaluating Data Type Ranges**:
   - Use the `MaxValue` and `MinValue` properties of numeric types to ensure that a value fits within the range of a specific type.

---

## **Recap**
- An **integral type** holds whole numbers.
- **Signed types** allow positive and negative values, while **unsigned types** only allow positive values.
- The `MaxValue` and `MinValue` properties help evaluate a number's compatibility with a given data type.

# Discover Floating-Point Types

## **Overview**
In this exercise, you will work with floating-point data types to understand their precision, storage methods, and accuracy. Floating-point numbers represent values to the right of the decimal place and are useful for scenarios requiring fractional values.

---

## **Evaluate Floating-Point Types**
### **Key Considerations**
1. **Precision**: The number of value places stored after the decimal point.
2. **Storage**:  
   - `float` and `double` store values in a binary (base 2) format.
   - `decimal` stores values in a decimal (base 10) format.

### **Why This Matters**
- **Binary Floating-Point (`float`, `double`)**:  
  Useful for approximations with smaller memory footprints, e.g., in video games or simulations where slight inaccuracies are acceptable.
- **Decimal (`decimal`)**:  
  Useful for precise calculations, such as financial data, where accuracy is critical.

---

## **Use the MinValue and MaxValue Properties for Each Floating-Point Type**
1. Delete or comment out code from previous exercises.

2. Add the following code to display the value ranges for floating-point types:
   <!--
   Console.WriteLine("");
   Console.WriteLine("Floating point types:");
   Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
   Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
   Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
   -->

3. Save your changes.

4. Open a Terminal in Visual Studio Code:
   - Right-click the `TestProject` folder and select **Open in Integrated Terminal**.

5. Run your code:
   <!--
   dotnet run
   -->

6. If you see the error "Couldn't find a project to run," ensure the Terminal is in the correct folder (e.g., `TestProject`).

---

### **Expected Output**
<!--
Floating point types:
float  : -3.402823E+38 to 3.402823E+38 (with ~6-9 digits of precision)
double : -1.79769313486232E+308 to 1.79769313486232E+308 (with ~15-17 digits of precision)
decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)
-->

---

## **Deciphering Large Floating-Point Values**
Floating-point values can be represented using "E notation" (scientific notation).  
For example:
- `5E+2` = `5 * 10^2` = `500`.

---

## **Recap**
- A floating-point type can hold fractional numbers.
- Choosing the correct floating-point type involves considering:
  1. Precision (digits after the decimal).
  2. Storage format (binary or decimal).
  3. Accuracy requirements for mathematical operations.
- Large floating-point numbers often use "E notation" for compact representation.

# Discover Floating-Point Types

## **Overview**
In this exercise, you will work with floating-point data types to understand their precision, storage methods, and accuracy. Floating-point numbers represent values to the right of the decimal place and are useful for scenarios requiring fractional values.

---

## **Evaluate Floating-Point Types**
### **Key Considerations**
1. **Precision**: The number of value places stored after the decimal point.
2. **Storage**:  
   - `float` and `double` store values in a binary (base 2) format.
   - `decimal` stores values in a decimal (base 10) format.

### **Why This Matters**
- **Binary Floating-Point (`float`, `double`)**:  
  Useful for approximations with smaller memory footprints, e.g., in video games or simulations where slight inaccuracies are acceptable.
- **Decimal (`decimal`)**:  
  Useful for precise calculations, such as financial data, where accuracy is critical.

---

## **Use the MinValue and MaxValue Properties for Each Floating-Point Type**
1. Delete or comment out code from previous exercises.

2. Add the following code to display the value ranges for floating-point types:
   <!--
   Console.WriteLine("");
   Console.WriteLine("Floating point types:");
   Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
   Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
   Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
   -->

3. Save your changes.

4. Open a Terminal in Visual Studio Code:
   - Right-click the `TestProject` folder and select **Open in Integrated Terminal**.

5. Run your code:
   <!--
   dotnet run
   -->

6. If you see the error "Couldn't find a project to run," ensure the Terminal is in the correct folder (e.g., `TestProject`).

---

### **Expected Output**
<!--
Floating point types:
float  : -3.402823E+38 to 3.402823E+38 (with ~6-9 digits of precision)
double : -1.79769313486232E+308 to 1.79769313486232E+308 (with ~15-17 digits of precision)
decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)
-->

---

## **Deciphering Large Floating-Point Values**
Floating-point values can be represented using "E notation" (scientific notation).  
For example:
- `5E+2` = `5 * 10^2` = `500`.

---

## **Recap**
- A floating-point type can hold fractional numbers.
- Choosing the correct floating-point type involves considering:
  1. Precision (digits after the decimal).
  2. Storage format (binary or decimal).
  3. Accuracy requirements for mathematical operations.
- Large floating-point numbers often use "E notation" for compact representation.

**Trivia**
in C#, when the `new` keyword is used to create an instance of a `class`, where is the memory allocated?
- Heap
  - the Heap is a region of memory that is managed by the CLR (Common Language Runtime) and is used to store objects created at runtime.

# Choose the Right Data Type

## **Overview**
Selecting the correct data type is crucial for building efficient and reliable applications. The choice of data type affects how your application handles, stores, and processes data. This guide discusses criteria for choosing the right data type and highlights best practices.

---

## **Key Considerations for Choosing a Data Type**

### 1. **Boundary Value Range Requirements**
- Choose a data type that fits the range of values your application expects.
  - For example:
    - If a variable should only store numbers between 1 and 10,000:
      - Avoid `byte` and `sbyte` (too small).
      - Avoid `int`, `long`, `uint`, and `ulong` (too large).
      - Consider `short` or `ushort`.
      - Use `ushort` if negative values are irrelevant.
- Enforcing data type boundaries helps maintain application sanity and prevents invalid data.

---

### 2. **Fit the Data First, Not Performance**
- Avoid premature optimization:
  - Don't choose a smaller data type thinking it will improve performance.
  - Choose the data type that fits your data logically.
- Use performance-measuring tools to identify bottlenecks after development.

---

### 3. **Input and Output Data Types of Library Functions**
- Consider the input and output data types of libraries and frameworks you work with:
  - Example:
    - For `System.TimeSpan` and `System.DateTime`, many methods use `double` or `int`.
    - If you work with dates, `int` is sufficient if you don't need subsecond precision; use `double` if you do.

---

### 4. **Impact on Other Systems**
- Consider how data interacts with external systems like databases:
  - Example:
    - SQL Server's type system differs from C#'s.
    - Mismatched data types can lead to conversion overhead or storage inefficiencies.
  - Larger data types may increase storage costs.

---

### 5. **When in Doubt, Stick with Basic Types**
- For simplicity, use the following basic types:
  - `int`: For most whole numbers.
  - `decimal`: For monetary values.
  - `bool`: For `true` or `false` values.
  - `string`: For alphanumeric values.

---

## **Specialty Complex Types**
Use existing .NET types for specific scenarios rather than reinventing data types:
- `byte`: For encoded data or character sets.
- `double`: For geometric or scientific purposes, often used in games involving motion.
- `System.DateTime`: For specific date and time values.
- `System.TimeSpan`: For durations (years, months, days, hours, etc.).

---

## **Recap**
- Consider the expected value range, library requirements, and impact on external systems when selecting a data type.
- Stick to basic types like `int`, `decimal`, `bool`, and `string` for most cases unless a specific situation requires a more complex type.
- Always prioritize the logical fit for your data over premature performance optimization.

**Convert Data Types Using Casting and Conversion Techniques in C#**
Suppose you're a software developer on a team working on medical intake form automation. You're tasked with delivery of the application features for collecting data entered by a medical technician before the doctor sees the patient. The technician can use the application to record the date and time, patient age, height, weight, pulse, and blood pressure. The application also provides text fields for other information, such as the reason for the visit, current prescriptions, and other items. You work with many data that is in a mix of data types. For the prototype, you'll build a console application and collect all of the input as strings.

Because the input is initially input as a string, you need to occasionally change values from one data type into another in the code. A simple example is any mathematical operation you want to perform with string data. You would first need to change the value into a numeric data type, like int, and then you could manipulate the operation. Alternatively, you may want to format and output a numeric value for a summary report using string interpolation.

You use different techniques to change a data type when necessary. You learn when to use one technique over another, and when a given technique might risk the loss of data.

By the end of this module, you're able to take control of the data in your applications, knowing when to apply the correct technique to change data types as needed.

## Learning objectives
In this module, you'll:

- Use the casting operator to cast a value into a different data type.
- Use conversion methods to convert a value into a different data type.
- Guard against the loss of data when performing a cast or conversion operation.
- Use the TryParse() method to safely convert a string into a numeric data type.

# Explore Data Type Casting and Conversion

## **Overview**
There are multiple techniques to perform a data type conversion. The choice of technique depends on two key questions:
1. Is it possible that attempting to change the value's data type would throw an exception at runtime?
2. Is it possible that attempting to change the value's data type would result in a loss of information?

This exercise explores these questions and demonstrates when to use specific techniques for data type conversion.

---

## **Prepare Your Coding Environment**
1. Open **Visual Studio Code**.
2. Create a new console application:
   <!--
   dotnet new console -o ./CsharpProjects/TestProject
   -->
3. Navigate to the `TestProject` folder and open `Program.cs`.
4. Delete any existing code.

---

## **Question: Is it possible that attempting to change the value's data type would throw an exception at runtime?**

### **Write Code That Causes a Conversion Error**
Add the following code:
<!--
int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);
-->
- Save and run the program.

**Expected Output**:
<!--
C:\Users\someuser\Desktop\csharpprojects\TestProject\Program.cs(3,14): error CS0029: Cannot implicitly convert type 'string' to 'int'
-->
- The error occurs because the compiler cannot safely convert a `string` to an `int`.

### **Update the Code to Concatenate Values**
Update the code to:
<!--
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);
-->
**Expected Output**:
<!--
24
-->
- The `string` value "4" is concatenated with the `int` value 2 as characters.

---

## **Question: Is it possible that attempting to change the value's data type would result in a loss of information?**

### **Perform a Widening Conversion**
Add the following code:
<!--
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
-->
**Expected Output**:
<!--
int: 3
decimal: 3
-->
- A widening conversion (`int` to `decimal`) does not lose data.

---

### **Perform a Narrowing Conversion**
Add the following code:
<!--
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
-->
**Expected Output**:
<!--
decimal: 3.14
int: 3
-->
- Casting truncates precision, demonstrating a narrowing conversion.

---

## **Test Narrowing Conversion Precision**
Add the following code:
<!--
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");
-->
**Expected Output**:
<!--
Decimal: 1.23456789
Float  : 1.2345679
-->
- Converting `decimal` to `float` loses precision, confirming a narrowing conversion.

---

## **Use Conversion Techniques**

### **Convert Numbers to Strings**
Add the following code:
<!--
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);
-->
**Expected Output**:
<!--
57
-->

### **Convert Strings to Numbers with Parse()**
Add the following code:
<!--
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);
-->
**Expected Output**:
<!--
12
-->

### **Convert Strings to Numbers with Convert.ToInt32()**
Add the following code:
<!--
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);
-->
**Expected Output**:
<!--
35
-->

---

## **Compare Casting and Conversion**
Add the following code:
<!--
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);
-->
**Expected Output**:
<!--
1
2
-->
- Casting truncates precision.
- Conversion rounds the value.

---

## **Recap**
- **Runtime Errors**: Prevent exceptions by using explicit conversions for potentially unsafe operations.
- **Widening Conversions**: Implicit conversions are safe and handled by the compiler.
- **Narrowing Conversions**: Use explicit casts for precision loss.
- **Conversion Techniques**:
  - Use `ToString()` to convert to strings.
  - Use `Parse()` or `Convert` for numeric conversions.
  - Use `TryParse()` for safer conversions.

# Complete a Challenge to Combine String Array Values as Strings and as Integers

## **Overview**
This challenge focuses on splitting data based on its type and processing it accordingly:
1. **Alphabetical Values**: Concatenate to form a message.
2. **Numeric Values**: Add to calculate the total.

---

## **Instructions**

### 1. Prepare the Coding Environment
- Open **Visual Studio Code**.
- Delete all existing code or comment it out.

---

### 2. Starter Code
To instantiate a string array, add the following code:
<!--
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
-->

---

### 3. Looping Structure
- Create a loop to iterate through each string in the array.
- Add the required logic within the loop to implement the following rules:
  - **Rule 1**: If the value is alphabetical, concatenate it to a message.
  - **Rule 2**: If the value is numeric, add it to a running total.
  - **Rule 3**: Output the final message and total.

---

### 4. Expected Output
The program should produce:
<!--
Message: ABCDEF
Total: 68.3
-->

---

### 5. Save and Run the Program
1. Save the file in **Visual Studio Code**.
2. Open the Terminal at the folder location using:
   - Right-click the `TestProject` folder and select **Open in Integrated Terminal**.
3. Run the program:
   <!--
   dotnet run
   -->
4. Verify the output matches the expected result.

---

### 6. Troubleshooting
- Ensure the Terminal is in the correct folder (e.g., `TestProject`).
- If culture settings affect decimal separators, add the following at the top of your file:
  <!--
  using System.Globalization;
  CultureInfo.CurrentCulture = new CultureInfo("en-US");
  -->

---

### **Recap**
This challenge demonstrates how to:
1. Iterate through an array of mixed data types.
2. Identify and process numeric and alphabetical data separately.
3. Use string concatenation and numeric summation within a single loop.

# Solution for Combining String Array Values as Strings and as Integers Challenge

## **Solution Code**
The following code provides one possible solution for the challenge:

<!--
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } 
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
-->

---

## **Explanation**
- The solution uses a `foreach` loop to iterate through the `values` array.
- **Numeric values**:
  - Use `decimal.TryParse()` to check if the value can be parsed into a numeric type.
  - Add the numeric value to the running total.
- **Alphabetical values**:
  - If parsing fails, concatenate the value to the `message` string.

---

## **Expected Output**
<!--
Message: ABCDEF
Total: 68.3
-->

---

## **Key Notes**
- **Culture Settings**:
  - The solution assumes en-US culture settings, which use a period (.) as the decimal separator.
  - If your system uses a different decimal separator (e.g., a comma), modify the code to match your culture settings:
    <!--
    using System.Globalization;
    CultureInfo.CurrentCulture = new CultureInfo("en-US");
    -->
- This is one of many possible solutions. The key is ensuring the output matches the expected result.

---

## **Recap**
- Iterate through a mixed-type array and process data based on its type.
- Use `TryParse()` to safely determine if a value is numeric.
- Concatenate non-numeric values and sum numeric values to produce the desired output.

# Complete a Challenge to Output Math Operations as Specific Number Types

## **Overview**
This challenge helps reinforce the concepts of casting and conversion by solving math operations using specific number types. You'll address both narrowing and widening conversions.

---

## **Instructions**

### 1. Prepare Your Coding Environment
- Open **Visual Studio Code**.
- Delete or comment out all previous code.

---

### 2. Starter Code
Add the following "starter" code to your `Program.cs` file:
<!--
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
-->

---

### 3. Solve the Challenge
Replace the placeholder comments with your own code to:
1. **Solve for `result1`**:
   - Divide `value1` by `value2`.
   - Round the result to the nearest integer.
   - Display the result as an `int`.

2. **Solve for `result2`**:
   - Divide `value2` by `value3`.
   - Display the result as a `decimal`.

3. **Solve for `result3`**:
   - Divide `value3` by `value1`.
   - Display the result as a `float`.

---

### 4. Expected Output
When solved correctly, the output should resemble:
<!--
Divide value1 by value2, display the result as an int: 2
Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
Divide value3 by value1, display the result as a float: 0.3909091
-->

---

### 5. Save and Run the Program
1. Save the file in **Visual Studio Code**.
2. Open the Terminal at the folder location using:
   - Right-click the `TestProject` folder and select **Open in Integrated Terminal**.
3. Run the program:
   <!--
   dotnet run
   -->
4. Verify the output matches the expected result.

---

### **Recap**
This challenge demonstrates:
- Casting and conversion to achieve the desired number type.
- Handling narrowing and widening conversions.
- Outputting results with precision for specific number types.

## Perform Operations on Arrays Using Helper Methods in C# 
# Manipulate and Control the Content of Arrays

## **Learning Objectives**
1. **Sort and Reverse**:
   - Learn to sort array elements in ascending order and reverse their order.
   
2. **Clear and Resize**:
   - Understand how to clear elements in an array or resize the array dynamically.

3. **Split a String into an Array**:
   - Split a string into an array of strings or characters (chars) using delimiter-based splitting.

4. **Join Array Elements into a String**:
   - Combine array elements back into a single string using a specified delimiter.

---

# Working with C# Arrays for Logistics Data Processing

## **Scenario**
As a software developer for a logistics company, you work on projects that involve:
- Tracking and reporting inventory.
- Exchanging data with business partners.
- Identifying potential fraudulent orders.

These projects require operations such as:
- Adding, deleting, sorting, and combining data.
- Calculating, validating, and formatting output.

In this module, you will:
- Use C# arrays to store and process sequences of values.
- Modify array data, order, and contents.
- Perform complex string operations using array helper methods.

---

## **Learning Objectives**
By the end of this module, you will be able to:
1. **Sort and Reverse**:
   - Arrange array elements in ascending order or reverse their order.

2. **Clear and Resize**:
   - Remove elements from an array or resize it dynamically to accommodate new data.

3. **Split Strings into Arrays**:
   - Break a string into an array of smaller strings or characters using delimiters.

4. **Join Array Elements into a String**:
   - Combine array elements into a single string with a specified delimiter.

---

## **Key Features**
- **Array Manipulation**:
  - Use powerful helper methods to handle array operations efficiently.
- **String Operations**:
  - Leverage methods to convert between strings and arrays seamlessly.

---

# Exercise - Discover `Sort()` and `Reverse()`

## **Overview**
This exercise demonstrates how to manipulate the order of elements in a C# array using the `Sort()` and `Reverse()` methods from the `Array` class. These operations are useful for organizing and processing data efficiently.

---

## **Instructions**

### 1. Prepare Your Coding Environment
- Open **Visual Studio Code**.
- Create a new console application:
  <!--
  dotnet new console -o ./CsharpProjects/TestProject
  -->
- Open `Program.cs` in the `TestProject` folder.

---

### 2. Create and Sort an Array
Add the following code to create an array of pallets and sort them:
<!--
string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
-->
**Key Method**:
- **`Array.Sort(pallets)`**:
  - Sorts the array elements alphanumerically.

**Expected Output**:
<!--
Sorted...
-- A11
-- A13
-- B12
-- B14
-->

---

### 3. Reverse the Order of the Array
Update the code to include reversing the order of the pallets:
<!--
string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
-->
**Key Method**:
- **`Array.Reverse(pallets)`**:
  - Reverses the order of the array elements.

**Expected Output**:
<!--
Sorted...
-- A11
-- A13
-- B12
-- B14

Reversed...
-- B14
-- B12
-- A13
-- A11
-->

---

## **Recap**
1. The `Array` class provides methods to manipulate array content and order.
2. Use the **`Sort()`** method to arrange elements in ascending order based on their data type.
3. Use the **`Reverse()`** method to flip the order of elements in the array.

# Exercise - Explore `Clear()` and `Resize()`

## **Overview**
This exercise demonstrates how to manage arrays dynamically by using the `Array.Clear()` and `Array.Resize()` methods. You'll learn to clear, add, and remove elements in an array for efficient data tracking and manipulation.

---

## **Instructions**

### 1. Clear Array Elements
Use `Array.Clear()` to remove the values of specific elements in the array.

<!--
string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
-->

**Key Method**:
- **`Array.Clear(pallets, startIndex, count)`**:
  - Clears `count` elements starting from `startIndex`, replacing them with `null`.

**Expected Output**:
<!--
Clearing 2 ... count: 4
-- 
-- 
-- B12
-- A13
-->

---

### 2. Verify Cleared Elements
Check the value of a cleared element before and after using `Array.Clear()`.

<!--
Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");
-->

**Expected Output**:
<!--
Before: B14
After: 
-->

---

### 3. Handle `null` Values Safely
Attempt to call a method on a cleared element and handle potential exceptions.

<!--
if (pallets[0] != null)
    Console.WriteLine($"After: {pallets[0].ToLower()}");
-->

---

### 4. Resize the Array
Resize the array to add or remove elements dynamically.

#### Add Elements:
<!--
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
-->

**Expected Output**:
<!--
Resizing 6 ... count: 6
-- 
-- 
-- B12
-- A13
-- C01
-- C02
-->

#### Remove Elements:
<!--
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
-->

**Expected Output**:
<!--
Resizing 3 ... count: 3
-- 
-- 
-- B12
-->

---

## **Key Notes**
- **`Array.Clear()`**:
  - Clears the values of elements but keeps the array size unchanged.
  - Cleared elements are set to `null` for reference types.

- **`Array.Resize()`**:
  - Adds or removes elements by resizing the array.
  - New elements are added as `null`.

- **Handling `null` Values**:
  - Always check for `null` before accessing a cleared element to avoid exceptions.

---

## **Recap**
1. Use the **`Clear()`** method to empty array elements.
2. Use the **`Resize()`** method to change the size of an array.
3. Cleared or new elements are set to `null` and don't point to any value in memory.
4. Manage and handle `null` values carefully to prevent runtime errors.

# Exercise - Complete a Challenge to Reverse Words in a Sentence

## **Overview**
In this challenge, you'll reverse the letters of each word in a sentence while maintaining the original word positions. This exercise combines several string manipulation techniques to produce the desired output.

---

## **Task**
1. **Input**: A string where words are separated by spaces.
2. **Output**: A string where each word has its letters reversed, but the word order remains the same.

---

## **Starter Code**
<!-- 
string pangram = "The quick brown fox jumps over the lazy dog";
 -->

---

## **Expected Output**
<!-- 
ehT kciuq nworb xof spmuj revo eht yzal god
 -->

---

## **Hints**
1. **Break Down the Problem**:
   - Split the sentence into individual words.
   - Reverse the letters in each word.
   - Join the reversed words back into a sentence.

2. **Concepts to Use**:
   - **`Split()`**: To break the sentence into words.
   - **`ToCharArray()`**: To convert a word into an array of characters.
   - **`Array.Reverse()`**: To reverse the characters in a word.
   - **`String.Join()`**: To reassemble the reversed words into a sentence.

3. **Steps**:
   - Split the `pangram` string into an array of words.
   - Iterate through each word in the array:
     - Convert the word to a character array.
     - Reverse the character array.
     - Convert the reversed array back to a string.
   - Combine the reversed words into a single string with spaces.

---

## **Implementation**
<!-- 
string pangram = "The quick brown fox jumps over the lazy dog";

// Split the sentence into words
string[] words = pangram.Split(' ');

// Array to store reversed words
string[] reversedWords = new string[words.Length];

// Iterate through each word
for (int i = 0; i < words.Length; i++)
{
    // Convert word to char array, reverse it, and convert back to string
    char[] charArray = words[i].ToCharArray();
    Array.Reverse(charArray);
    reversedWords[i] = new string(charArray);
}

// Combine reversed words into a sentence
string result = String.Join(" ", reversedWords);

// Display the result
Console.WriteLine(result);
 -->

---

## **Recap**
1. Use **`Split()`** to break a string into an array of words.
2. Use **`ToCharArray()`** and **`Array.Reverse()`** to reverse the characters in each word.
3. Use **`String.Join()`** to join the reversed words back into a sentence.
4. Iterate through the words using a **`for` loop** to process each word individually.

This challenge demonstrates how to decompose a larger problem into smaller, manageable steps.

# Exercise - Parse a String of Orders, Sort the Orders, and Tag Possible Errors

## **Overview**
In this challenge, you'll parse a string of "Order IDs", sort them, and tag orders as errors if they aren't exactly four characters long.

---

## **Task**
1. **Input**: A comma-separated string of "Order IDs".
2. **Output**: The "Order IDs" sorted alphabetically. Tag any "Order ID" that is not exactly four characters in length with `- Error`.

---

## **Starter Code**
<!-- 
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
 -->

---

## **Expected Output**
<!-- 
A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error
 -->

---

## **Steps to Solve the Challenge**
1. **Parse the Orders**:
   - Split the `orderStream` string into an array of individual orders using **`Split(',')`**.

2. **Sort the Orders**:
   - Use **`Array.Sort()`** to sort the array alphabetically.

3. **Validate and Tag Orders**:
   - Loop through the array using a **`foreach`** statement.
   - Check the length of each "Order ID".
   - If the length is not exactly four, append the string `- Error` to the order.

4. **Output the Results**:
   - Display each "Order ID" on a new line.

---

## **Implementation**
<!-- 
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// Parse orders into an array
string[] orders = orderStream.Split(',');

// Sort the orders alphabetically
Array.Sort(orders);

// Validate and output each order
foreach (var order in orders)
{
    if (order.Length != 4)
    {
        Console.WriteLine($"{order}   - Error");
    }
    else
    {
        Console.WriteLine(order);
    }
}
 -->

---

## **Recap**
1. Use **`Split(',')`** to convert a comma-separated string into an array.
2. Use **`Array.Sort()`** to alphabetically sort an array.
3. Validate each item in the array using **`if`** statements to check for errors.
4. Loop through the array with **`foreach`** to process and output results.

This exercise reinforces parsing, sorting, and validation techniques in C#.

# Summary

## **Module Overview**
In this module, you completed exercises using helper methods to work more effectively with arrays in C#. These exercises focused on manipulating arrays and converting between strings and arrays.

---

## **Key Learnings**
1. **Clear Items in an Array**:
   - Use the **`Array.Clear()`** method to set elements of an array to `null` or the default value for the data type.

2. **Resize an Array**:
   - Use the **`Array.Resize()`** method to add or remove elements, adjusting the size of an array dynamically.

3. **Convert a String into an Array**:
   - Use **`String.Split()`** to parse a string into an array by specifying a delimiter (e.g., a comma) to separate the elements.

4. **Combine Array Elements into a String**:
   - Use **`String.Join()`** to concatenate all elements of an array into a single string, specifying a delimiter to separate the values.

---

## **Conclusion**
These array helper methods allow for flexible data manipulation in your applications. Without these features, working with arrays would be much more restrictive and less efficient.

# Format alphanumeric data for presentation in C#

# String Formatting in C#

## **Module Overview**
In this module, you learn to format strings effectively in C# using various techniques to manage white space, special characters, padding, alignment, and numeric data like currency, percentages, and decimals.

---

## **Learning Objectives**
1. **Character Escape Sequences**:
   - Use escape sequences to add tabs, new lines, and Unicode characters to strings.
   - Examples:
     - `\t` - Tab
     - `\n` - New Line
     - `\uXXXX` - Unicode character (e.g., `\u0041` for "A")

2. **Verbatim String Literals**:
   - Use the `@` symbol to create verbatim string literals that preserve formatting, including line breaks and backslashes.
   - Escape common characters like backslash (`\`) and double-quotes (`""`).
   - Example:
     ```csharp
     string filePath = @"C:\Users\SomeUser\Documents\File.txt";
     ```

3. **Composite Formatting and String Interpolation**:
   - Merge templates with variables:
     - **Composite Formatting**: Use indexed placeholders.
       ```csharp
       Console.WriteLine("Hello, {0}!", "World");
       ```
     - **String Interpolation**: Use the `$` symbol for cleaner syntax.
       ```csharp
       string name = "World";
       Console.WriteLine($"Hello, {name}!");
       ```

4. **Numeric Formatting**:
   - Include format specifiers to provide context to numeric data:
     - **Currency**: `C`
     - **Percentage**: `P`
     - **Numbers with Decimals**: `N`
   - Examples:
     ```csharp
     decimal price = 123.45m;
     Console.WriteLine($"{price:C}"); // $123.45
     Console.WriteLine($"{price:P}"); // 12,345.00%
     Console.WriteLine($"{price:N}"); // 123.45
     ```

---

## **Summary**
By mastering string formatting in C#, you can:
- Add meaningful structure to your strings with escape sequences and verbatim literals.
- Merge templates with variables using composite formatting and interpolation.
- Provide proper context for numeric data with format specifiers for currency, percentages, and decimals.

# Introduction

Suppose you work for a sales and marketing department that sends thousands of personalized letters to the company's existing clients who are institutional investors. Your team's job is to promote new financial products to the customer. Each letter you send merges personalized information about the customer. The letter compares the returns of their current portfolios with projected returns using the newest products. How do you merge and format the data correctly?

From a high-level perspective, software developers are concerned with:

- **Data input**, including data typed in by a user from a keyboard, using their mouse, a device, or by another software system via a network request.
- **Data processing**, including decision logic, manipulating data, and performing calculations.
- **Data output**, including presentation to an end user via a command-line message, a window, a web page, or saving the processed data into a file, and sending it to a network service.

To solve business problems in C#, you need to work with different types of data, such as strings and numbers. You also need to perform various operations on the data, such as calculations, comparisons, or conversions. In this module, you output string and numeric data in C# using various formatting options. You also create a receipt mockup and a personalized marketing message using data merging techniques.

---

## Learning objectives
In this module, you will:

- **Merge string templates with variables** using composite formatting.
- **Use various format specifiers** to properly display percentages, currency, and numbers.
- **Use padding methods** to properly align string values.

# What is Composite Formatting?

Composite formatting uses numbered placeholders within a string. At runtime, everything inside the braces is resolved to a value passed in based on its position.

This example of composite formatting uses a built-in `Format()` method on the string data type:

//csharp
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

//endcsharp

**Output:**

//output
Hello World!
//endoutput

### Key Points:

1. Data types and variables have built-in "helper methods" to simplify tasks.
2. The literal string `"{0} {1}!"` forms a template, parts of which are replaced at runtime:
   - `{0}` is replaced by the first argument, `first`.
   - `{1}` is replaced by the second argument, `second`.
3. Numbering starts at 0, a common convention in software development.

---

### Updating Composite Formatting

Update your code as follows:

//csharp
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);
//endcsharp

**Output:**

//output
World Hello!
Hello Hello Hello!
//endoutput

Observations:
- Tokens like `{1}` can be arranged in any order.
- Tokens can be reused, and unused variables are ignored without errors.

---

# What is String Interpolation?

String interpolation simplifies composite formatting. Instead of numbered tokens, you use variable names directly inside curly braces.

Prefix the string with `$` to indicate interpolation. For example:

//csharp
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
//endcsharp

**Output:**

//output
Hello World!
World Hello!
Hello Hello Hello!
//endoutput

---

# Formatting Currency

Use the `:C` currency format specifier to present variables as currency:

//csharp
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
//endcsharp

**Output (en-US culture):**

//output
Price: $123.45 (Save $50.00)
//endoutput

**Culture Impact:**
- Running in `fr-FR` culture (French in France) produces:
//output
Price: 123,45 € (Save 50,00 €)
//endoutput

---

# Formatting Numbers

Use `:N` to format numbers for readability by including commas:

//csharp
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
//endcsharp

**Output:**

//output
Measurement: 123,456.79 units
//endoutput

Add a number after `N` to control precision:

//csharp
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");
//endcsharp

**Output:**

//output
Measurement: 123,456.7891 units
//endoutput

---

# Formatting Percentages

Use `:P` to format percentages, rounding to two decimal places by default:

//csharp
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
//endcsharp

**Output:**

//output
Tax rate: 36.79%
//endoutput

---

# Combining Formatting Approaches

Use `String.Format()` or string interpolation for combined formatting:

//csharp
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price.", (price - salePrice), price);

yourDiscount += $" A discount of {((price - salePrice) / price):P2}!";
Console.WriteLine(yourDiscount);
//endcsharp

**Output:**

//output
You saved $7.56 off the regular $67.55 price. A discount of 11.19%!
//endoutput

---

# Recap:

- Composite formatting uses `{0}`, `{1}`, etc., within a string template and arguments passed to methods like `String.Format()`.
- String interpolation uses `$` and curly braces with variable names directly.
- Use `:C` for currency, `:N` for numbers, and `:P` for percentages.
- String formatting respects the user's culture settings for currency, numbers, and percentages.

# Exercise - Explore string interpolation

You need to create the code to print a receipt for the customer purchasing shares of an investment product. The shares are purchased automatically at the end of the year based on a series of payroll deductions, so the number of shares purchased usually contains a decimal amount. To print the receipt, you would likely need to combine data of different types, including fractional values, currency, and percentages in precise ways.

---

## Display the invoice number using string interpolation

Select and delete all code lines in the Visual Studio Code Editor.

Update your code in the Visual Studio Code Editor as follows:

<!--
```
csharp
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
```
-->

Save and run your code. You should see the following output:

<!--
```
output
Invoice Number: 1201
```
-->

---

## Display the product shares with one thousandth of a share (0.001) precision

Add the following code below the previous:

<!--
```
csharp
Console.WriteLine($"   Shares: {productShares:N3} Product");
```
-->

Save and run your code. You should see the following output:

<!--
```
output
Invoice Number: 1201
   Shares: 25.457 Product
```
-->

---

## Display the subtotal formatted as currency

Add the following code below the previous:

<!--
```
csharp
Console.WriteLine($"     Sub Total: {subtotal:C}");
```
-->

Save and run your code. You should see the following output:

<!--
```
output
Invoice Number: 1201
   Shares: 25.457 Product
     Sub Total: $2,750.00
```
-->

---

## Display the tax formatted as a percentage

Add the following code below the previous:

<!--
```
csharp
Console.WriteLine($"           Tax: {taxPercentage:P2}");
```
-->

Save and run your code. You should see the following output:

<!--
```
output
Invoice Number: 1201
   Shares: 25.457 Product
     Sub Total: $2,750.00
           Tax: 15.83%
```
-->

---

## Finalize the receipt with the total amount due formatted as currency

Add the following code below the previous:

<!--
```
csharp
Console.WriteLine($"     Total Billed: {total:C}");
```
-->

The entire code for the exercise should match as follows:

<!--
```
csharp
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");
```
-->

Save and run your code. You should see the following output:

<!--
```
output
Invoice Number: 1201
   Shares: 25.457 Product
     Sub Total: $2,750.00
           Tax: 15.83%
     Total Billed: $3,185.19
```
-->

# Modify the Content of Strings Using Built-In string data type methods in C#

# Introduction

Suppose you're a developer for an application letting a business update its "last chance deals" website by sending an email. The update email uses special required text in the title and body of the email to instruct the automation how to update the website. The mail includes the next deal title, discount %, expiration, and when to publish the offer live.

Frequently, application data you need to work with is from other software systems and has data you don't want or need. Sometimes the data is in an unusable format, containing extra information that makes the important information difficult to extract. To adjust data for your application, you need tools and techniques to parse through string data, isolate the information you need, and remove the information you don't need.

In this module, you use string helper methods to identify and isolate the information you're interested in. You learn how to copy a smaller portion of a larger string. You replace characters, or remove characters from a string.

By the end of this module, you're able to modify a string's contents, isolating specific portions to extract, replace, or remove.

---

## Learning Objectives

In this module, you will:

- Identify the position of a character or string inside of another string
- Extract portions of strings
- Remove portions of strings
- Replace values in strings with different values

# Exercise - Use the string's IndexOf() and Substring() helper methods

In this exercise, you use the `IndexOf()` method to locate the position of one or more characters or strings inside a larger string. You use the `Substring()` method to return the part of the larger string that follows the character positions you specify.

You'll also use an overloaded version of the `Substring()` method to set the length of characters to return after a specified position in a string.

---

## Prepare your coding environment

This module includes hands-on activities that guide you through the process of building and running demonstration code. You're encouraged to complete these activities using Visual Studio Code as your development environment.

---

### Write code to find parenthesis pairs embedded in a string

Ensure that you have Visual Studio Code open and `Program.cs` displayed in the Editor panel.

`string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);`

Save and run your code. You should see the following output:

`13  
36`

Now that you have the two indexes, you can use them as the boundaries to retrieve the value between them.

---

### Add code to retrieve the value between parenthesis

Update your code as follows:

`string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));`

Save and run your code. You should see the following output:

`(inside the parentheses`

---

### Modify the starting position of the substring

Update your code as follows:

`string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));`

Save and run your code. You should see the following output:

`inside the parentheses`

---

### Example with <span> tags

Update your code as follows:

`string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));`

Save and run your code. You should see the following output:

`between the tags`

---

## Avoid magic values

Update your code as follows:

`string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));`

This approach avoids "magic values" by using constants for reusable strings.

---

## Recap

- `IndexOf()` gives you the first position of a character or string inside of another string.
- `IndexOf()` returns `-1` if it can't find a match.
- `Substring()` returns just the specified portion of a string, using a starting position and optional length.
- Avoid hardcoded "magic values". Instead, define a `const` variable for better maintainability.

# Summary

Your goal was to extract, remove, and replace values in strings. Often, the data you receive has extraneous data or characters that you need to avoid or eliminate before you can use the target data.

Utilizing the `IndexOf()` method enabled you to identify the position of a character or string within another string. The position returned from the `IndexOf()` method was the first building block to using the `Substring()` method to extract a portion of a string given the starting position and the number of characters to extract (the length). It also enabled you to use the `Remove()` method to eliminate characters from a string given the starting position and the length. 

You learned about variations like the `LastIndexOf()` method to find the last position of a character or string within another string, and the `IndexOfAny()` method to find the position of any value of a given `char` array. You used the `while` statement to iterate through a longer string to find and extract all instances of a character or string within a larger source string. Finally, you used the `Replace()` method to swap all instances of a character or string inside of a larger string.

While it might be possible to perform these kinds of operations using a `char` array—iterating through each `char` to find matches, keeping track of the starting and ending points you wanted to locate, and so on—it would take many more steps to accomplish what these string helper methods can achieve in a single call.

# Guided project - Work with variable data in C#

# Learning Objectives

- Apply iteration statements to gather data input.
- Use data processing.
- Format data output.
- Choose the correct data types and safely convert data types.
- Manipulate number, string, and character arrays, as well as add, remove, and sort data.
- Modify and build complex strings from multiple data sources, and format data for display across regions.

# Introduction

Suppose you're a developer who likes to support the local community. You and some of your friends started a business that helps find new homes for stray or abandoned cats and dogs. Your business started off small, with just a couple of animals, but it's starting to grow. Your friends have an initial application developed that enables the entry and display of the animals available for adoption. They ask you to investigate adding features to the app that could help to match the animals in your care with people who are looking for a new family pet.

In completing this coding project, you apply your C# data knowledge and skills in:

- Choosing the correct data types and safely converting data types.
- Creating two-dimensional arrays of numbers and strings.
- Searching data in arrays to display or update data.
- Modifying and building complex strings from multiple data sources, and formatting data for display across regions.

Your team has found that it's important to search the pet data to identify animals with possible matches based on characteristics provided by potential owners. Further, the team wants to include a fundraising feature to include suggested donation data and to present the pet data with fewer lines of output.

You begin with a starting application that adds a predefined sample data to the `pets` array. The application has two menu items. The first item displays all the pet data, and the code is complete. The second menu item, "Display all dogs with a specified characteristic", is a "work in progress" that you complete.

You also make updates to existing code to add `suggestedDonation` data and display all data in a shortened format.

By the end of this module, you're able to develop code that combines iteration statements with data input, data processing, string indexing, and data output.

# The Design Specification

For the new features of the Contoso Pets application, the design specification provides details for the dog search and suggested donation features:

## Dog Attribute Search

- Gather input for the pet characteristic search term.
- Loop through the `animals` array and identify "dogs."
- For each dog, combine the physical and personality descriptions to search.
- Search the combined description for the input term match.
- Output the dogs that have a term match.

## Suggested Donation Data

- Define `suggestedDonation` string.
- Expand the `ourAnimals` array to contain `suggestedDonation` and populate sample data for `suggestedDonation`.
- Ensure all usage of `ourAnimals` array accounts for the added `suggestedDonation` data.
- Output `suggestedDonation` with regional currency symbol ($, €, ¥, ...).

---

# Starter Code Overview

Initial starter code development is complete.

The Starter project for this guided project module includes a `Program.cs` file that provides the following code features:

- The code declares variables used to collect and process pet data and menu item selections.
- The code declares the `ourAnimals` array.
- The code uses a `for` loop around an `if-else if-else` construct to populate the `ourAnimals` array with a sample dataset.
- The code displays the following main menu options for user selection:
  1. List all of our current pet information.
  2. Display all dogs with a specified characteristic.
  
  _Enter menu item selection or type "Exit" to exit the program._

- The code reads the user's menu item selection and displays a message echoing their selection.
- Only selection "1. List all of our current pet information" functions using the starter code.

---

# Your Goal

Your goal is to update the existing code to develop app features described previously. The key features:

- Add dog attribute search.
- Include suggested donation data.

You use Visual Studio Code as your development environment, and you test your application at each stage of your development process.

---

# Setup

Use the following steps to prepare for the guided project exercises.

### 1. Download a zip file containing the code folders for the guided project.
- In a browser, navigate to **Guided-project-Work-with-variable-data-in-CSharp.zip** to download the zip file.

### 2. Unzip the downloaded files locally (or in the sandbox if you aren't using a local dev environment).
- On your local machine, navigate to your downloads folder.
- Right-click the **Guided-project-Work-with-variable-data-in-CSharp.zip** file, and then select **Extract all**.
- Use the **Browse** button to specify the Windows Desktop folder as the extract location, and then select **Select Folder**.
- Select **Show extracted files when complete**, and then select **Extract**.
- Make note of the extracted folder location.

### 3. Open the extracted Guided-project-Work-with-variable-data-in-CSharp-main folder in Visual Studio Code.
- Open Visual Studio Code locally (or open MS Learn sandbox and open Visual Studio Code if you aren't using a local dev environment).
- In Visual Studio Code, on the **File** menu, select **Open Folder**.
- Navigate to the folder that contains your extracted files, expand the folder structure to locate the folder named **GuidedProject**.
- Select **Guided-project-Work-with-variable-data-in-CSharp-main**, and then select **Select Folder**.

The Visual Studio Code **EXPLORER** view should show two subfolders named **Final** and **Starter**.

---

You're now ready to begin the Guided project exercises. Good luck!

Trivia:
1. **Which of the following options correctly returns a string value?**  
   - `return "";`

2. **Which of the following statements is true about the return keyword?**  
   - It terminates the execution of a method.

3. **Which of the following options is a valid return statement?**  
   - `return 5 % 2;`

1. **A developer wants to create a method that compares two values. Which of the following options is the best data type for the method to return?**  
   - A bool value.

2. **A developer wants to create a method that returns a value in an array. Which of the following options would be a good choice for a method signature?**  
   - `string GetValueAtIndex(string[] array, int index)`

1. **What is code debugging?**  
   - A process to isolate and fix issues in code logic.

2. **Who is responsible for software testing?**  
   - Both developers and testers.

3. **What happens if an exception isn't managed in code?**  
   - The application generates an error message and closes.
