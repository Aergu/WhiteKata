namespace MiniKata2;

class Program
{
    static void Main(string[] args)
    {
        string name = "Jack";
        int healthpoints = 100;
        float attackpower = 15.5f;
        double exppoints = 250.234;
        bool isParalyzed = true;
        string goldCoins = "150,1";

        double doubleNumber = healthpoints; // Automatically converted the int in healthpoints to double.
        float floatNumber = (int)attackpower; // Explicitly converts float to int.
        int convertedExpPoints = Convert.ToInt32(exppoints);

        if (int.TryParse(goldCoins, out int result))
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("The parse is invalid!");
        }

        Console.WriteLine($"{name}");
        Console.WriteLine($"{doubleNumber}");
        Console.WriteLine($"{floatNumber}");
        Console.WriteLine($"{convertedExpPoints}");
                          
    }
}