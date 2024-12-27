**Guided project - Develop conditional branching and looping structures in C#**

Gain experience developing a console app that implements selection and iteration statements to achieve app specifications.

**Learning objectives**
In this module, you'll practice how to:

- Use Visual Studio Code to develop a C# console application that uses a combination of selection and iteration statements to implement logical workflows in accordance with supplied application data and user interactions.
- Evaluate the underlying conditions and make an informed decision when choosing between if-elseif-else and switch statements, and between foreach, for, while, and do iteration statements.
- Scope variables at an appropriate level within an application.

**The application you develop will:**

- Add predefined sample data to the pets array.
- Iterate a "menu options and user selection" code block to establish the outer loop of your application.
- Implement code branches corresponding to the user's menu selections.
- Display all the information contained in the array used to store pet data (based on user's menu selection).
- Iterate an "add new animal information" code block that enables the user to add one or more new animals to the pets array (based on user's menu selection).

**Learning Objectives**
In this module, you'll practice how to:

- Use Visual Studio Code to develop a C# console application that uses a combination of selection and iteration statements to implement logical workflows.
- Evaluate the underlying conditions in your application and make an informed decision between selection statement options.
Evaluate the underlying conditions in your application and make an informed decision between iteration statement options.
- Scope variables at an appropriate level within an application.

**The Project Overview and Instructions**
# Contoso Pets Guided Project

## **Project Overview**

You're working on the **Contoso Pets** application, an application that helps place pets in new homes. The specifications for your application are:

1. **Create a C# console application.**

2. **Store application data in a multidimensional string array named `ourAnimals`.**  
   The `ourAnimals` array includes the following "pet characteristics" for each animal:
   - Pet ID #.
   - Pet species (cat or dog).
   - Pet age (years).
   - A description of the pet's physical condition/characteristics.
   - A description of the pet's personality.
   - The pet's nickname.

3. **Implement a sample dataset** that represents dogs and cats currently in your care.

4. **Display menu options** to access the main features of the application.  
   The main features enable the following tasks:
   - List the pet information for all animals in the `ourAnimals` array.
   - Add new animals to the `ourAnimals` array.

---

### **Menu Options and Application Features**

#### **Menu Option 1: List all of our current pet information**
Display all the data in the `ourAnimals` array.

#### **Menu Option 2: Assign values to the `ourAnimals` array fields**
Conditions:
- The pet species (dog or cat) must be entered when a new animal is added.
- A pet ID must be programmatically generated.
- Physical characteristics (e.g., age, breed, spayed/neutered status) may initially be unknown.
- Nicknames and personality descriptions may initially be unknown.

---

### **Additional Requirements**

- **Update Animal Records**:
  - Ensure animal ages and physical descriptions are complete (e.g., after a veterinarian's examination).
  - Ensure nicknames and personality descriptions are complete (e.g., after team observations).

- **Edit Animal Records**:
  - Edit an animal’s age (e.g., when a pet's birthday occurs in care).
  - Edit an animal’s personality description (e.g., as behavior changes over time).

- **Search by Characteristics**:
  - Display all cats meeting specified physical characteristics.
  - Display all dogs meeting specified physical characteristics.

---

### **Starter Code Features**

The starter `Program.cs` file includes the following:
- Variables to collect and process pet data and menu selections.
- The declaration of the `ourAnimals` array.
- A `for` loop around an `if-elseif-else` construct to populate the `ourAnimals` array with a sample dataset.
- A main menu displaying the following options:
  1. List all of our current pet information.
  2. Assign values to the `ourAnimals` array fields.
  3. Ensure animal ages and physical descriptions are complete.
  4. Ensure animal nicknames and personality descriptions are complete.
  5. Edit an animal’s age.
  6. Edit an animal’s personality description.
  7. Display all cats with a specified characteristic.
  8. Display all dogs with a specified characteristic.
  9. Exit the program.

The code currently:
- Reads the user's menu selection.
- Echoes their selection back to them.

---

### **Your Goals**

Your task is to develop the features for **Menu Options 1 and 2**. Specifically:

#### **1. List all animals (Menu Option 1)**
- Write the code to display all data from the `ourAnimals` array.

#### **2. Add new animals (Menu Option 2)**
- Build a loop for entering new data into the `ourAnimals` array.
- Write the logic to validate, process, and save new data.

---

### **Development Plan**

To complete this guided project, you’ll:

1. **Update the code** for the sample data.
2. **Construct a loop** around the main menu and create branches for each menu option.
3. **Implement Menu Option 1**:
   - Write code to iterate through the `ourAnimals` array and display its data.
4. **Implement Menu Option 2**:
   - Build a loop for entering new animals.
   - Write validation and saving logic for the new data.

You will test your application at each stage of the development process.

**Starter Code**
```csharp
// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    if (i == 0)
    {
        animalSpecies = "dog";
        animalID = "d1";
        animalAge = "2";
        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
        animalNickname = "lola";
    }
    else if (i == 1)
    {
        animalSpecies = "dog";
        animalID = "d2";
        animalAge = "9";
        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
        animalNickname = "loki";
    }
    else if (i == 2)
    {
        animalSpecies = "cat";
        animalID = "c3";
        animalAge = "1";
        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
        animalPersonalityDescription = "friendly";
        animalNickname = "Puss";
    }
    else if (i == 3)
    {
        animalSpecies = "cat";
        animalID = "c4";
        animalAge = "?";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
    }
    else
    {
        animalSpecies = "";
        animalID = "";
        animalAge = "";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options

Console.Clear();

Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
Console.WriteLine(" 1. List all of our current pet information");
Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
Console.WriteLine(" 5. Edit an animal’s age");
Console.WriteLine(" 6. Edit an animal’s personality description");
Console.WriteLine(" 7. Display all cats with a specified characteristic");
Console.WriteLine(" 8. Display all dogs with a specified characteristic");
Console.WriteLine();
Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

readResult = Console.ReadLine();
if (readResult != null)
{
    menuSelection = readResult.ToLower();
}

Console.WriteLine($"You selected menu option {menuSelection}.");
Console.WriteLine("Press the Enter key to continue");

// pause code execution
readResult = Console.ReadLine();
```

**TRIVIA**

### 1. When is it appropriate to use a switch-case construct rather than an if-elseif-else construct?
A switch-case construct is appropriate when more than 2-3 else if code blocks are required.

---

### 2. Why should a developer choose a for statement rather than a foreach statement when processing the contents of a multidimensional array?
for statements enable a developer to treat array dimensions separately.

---

### 3. Why is it important to scope a variable at its lowest necessary level?
It ensures that application resources and the security footprint are kept small.

**Challenge - Branching & Looping**

Applications often use a combination of selection and iteration statements to establish code execution paths. In addition, user input and calculations influence the flow through an application. Creating a user interface that implements a design specification can be challenging.

Suppose you're a developer working on the Contoso Pets application, an application that's used to find homes for stray or abandoned pets. Some of the development work has already been completed. For example, the application's main menu and the code used to store new pet information have been developed. However, certain information isn't always available when a pet is entered in your system. You need to develop the features that ensure a complete dataset exists for each animal in your care.

In this module, you'll develop the following features of the Contoso Pets application:

- A feature that ensures animal ages and physical descriptions are complete.
- A feature that ensures animal nickname and personality descriptions are 
complete.

By the end of this module, your Contoso Pets application will ensure that every element in the ourAnimals array is complete.

**Learning Objectives**

In this module, you'll demonstrate your ability to:

- Use Visual Studio Code to develop a C# console application that uses a combination of selection and iteration statements to implement logical workflows.
- Evaluate the underlying conditions in your application and make an informed decision between selection statement options.
- Evaluate the underlying conditions in your application and make an informed decision between iteration statement options.
- Scope variables at an appropriate level within an application.