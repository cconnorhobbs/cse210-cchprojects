using System;

class Program
{
    static void Main(string[] args)
{
    Reference reference = new Reference("John", 3, 16);
    Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his only begotten Son");

    while (true)
    {
        Console.Clear();
        Console.WriteLine(scripture.GetRenderedText());
        Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
        string input = Console.ReadLine();

        if (input.ToLower() == "quit")
            break;

        scripture.HideWords();

        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("\nAll words are hidden! Program ending...");
            break;
        }
    }
}

}