using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Choose a difficulty:");
        Console.WriteLine("1. Practice - Hide 1 word");
        Console.WriteLine("2. Normal - Hide 3 words");
        Console.WriteLine("3. Challenge - Hide 5 words");

        string difficulty = Console.ReadLine();
        int wordsToHide = 3;

        if (difficulty == "1")
        {
            wordsToHide = 1;
        }
        else if (difficulty == "3")
        {
            wordsToHide = 5;
        }
        
        Reference reference = new Reference("Moroni", 10, 4, 5);

        Verse verse = new Verse(
            "4 And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. 5 And by the power of the Holy Ghost ye may know the truth of all things."
        );

        string response = "";

        while (!verse.AllWordsHidden() && response.ToLower() != "quit")
        {
            Console.Clear();

            reference.DisplayReference();
            verse.DisplayVerse();

            Console.WriteLine();
            Console.WriteLine("Press Enter to hide three words, or type quit.");
            response = Console.ReadLine();

            if (response.ToLower() != "quit")
            {
                verse.HideWords(wordsToHide);;
            }
        }

        Console.Clear();
        reference.DisplayReference();
        verse.DisplayVerse();

        Console.WriteLine();

        if (response.ToLower() == "quit")
        {
            Console.WriteLine("Program ended.");
        }
        else
        {
            Console.WriteLine("All words are hidden.");
        }
    }
}