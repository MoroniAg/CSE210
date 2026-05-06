using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        var numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int value = int.Parse(input);

            if (value == 0)
            {
                break;
            }

            numbers.Add(value);
        }

        int sum = numbers.Sum();
        int max = numbers.Max();
        
        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {(numbers.Count > 0 ? max.ToString() : "N/A")}");
        
        Console.WriteLine($"The Sorted List is: ");
        numbers.Sort();
        numbers.ForEach(n=> Console.WriteLine(n));
    }
}