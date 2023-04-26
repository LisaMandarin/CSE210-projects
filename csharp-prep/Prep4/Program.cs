using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        float number = -1;
        List<float> numbers = new List<float>();
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = float.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        float sum = 0;
        float largest = numbers[0];
        float smallPositive = numbers[0];
        foreach (float item in numbers)
        {
            sum += item;
            if (item > largest)
            {
                largest = item;
            }
            if (item > 0 && item < smallPositive)
            {
                smallPositive = item;
            }
        }
        int size = numbers.Count;
        float average = sum / size;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallPositive}");
        numbers.Sort();
        Console.WriteLine($"The sorted list is:");
        foreach (float i in numbers)
        {
            Console.WriteLine(i);
        }
        
    }
}