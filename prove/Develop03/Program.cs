using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(new Scripture(new Reference("John",3,16,17), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.  For God sent not his Son into the world to condemn the world; but that the world through him might be saved."));
        scriptures.Add(new Scripture(new Reference("Helaman",14,30), "And now remember, remember, my brethren, that whosoever perisheth, perisheth unto ahimself; and whosoever doeth iniquity, doeth it unto himself; for behold, ye are bfree; ye are permitted to act for yourselves; for behold, God hath given unto you a cknowledge and he hath made you free."));
        scriptures.Add(new Scripture(new Reference("Doctrine and Covenants", 88, 119), "Organize yourselves; prepare every needful thing; and establish a bhouse, even a house of prayer, a house of fasting, a house of faith, a house of learning, a house of glory, a house of order, a house of God"));
        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);
        Scripture randomScripture = scriptures[randomIndex];

        while (!randomScripture.IsCompletelyHidden())
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(randomScripture.GetRenderedText());
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Press enter to continue or type 'quit' to exit: ");
            string answer = Console.ReadLine();
            if (answer == "quit")
            {
                break;
            }
            randomScripture.HideWords();
        }
        Console.WriteLine("Game over! ");

                



    }
}