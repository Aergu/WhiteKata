using Microsoft.CSharp.RuntimeBinder;

namespace MiniKata1;

class Program
{
    
    static void Main(string[] args)
    {
        string name = "Arin"; // Needs quotation marks to make a string. Ex: "".
        int healthpoints = 100;
        float attackpower = 15.5f;
        float exppoints = 250;
        bool isParalyzed = true;
        double goldCoins = 24.75;
        
        Console.WriteLine($"Character name: {name}\n" + // \n creates a line break that can be used for making lists.
                          $"Health Points: {healthpoints}\n" +
                          $"Attack Power: {attackpower}\n" +
                          $"Is Paralyzed: {isParalyzed}\n" +
                          $"Gold Coins: {goldCoins}\n");
    }
}