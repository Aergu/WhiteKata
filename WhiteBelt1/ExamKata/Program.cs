namespace ExamKata;

class Program
{
    static void Main(string[] args)
    {
        int heroHealth = 80;
        int heroDamageDealt = 15;
        int heroAmountHealed = 20;
        int goblinHealth = 50;
        int goblinDamageDealt = 10;
        string input = "";

        while (true) // Becomes an infinite loop
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            input = Console.ReadLine();
            if (input.ToLower() == "1" || input.ToLower() == "attack")
            {
                Console.WriteLine("Hero attacks the Goblin!");
                Console.WriteLine($"Goblin takes {heroDamageDealt} damage.");
                goblinHealth = goblinHealth - heroDamageDealt;
                if (goblinHealth <= 0)
                {
                Console.WriteLine("Congrats! Hero has defeated the Goblin!");
                    break;
                }
                Console.WriteLine($"Goblin has {goblinHealth} health left.");
                Console.WriteLine("Goblin attacks Hero!");
                Console.WriteLine($"Hero takes {goblinDamageDealt} damage.");
                heroHealth = heroHealth - goblinDamageDealt;
                if (heroHealth <= 0)
                {
                    Console.WriteLine("Game Over! Try again!");
                    break;
                }
                Console.WriteLine($"Hero has {heroHealth} health left.");
                
            }
            else if (input.ToLower() == "2" || input.ToLower() == "heal")
            {
                heroHealth = heroHealth + heroAmountHealed;
                Console.WriteLine($"Hero healed themself for {heroAmountHealed} health!");
                Console.WriteLine($"Hero has {heroHealth} health left.");
                
            }
        }
    }
}
