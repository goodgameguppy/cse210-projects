using System;
public class Reference
{
    // attributes
    private string _book = "";
    private int _chapter = 0;
    private int _startVerse = 0;
    private int? _endVerse;

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        if (_endVerse.HasValue)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
    }

    public void DisplayReference()
    {
        if (_endVerse.HasValue)
        {
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}");
        }
    }
}