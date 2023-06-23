public class Reward
{
    private List<string>facts;
    public Reward()
    {
        facts = new List<string>();
        facts.Add("Asia is the largest continent on earth. This also means it has the largest population with over 4.46 billion people!");
        facts.Add("Some fish cough. In order to clear the particles and bacteria out of their gills, the fish’s ventilation cycle is interrupted with a cough.");
        facts.Add("Elephants are the only animal that can’t jump.");
        facts.Add("About 75% of your brain is made of water.");
        facts.Add("It takes about 50 licks to finish just one scoop of ice cream.");
        facts.Add("Ketchup used to be sold as medicine. That’s right; the popular condiment was once thought to be a cure for indigestion.");
        facts.Add("The brain is actually not capable of multitasking. While we may think we’re doing two things at the same time, we’re actually just quickly switching back and forth between different tasks.");
        facts.Add("Your nose gets warmer when you lie.");
        facts.Add("North Korea and Cuba are the only places in the world you can’t buy Coca Cola.");
        facts.Add("It’s impossible to sneeze with your eyes open.");

    }
    public void GetFact(int score)
    {
        if (score >= 100 && score <200)
        {
            Console.WriteLine(facts[0]); 
        }
        else if (score >= 200 && score < 400)
        {
            Console.WriteLine(facts[1]);
        }
        else if (score >= 400 && score < 600)
        {
            Console.WriteLine(facts[2]);
        }
        else if (score >= 600 && score < 900)
        {
            Console.WriteLine(facts[3]);
        }
        else if (score >= 900 && score < 1100)
        {
            Console.WriteLine(facts[4]);
        }
        else if (score >= 1100 && score < 1400)
        {
            Console.WriteLine(facts[5]);
        }
        else if (score >= 1400 && score < 1800)
        {
            Console.WriteLine(facts[6]);
        }
        else if (score >= 1800 && score < 2200)
        {
            Console.WriteLine(facts[7]);
        }
        else if (score >= 2200 && score < 2600)
        {
            Console.WriteLine(facts[8]);
        }
        else
        {
            Console.WriteLine("You need to score at least 100 to learn a fact.  The maximum score is 2600.");
        }
        
    }    

}