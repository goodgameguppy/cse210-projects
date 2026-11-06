using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<Question> _questionList;

    public ReflectionActivity(
        string name,
        string description,
        int duration,
        List<Question> questionList
    ) : base(name, description, duration)
    {
        _questionList = questionList;
    }

    public void DisplayQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questionList.Count);

        Console.WriteLine();
        Console.WriteLine(_questionList[index].GetQuestion());
        Console.WriteLine();
    }

    public void CountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            string message = $"You may reflect for {i} seconds...";

            Console.Write($"\r{message}");
            Thread.Sleep(1000);

            Console.Write($"\r{new string(' ', message.Length)}\r");
        }
    }

    public void Run()
    {
        ShowPrologue();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            CountDown();
        }

        ShowEpilogue();
    }
}