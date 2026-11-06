using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void BreatheIn()
    {
        for (int i = 4; i > 0; i--)
        {
            Console.Write($"\rBreathe in... {i} ");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
    }

    public void BreatheOut()
    {
        for (int i = 6; i > 0; i--)
        {
            Console.Write($"\rBreathe out... {i} ");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
    }

    public void Run()
    {
        ShowPrologue();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            BreatheIn();
            BreatheOut();

            // One complete breathing cycle takes 10 seconds.
            elapsed += 10;
        }

        ShowEpilogue();
    }
}