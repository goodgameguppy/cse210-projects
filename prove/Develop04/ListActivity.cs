using System;
using System.Collections.Generic;
using System.Threading;

public class ListActivity : Activity
{
    private List<string> _prompts;
    private int _responseNum;

    public ListActivity(
        string name,
        string description,
        int duration,
        List<string> prompts
    ) : base(name, description, duration)
    {
        _prompts = prompts;
        _responseNum = 0;
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }

    public void Run()
    {
        _responseNum = 0;

        ShowPrologue();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();

        Console.WriteLine(
            "Begin listing responses. Press Enter after each response."
        );

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                _responseNum++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_responseNum} items.");

        ShowEpilogue();
    }
}