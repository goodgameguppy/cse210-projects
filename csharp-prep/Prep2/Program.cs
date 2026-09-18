using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade did you receive? ");
        string grade = Console.ReadLine();
        int gradeNum = int.Parse(grade);
        string gradeLetter;
        string gradeModifier;

        if (gradeNum >= 90)
        {
            gradeLetter = "an A";
        }
        else if (gradeNum >= 80)
        {
            gradeLetter = "a B";
        }
        else if (gradeNum >= 70)
        {
            gradeLetter = "a C";
        }
        else if (gradeNum >= 60)
        {
            gradeLetter = "a D";
        }
        else
        {
            gradeLetter = "an F";
        }

        if (gradeNum >= 97)
        {
            gradeModifier = "";
        }
        else if ((gradeNum % 10 >= 7) && (gradeNum >= 70))
        {
            gradeModifier = ("+");
        }
        else if ((gradeNum % 10 <= 3) && (gradeNum >= 70))
        {
            gradeModifier = ("-");
        }
        else
        {
            gradeModifier = ("");
        }

        Console.WriteLine($"You got {gradeLetter}{gradeModifier}");
    }
}