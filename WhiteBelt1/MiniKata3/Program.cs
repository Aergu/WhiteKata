namespace MiniKata3;

class Program


{
    static void Main(string[] args)
    {
        Random randomizedPlayerLuck = new Random();
        int playerLuck = randomizedPlayerLuck.Next(1, 11);
        string input = ""; 
        
        Console.WriteLine("You encounter an enemy! Do you want to attempt an attack? (yes/no)");
        input = Console.ReadLine();
        if (input.ToLower() == "yes")
        {
            if (playerLuck > 5)
            {
                Console.WriteLine("The attack was successful!");
            }

            if (playerLuck == 3 || playerLuck == 4  || playerLuck == 5)
            {
                Console.WriteLine("The attack barely succeeded!");
            }
            else if (playerLuck < 3)
            {
                Console.WriteLine("The attack missed!");
            }
        }
        else if (input.ToLower() == "no")
        {
            Console.WriteLine("The player retreated!");
        }
        {
            
        }
    }
}