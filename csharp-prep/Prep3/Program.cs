using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random number
        Random randomNumber = new Random();
        
        //Set the range from 1 to 100 
        int numberMagic = randomNumber.Next(1,101);
        int numberGuess = -1;
        int attempt = 0;
        string response = "yes";
        while (response == "yes")
        {
            do
            {
                attempt++;
                Console.Write("What is your guess? ");
                numberGuess = int.Parse(Console.ReadLine());
                if (numberGuess == numberMagic)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (numberGuess < numberMagic)
                {
                    Console.WriteLine("Higher");
                }
                else if (numberGuess > numberMagic)
                {
                    Console.WriteLine("Lower");
                }
            }
            while (numberGuess != numberMagic);
            Console.WriteLine($"You have made {attempt} guesses!!");
            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();
        }

    }
}
        