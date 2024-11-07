namespace MiniKata4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Spawning enemies using a for loop:");
        for (int i = 1; i < 6; i++)
        {
        Console.WriteLine($"Enemy #{i} spawned!");
        }
        Console.WriteLine("Spawning enemies using a while loop:");
        int maxEnemies = 3;
        int enemiesSpawned = 0;
        while (enemiesSpawned < maxEnemies)
        {
            enemiesSpawned++;
            Console.WriteLine($"Enemy #{enemiesSpawned} spawned!");
        }
    }
}