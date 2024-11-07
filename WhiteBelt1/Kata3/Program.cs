namespace Kata3;

class Program
{
    static void Main(string[] args)
    {
        Random randomizedPlayerLuck = new Random();
        int playerLuck = randomizedPlayerLuck.Next(1, 11);
        string input = "";
        
        Console.WriteLine("You've found a mysterious treasure chest! What will you do?");
        Console.WriteLine("1. Open the chest");
        Console.WriteLine("2. Ignore the chest");
        Console.WriteLine("3. Leave the area");
        input = Console.ReadLine();
        if (input.ToLower() == "open" || input.ToLower() == "1")
        {
            if (playerLuck > 9)
            {
                Console.WriteLine("Wonderful! The chest contains a mythical gem!");
            }
            else if (playerLuck >= 7)
            {
                Console.WriteLine("Great success! The chest contained a rare gem!");
            }
            else if (playerLuck >= 2)
            {
                Console.WriteLine("Success! The chest contained a common gem.");
            }
            else 
            {
                Console.WriteLine("Unfortunately, there is no treasure in the chest....");
            }
        }

        if (input.ToLower() == "ignore" ||
            input.ToLower() == "2" ||
            input.ToLower() == "leave" ||
            input.ToLower() == "3")
        {
            Console.WriteLine("The traveler departs, not knowing what is in the chest...");
        }
    }
}