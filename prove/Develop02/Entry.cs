using System;

public class Entry
{
    // attributes
    public DateTime _date;
    public string _response = "";
    public string _prompt = "";
    public DateTime _lastEdit;

    // behaviors
    public Entry(string prompt, string response)
    {
        _date = DateTime.Now;
        _prompt = prompt;
        _response = response;
        _lastEdit = DateTime.Now;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date created: {_date:yyyy-MM-dd HH:mm:ss}");   
        Console.WriteLine($"Prompt: {_prompt}");   
        Console.WriteLine($"Response: {_response}");   
        if (_lastEdit != _date)
        {
            Console.WriteLine($"Date last edited: {_lastEdit}");  
        } 
    }

    public void EditEntry(string newResponse)
    {
        _response = newResponse;
        _lastEdit = DateTime.Now;
    }
}