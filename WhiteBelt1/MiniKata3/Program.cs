namespace MiniKata3;

class Program


{
    static void Main(string[] args)
    {
        int playerLuck = 6;
        string input = ""; // Necessary variables
        
        Console.WriteLine("You encounter an enemy! Do you want to attempt an attack? (yes/no)");
        input = Console.ReadLine();
        if (input.ToLower() == "yes")
        {
            if (playerLuck > 7)
            {
                Console.WriteLine("The attack was successful!");
            }

            if (playerLuck == 6 || playerLuck == 7)
            {
                Console.WriteLine("The attack barely succeeded!");
            }
            else
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