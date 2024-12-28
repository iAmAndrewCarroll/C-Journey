# Trivia

1. **What is a debugger?**  
   - A software tool used to observe and control the execution flow of a program.

2. **What is the primary benefit of using a debugger?**  
   - A debugger enables developers to watch their application running and follow program execution one line of code at a time.

3. **What is one of the most important features of a debugger?**  
   - Observation of your program's state.

4. **What is the best way to find the root cause of a bug?**  
   - Using a debugger.

1. **What is the purpose of catching an exception in C#?**  
   - To take corrective action when an error occurs in a program.

2. **Can a developer access the contents of an exception at runtime?**  
   - Yes, exceptions can be accessed and used to take corrective action.

3. **What happens when execution of a C# application results in a system error?**  
   - An exception is created and thrown by the .NET runtime.

4. **What is the relationship between the type of exception and the information it contains?**  
   - The type of exception determines the information it contains.

1. **What is code debugging?**  
   - A process to isolate and fix issues in code logic.

2. **What is a debugger?**  
   - A software tool used to observe and control the execution flow of a program.

3. **What happens when execution of a C# application results in a system error?**  
   - The .NET runtime creates and throws an exception.

4. **What is the purpose of catching an exception in C#?**  
   - To take corrective action when an error occurs in a program.

5. **What is the relationship between the type of exception and the information it contains?**  
   - The type of exception determines the information it contains.

1. **Which section of the Run menu enables a developer to edit or add launch configurations?**

   - The launch configurations section.

2. **Which section of the RUN AND DEBUG view is used to track the current point of execution within the running application?**

   - CALL STACK section.

3. **Which button on the Debug toolbar can be used to resume normal code execution?**

   - The Pause/Continue button.

4. **Which section of the Run menu enables the developer to set breakpoints on code lines?**

   - The Set Breakpoints section.

5. **What capability does the "More" dropdown on the right side of the Debug toolbar provide?**

   - An option to disconnect the debugger.

6. **Which of the following can be used to configure and start a debug session?**

   - The Run and Debug controls panel.








# The Learning 

# The Run Menu in Visual Studio Code

The **Run** menu provides several options grouped into six sections:

---

## **1. Start and Stop Applications**
- Options for starting and stopping code execution.
- Includes starting and stopping with or without the debugger attached.

---

## **2. Launch Configurations**
- Provides access to examine or create launch configurations.

---

## **3. Runtime Control**
- Enables the developer to control how they advance through the code.
- Controls are enabled when execution pauses during a debug session.

---

## **4. Set Breakpoints**
- Allows developers to set breakpoints on specific code lines.
- Code execution pauses on these breakpoints during a debug session.

---

## **5. Manage Breakpoints**
- Enables developers to manage breakpoints in bulk rather than individually.

---

## **6. Install Debuggers**
- Opens the Visual Studio Code **EXTENSIONS** view filtered for code debuggers.

# Run and Debug View User Interface

The **RUN AND DEBUG** view provides access to runtime tools that are invaluable during the debug process.

![Run and Debug View User Interface](/assets/debugInterface.png)

---

## **1. Run and Debug Controls Panel**
- Used to configure and start a debug session.

---

## **2. VARIABLES Section**
- View and manage variable state during a debug session.

---

## **3. WATCH Section**
- Monitor variables or expressions.
- Example: Configure an expression using one or more variables to observe when a particular condition is met.

---

## **4. CALL STACK Section**
- Tracks the current point of execution within the running application.
- Displays the initial point of entry into the application and the execution path leading to the current line of code.
- Shows the method currently being executed and preceding methods in the call stack.

---

## **5. BREAKPOINTS Section**
- Displays the current breakpoint settings.

---

## **6. Debug Toolbar**
- Controls code execution during the debug process.
- Visible only while the application is running.

---

## **7. Current Execution Step**
- Identifies the current execution step by highlighting it in the Editor.
- A breakpoint (marked with a red dot to the left of the line number) indicates the current execution step.

---

## **8. DEBUG CONSOLE**
- Displays messages from the debugger.
- Serves as the default console for console applications.
- Capable of displaying output from methods like `Console.WriteLine()` and related `Console` output methods.

# Controls Panel for the Run and Debug View

At the top of the **RUN AND DEBUG** view, you can find the launch controls:

![Run & View](/assets/debugRun&View.png)
---

### **1. Start Debugging**
- A green arrow button used to start a debug session.

---

### **2. Launch Configurations**
- A dropdown menu that provides access to launch configurations.
- The selected configuration is displayed.

---

### **3. Open 'launch.json'**
- A gear-shaped button to open the `launch.json` file for editing launch configurations if needed.

---

### **4. Views and More Actions**
- An ellipsis button that allows you to show/hide sections of the debug panel and the **DEBUG CONSOLE** panel.

---

# Debug Toolbar

The Debug toolbar provides execution controls while your application is running.

![Debug Toolbar](/assets/debugToolbar.png)
---

### **1. Pause/Continue**
- Pauses execution when the code is running.
- Continues execution when paused.

---

### **2. Step Over**
- Executes the next method as a single command without stepping into its internal logic.

---

### **3. Step Into**
- Enters the next method or line of code to observe execution steps line-by-line.

---

### **4. Step Out**
- When inside a method, this button completes the remaining lines of the current method as a single command and returns to the earlier execution context.

---

### **5. Restart**
- Terminates the current program execution and starts debugging again using the current configuration.

---

### **6. Stop**
- Terminates the current program execution.

---

### **Additional Toolbar Features**
- **Reposition Handle**: A handle on the left side allows developers to reposition the toolbar.
- **More Dropdown**: A dropdown on the right side enables the debugger to disconnect.

---

### **Note**
You can control the location of the debug toolbar using the `debug.toolBarLocation` setting:
- **Floating** (default)
- **Docked** to the **RUN AND DEBUG** view
- **Hidden**  
A floating toolbar can be dragged horizontally or moved into the Editor area.

---

# Recap

Here are a few important things to remember:

1. **Visual Studio Code User Interface**:
   - Configures, starts, and manages debug sessions.
   - The `launch.json` file contains the launch configurations for your application.

2. **Run Menu**:
   - Provides access to common run and debug commands grouped into six sections.

3. **RUN AND DEBUG View**:
   - Includes runtime tools like the **Run and Debug controls panel**.
   - Sections: **VARIABLES**, **WATCH**, **CALL STACK**, and **BREAKPOINTS**.

4. **Debug Toolbar**:
   - Offers execution controls such as **Pause/Continue**, **Step Over**, **Step Into**, **Step Out**, **Restart**, and **Stop**.

5. **DEBUG CONSOLE**:
   - Displays messages from the debugger.
   - Can also display console output from your application.
