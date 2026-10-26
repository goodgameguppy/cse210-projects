using System;
public class Word
{
    // attributes
    private string _word = "";
    private bool _isHidden = false;

    // constructor
    public Word(string word)
    {
        _word = word;
    }

    // behaviors
    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetWord()
    {
        if (_isHidden == false)
        {
            return _word;
        }
        else
        {
            int numLength = _word.Length;
            char hiddenchar = '_';
            return new string(hiddenchar, numLength);
        }
    }
}