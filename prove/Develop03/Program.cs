using System;

class Program
{
    static void Main(string[] args)
{
    List<Scripture> library = new List<Scripture>();

    library.Add(new Scripture(
        new Reference("John", 3, 16),
        "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
    ));

    library.Add(new Scripture(
        new Reference("Proverbs", 3, 5, 6),
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
    ));

    library.Add(new Scripture(
        new Reference("Mosiah", 2, 17),
        "When ye are in the service of your fellow beings ye are only in the service of your God."
    ));
    
    library.Add(new Scripture(
        new Reference("1 Nephi", 3, 7),
        "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
    ));

    library.Add(new Scripture(
        new Reference("Moses", 7, 18),
        "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them."
    ));
    
    library.Add(new Scripture(
        new Reference("D&C", 1, 37, 38),
        "Search these commandments, for they are true and faithful, and the prophecies and promises which are in them shall all be fulfilled. What I the Lord have spoken, I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same."
    ));

    library.Add(new Scripture(
        new Reference("D&C", 8, 2, 3),
        "Yea, behold, I will tell you in your mind and in your heart, by the Holy Ghost, which shall come upon you and which shall dwell in your heart. Now, behold, this is the spirit of revelation; behold, this is the spirit by which Moses brought the children of Israel through the Red Sea on dry ground."
    ));

    library.Add(new Scripture(
        new Reference("Matthew", 25, 40),
        "And the King shall answer and say unto them, Verily I say unto you, Inasmuch as ye have done it unto one of the least of these my brethren, ye have done it unto me."
    ));

    library.Add(new Scripture(
        new Reference("Mosiah", 4, 30),
        "But this much I can tell you, that if ye do not watch yourselves, and your thoughts, and your words, and your deeds, and observe the commandments of God, and continue in the faith of what ye have heard concerning the coming of our Lord, even unto the end of your lives, ye must perish. And now, O man, remember, and perish not."
    ));

    library.Add(new Scripture(
        new Reference("Alma", 32, 21),
        "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."
    ));

    Random rand = new Random();
    int randomIndex = rand.Next(library.Count);
    Scripture chosenScripture = library[randomIndex];

    while (true)
    {
        Console.Clear();
        Console.WriteLine(chosenScripture.GetRenderedText());
        Console.WriteLine("\nPress Enter to hide words or type 'q' to exit:");
        string input = Console.ReadLine();

        if (input.ToLower() == "q")
            break;

        chosenScripture.HideWords();

        if (chosenScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(chosenScripture.GetRenderedText());
            Console.WriteLine("\nAll words are hidden! Program ending..."); 
            break;
        }
    }
}

}