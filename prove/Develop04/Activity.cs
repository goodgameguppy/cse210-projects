using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Timer()
    {
        for (int i = _duration; i > 0; i--)
        {
            Console.Write($"\rTime remaining: {i} seconds ");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
    }

    public void ShowPrologue()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for this activity? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner();
        Console.WriteLine();
    }

    public void ShowEpilogue()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Console.WriteLine(
            $"You completed the {_name} for {_duration} seconds."
        );

        Console.WriteLine();
        Console.WriteLine("Returning to the menu...");
        ShowSpinner();
        Console.WriteLine();
    }

    public void ShowSpinner()
    {
        string[] symbols = { "|", "/", "-", "\\" };

        for (int i = 0; i < 12; i++)
        {
            Console.Write(symbols[i % symbols.Length]);

            Thread.Sleep(250);

            Console.Write("\b \b");
        }
    }
}