using System;

class Program
{
    static void Main(string[] args)
    {
        // determine and display letter grade based on numeric score.

       
         Console.Write ("What is your grade percent? ");
               int grade = int.Parse(Console.ReadLine());
        string letterGrade;
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your letter grade is: {letterGrade}");
        // Display a message to the console.

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!.");
        }
        else
        {
            Console.WriteLine("Stay focused and you will get it next time!.");
        }
        // Display a message to the console.
        Console.WriteLine("Thank you for using the grade calculator!");
    }
}