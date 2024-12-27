Project overview
You're developing a Student Grading application that automates the calculation of grades for each student in a class. The parameters for your application are:

Create a C# console application.

Start with four students. Each student has five exam scores.

Each exam score is an integer value, 0-100, where 100 represents 100% correct.

A student's overall exam score is the average of their five exam scores.

Criteria for extra credit assignments:

Include extra credit assignment scores in the student's scores array.
Extra credit assignments are worth 10% of an exam score (when calculating the final numeric grade).
Add extra credit assignment scores to the student's total exam score before calculating the final numeric grade.
Your application needs to automatically assign letter grades based on the calculated final score for each student.

Your application needs to output/display each student’s name and formatted grade.

Your application needs to support adding other students and scores with minimal impact to the code.

You've already completed an initial version of the application. The Starter code project for this Guided project module includes a Program.cs file that provides the following code features:

The code declares variables used to define student names and individual exam scores for each student.
The code includes the variables and algorithms used to sum the exam scores and calculate the average exam score for each student.
The code includes a hard coded letter grade that the developer must apply manually.
The code includes Console.WriteLine() statements to display the student grading report.
Your goal is to update the existing code to include the following features:

Use arrays to store student names and assignment scores.

Use a foreach statement to iterate through the student names as an outer program loop.

Use an if statement within the outer loop to identify the current student name and access that student's assignment scores.

Use a foreach statement within the outer loop to iterate through the assignment scores array and sum the values.

Use an updated algorithm within the outer loop to calculate the average exam score for each student.

Use an if-elseif-else construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.

Integrate extra credit scores when calculating the student's final score and letter grade as follows:

Your code must detect extra credit assignments based on the number of elements in the student's scores array.
Your code must apply the 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.

using System;

// initialize variables - graded assignments 
int examAssignments = 5;

// initialize arrays for each student
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 98, 98, 97, 99, 100, 97, 95 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 94, 90 };
int[] beckyScores = new int[] { 90, 85, 87, 98, 68, 89, 89 };
int[] chrisScores = new int[] { 91, 94, 88, 88, 96, 94, 90 };
int[] ericScores = new int[] { 80, 83, 89, 85, 68, 89, 91 };
int[] gregorScores = new int[] { 91, 91, 91, 89, 92, 96, 93 };


// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
  string currentStudent = name;

  if (currentStudent == "Sophia")
    studentScores = sophiaScores;

  else if (currentStudent == "Andrew")
    studentScores = andrewScores;
  
  else if (currentStudent == "Emma")
    studentScores = emmaScores;

  else if (currentStudent == "Logan")
    studentScores = loganScores;

  else if (currentStudent == "Becky")
    studentScores = beckyScores;

  else if (currentStudent == "Chris")
    studentScores = chrisScores;

  else if (currentStudent == "Eric")
    studentScores = ericScores;

  else if (currentStudent == "Gregor")
    studentScores = gregorScores;
  else
    continue;

  // initialize / reset the sum of scored assignments
  int sumAssignmentScores = 0;

  // initialize / reset the calculated average of exam + extra credit scores
  decimal currentStudentGrade = 0;
  
  int gradedAssignments = 0;

  foreach (int score in studentScores)
  {
    // increment the graded assignments
    gradedAssignments += 1;

    if (gradedAssignments <= examAssignments)
      // add the exam score to the sum
      sumAssignmentScores += score;

    else
      // add the extra credit score to the sum - bonus points equal to 10% of an exam score
      sumAssignmentScores += score / 10;
  }

  currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

  if (currentStudentGrade >= 97)
    currentStudentLetterGrade = "A+";

  else if (currentStudentGrade >= 93)
    currentStudentLetterGrade = "A";

  else if (currentStudentGrade >= 90)
    currentStudentLetterGrade = "A-";

  else if (currentStudentGrade >= 87)
    currentStudentLetterGrade = "B+";

  else if (currentStudentGrade >= 83)
    currentStudentLetterGrade = "B";

  else if (currentStudentGrade >= 80)
    currentStudentLetterGrade = "B-";

  else if (currentStudentGrade >= 77)
    currentStudentLetterGrade = "C+";

  else if (currentStudentGrade >= 73)
    currentStudentLetterGrade = "C";

  else if (currentStudentGrade >= 70)
    currentStudentLetterGrade = "C-";

  else if (currentStudentGrade >= 67)
    currentStudentLetterGrade = "D+";

  else if (currentStudentGrade >= 63)
    currentStudentLetterGrade = "D";

  else if (currentStudentGrade >= 60)
    currentStudentLetterGrade = "D-";

  else 
    currentStudentLetterGrade = "F";

  Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
  
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

Output:
Student         Grade

Sophia          95.8    A
Andrew          102     A+
Emma            88.8    B+
Logan           94.8    A
Becky           88.8    B+
Chris           95      A
Eric            84.4    B
Gregor          94.4    A
Press the Enter key to continue
