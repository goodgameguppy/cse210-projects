using System;

class Program
{
    static string GetRandomPrompt()
    {
        string[] prompts =
        {
            "What was the best part of your day?",
            "What did you learn today?",
            "What are you grateful for?",
            "What was something difficult today?",
            "What is one goal you have?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);

        return prompts[index];
    }

    static void Main()
    {
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Add entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Delete entry");
            Console.WriteLine("4. Save journal");
            Console.WriteLine("5. Load journal");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Response: ");

                string response = Console.ReadLine();

                journal.AddEntry(prompt, response);
                Console.WriteLine("Entry added.");
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                journal.DeleteEntries();
            }
            else if (choice == "4")
            {
                journal.SaveJournal("journal.csv");
            }
            else if (choice == "5")
            {
                journal.LoadJournal("journal.csv");
            }
            else if (choice == "6")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}