using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    StartBreathingActivity();
                    break;

                case "2":
                    StartReflectionActivity();
                    break;

                case "3":
                    StartListingActivity();
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private static void StartBreathingActivity()
    {
        BreathingActivity activity = new BreathingActivity(
            "Breathing Activity",
            "This activity will help you relax by guiding your breathing.",
            0
        );

        activity.Run();
    }

    private static void StartReflectionActivity()
    {
        List<Question> questions = new List<Question>
        {
            new Question("Think of a time when you helped someone."),
            new Question("Think of a time when you felt peaceful."),
            new Question("Think of someone who has helped you become better."),
            new Question("Think of a time when you overcame a difficult challenge."),
            new Question("Think of someone who has made a positive difference in your life."),
            new Question("Think of a time when you showed courage."),
            new Question("Think of something you are grateful for."),
            new Question("Think of a time when you learned from a mistake."),
            new Question("Think of a time when someone showed kindness to you."),
            new Question("Think of a goal you are working toward."),
            new Question("Think of a time when you felt proud of yourself."),
            new Question("Think of a place where you feel safe and comfortable."),
            new Question("Think of a quality you admire in another person."),
            new Question("Think of a time when you had to be patient."),
            new Question("Think of a positive change you have made in your life.")
        };

        ReflectionActivity activity = new ReflectionActivity(
            "Reflection Activity",
            "This activity will help you reflect on meaningful experiences.",
            0,
            questions
        );

        activity.Run();
    }

    private static void StartListingActivity()
    {
        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are your personal strengths?",
            "Who are people you have helped recently?"
        };

        ListActivity activity = new ListActivity(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life.",
            0,
            prompts
        );

        activity.Run();
    }
}