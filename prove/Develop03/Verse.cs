using System;
public class Verse
{
    // attribute
    private List<Word> _wordList = [];
    private Random _random = new Random();

    public Verse(string scripture)
    {
        string[] scripturelist = scripture.Split(' ');

        foreach (string wordname in scripturelist)
        {
            Word newWord = new Word(wordname);
            _wordList.Add(newWord);
        }
    }

    public void DisplayVerse()
    {
        for (int i = 0; i < _wordList.Count; i++)
        {
            string tempword = _wordList[i].GetWord();
            Console.Write(tempword);

            // Adds spaces
            if (i < _wordList.Count - 1)
            {
                Console.Write(" ");
            }  
        }
            Console.WriteLine("");
    }

    public void HideWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _wordList)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = _random.Next(visibleWords.Count);

            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
    }
    public bool AllWordsHidden()
    {
        foreach (Word word in _wordList)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}