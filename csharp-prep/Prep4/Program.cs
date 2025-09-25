using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> number_list = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                number_list.Add(number);
            }
        }

        int sum = 0;
        foreach (int n in number_list)
        {
            sum = sum + n;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = sum / number_list.Count;

        Console.WriteLine($"The average is: {average}");

        int highest_number = 0;
        foreach (int n in number_list)
        {
            if (n > highest_number)
            {
                highest_number = n;
            }
        }

        Console.WriteLine($"The highest number is: {highest_number}");


            
        
        
        

    }
}