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

