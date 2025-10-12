using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    class Program
    {
        static List<Entry> journal = new List<Entry>();
        static PromptGenerator promptGenerator = new PromptGenerator();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nJournal Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display journal");
                Console.WriteLine("3. Save journal to file");
                Console.WriteLine("4. Load journal from file");
                Console.WriteLine("5. Quit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEntry();
                        break;
                    case "2":
                        DisplayEntries();
                        break;
                    case "3":
                        SaveToFile();
                        break;
                    case "4":
                        LoadFromFile();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again!");
                        break;
                }
            }
        }

        static void AddEntry()
        {
            Entry entry = new Entry();

            entry._date = DateTime.Now.ToShortDateString();
            entry._prompt = promptGenerator.GetRandomPrompt();

            Console.WriteLine($"\nPrompt: {entry._prompt}");
            Console.Write("Your response: ");
            entry._response = Console.ReadLine();

            journal.Add(entry);
            Console.WriteLine("Entry added!");
        }

        static void DisplayEntries()
        {
            Console.WriteLine("\nYour Journal Entries:");
            foreach (Entry e in journal)
            {
                Console.WriteLine($"Date: {e._date}");
                Console.WriteLine($"Prompt: {e._prompt}");
                Console.WriteLine($"Response: {e._response}");
                Console.WriteLine("--------------------------");
            }
        }

        static void SaveToFile()
        {
            Console.Write("Enter filename to save as: ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry e in journal)
                {
                    outputFile.WriteLine($"{e._date}|{e._prompt}|{e._response}");
                }
            }

            Console.WriteLine("Journal saved successfully!");
        }

        static void LoadFromFile()
        {
            Console.Write("Enter filename to load: ");
            string filename = Console.ReadLine();

            if (File.Exists(filename))
            {
                journal.Clear();
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _prompt = parts[1],
                        _response = parts[2]
                    };
                    journal.Add(entry);
                }

                Console.WriteLine("Journal loaded successfully!");
            }
            else
            {
                Console.WriteLine("File not found!");
            }
        }
    }
}
