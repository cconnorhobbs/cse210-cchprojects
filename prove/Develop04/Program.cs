using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            DisplayMenu();
            string input = GetUserInput().Trim();

            switch (input)
            {
                case "1":
                    var breathing = new Breathing();
                    breathing.StartActivity();
                    break;
                case "2":
                    var reflection = new Reflection();
                    reflection.StartActivity();
                    break;
                case "3":
                    var listing = new Listing();
                    listing.StartActivity();
                    break;
                case "4":
                    var visualization = new Visualization();
                    visualization.StartActivity();
                    break;
                case "5":
                    keepRunning = false;
                    Console.WriteLine("Goodbye — thanks for using the activities program. Press Enter to exit.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }
    public static void DisplayMenu()
    {
        Console.WriteLine("======================================");
        Console.WriteLine("         Mindfulness Activities       ");
        Console.WriteLine("======================================");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflection Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Start Visualization Activity");
        Console.WriteLine("5. Quit");
        Console.WriteLine("======================================");
    }

    public static string GetUserInput()
    {
        Console.Write("Select your choice: ");
        return Console.ReadLine() ?? "";
    }
}
