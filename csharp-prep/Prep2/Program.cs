using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade?");
        string letter = Console.ReadLine();
        int number = int.Parse(letter);

        string grade = "";
        if (int.Parse(letter) >= 100)
        {
            Console.WriteLine("You cannot have more than 100%");
        }
        else if (int.Parse(letter) >= 93 && int.Parse(letter) <= 100)
        {
            grade = "A";
            Console.WriteLine($"Your grade is an {grade}");
        }
        else if (int.Parse(letter) >= 90 && int.Parse(letter) <= 93)
        {
            grade = "A-";
            Console.WriteLine($"Your grade is an {grade}");
        }

        else if (int.Parse(letter) >= 87 && int.Parse(letter) <= 90)
        {
            grade = "B+";
            Console.WriteLine($"Your grade is an {grade}");
        }

        else if (int.Parse(letter) >= 83 && int.Parse(letter) <= 87)
        {
            grade = "B";
            Console.WriteLine($"Your grade is an {grade}");
        }
        else if (int.Parse(letter) >= 80 && int.Parse(letter) <= 83)
        {
            grade = "B-";
            Console.WriteLine($"Your grade is an {grade}");
        }
        else if (int.Parse(letter) >= 77 && int.Parse(letter) <= 80)
        {
            grade = "C+";
            Console.WriteLine($"Your grade is an {grade}");
        }
        else if (int.Parse(letter) >= 73 && int.Parse(letter) <= 77)
        {
            grade = "C";
            Console.WriteLine($"Your grade is an {grade}");
        }
        else if (int.Parse(letter) >= 70 && int.Parse(letter) <= 73)
        {
            grade = "C-";
            Console.WriteLine($"Your grade is an {grade}");
        }
        else if (int.Parse(letter) >= 67 && int.Parse(letter) <= 70)
        {
            grade = "D+";
            Console.WriteLine($"Your grade is an {grade}");
        }
        else if (int.Parse(letter) >= 63 && int.Parse(letter) <= 67)
        {
            grade = "D";
            Console.WriteLine($"Your grade is an {grade}");
        }
        else if (int.Parse(letter) >= 60 && int.Parse(letter) <= 63)
        {
            grade = "D-";
            Console.WriteLine($"Your grade is an {grade}");
        }
        else if (int.Parse(letter) < 60)
        {
            grade = "F";
            Console.WriteLine($"Your grade is an {grade}");
        }

        if (int.Parse(letter) >= 70)
        {
            Console.WriteLine("Congradulations, you passed!");
        }
        else if (int.Parse(letter) <= 69)
        {
            Console.WriteLine("You did not pass, womp womp.");
        }
        else if (int.Parse(letter) <= 49)
        {
            Console.WriteLine("Geez! You really need to study more!");
        }
    }
}