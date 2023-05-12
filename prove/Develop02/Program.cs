using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int choice = -1;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                int option = 2;
                while (option == 2)
                {
                    Entry entry = new Entry();
                    PromptGenerator prompt = new PromptGenerator();
                    entry._prompt= prompt.Generate();
                    Console.WriteLine(entry._prompt);
                    
                    Console.Write("Press 1 to answer.  Press 2 to regenerate the prompt. ");
                    
                    option = int.Parse(Console.ReadLine());
                    if (option == 2)
                    {
                        continue;
                    }
                    entry._response = Console.ReadLine();
                    journal.AddEntry(entry);
                }
                
                
                // entry._response = Console.ReadLine();
                
                // journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.Display();
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                if (!File.Exists(filename))
                {
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        foreach (Entry entry in journal._entires)
                        {
                            outputFile.WriteLine(entry._prompt);
                            outputFile.WriteLine(entry._response);
                        }
                    }
                }
                else if (File.Exists(filename))
                {
                    using (StreamWriter outputFile = new StreamWriter(filename, true))
                    {
                        foreach (Entry entry in journal._entires)
                        {
                            outputFile.WriteLine(entry._prompt);
                            outputFile.WriteLine(entry._response);
                        }
                    }
                }
                
            }
            else if (choice == 5)
            {
                break;
            }
        }
    }
}
