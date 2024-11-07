namespace Kata4;

class Program
{
    static void Main(string[] args)
    {
    int waves = 5;
        for (int wave = 1; wave <= waves; wave++)
        {
        Console.WriteLine($"Wave {wave} is starting!");
            int enemiesPerWave = 4;
            for (int enemy = 1; enemy <= enemiesPerWave; enemy++)
            {
                Console.WriteLine($"Enemy #{enemy} has spawned.");
                Thread.Sleep(1000);
            }
                Console.WriteLine($"Wave {wave} completed. Preparing for the next wave...");
        }
                Console.WriteLine("All waves completed! Victory is yours!");
    }
}