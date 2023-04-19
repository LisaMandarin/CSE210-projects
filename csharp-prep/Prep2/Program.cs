using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");

        //Convert the grade percentage to integer
        string gradePercentage = Console.ReadLine();
        int number = int.Parse(gradePercentage);

        //Turn into the grade letter according the user's input
        string letter;
        string sign;

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >=80)
        {
            letter = "B";
        }
        else if (number >=70)
        {
            letter = "C";
        }
        else if (number >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Add + or - next to the grade
        if (number >=93 || number <60)
        {
            sign = "";
        }
        else if (number % 10 >= 7)
        {
            sign = "+";
        }
        else if (number % 10 <3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"You've got a(n) {letter}{sign}.");

        //Tell the user if he has passed
        if (number >= 70)
        {
            Console.WriteLine("Congratulations.  You have passed.");
        }
        else
        {
            Console.WriteLine("Sorry, You didn't pass.  Try harder and you'll pass.");
        }
    }
}