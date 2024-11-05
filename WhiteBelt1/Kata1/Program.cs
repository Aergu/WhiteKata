namespace Kata1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome, brave adventurer! What is your name?");
        string nameinput = Console.ReadLine();
        Console.WriteLine($"Greetings {nameinput}! Your journey begins now...");
        Console.WriteLine("On a scale of 1 to 10, how excited are you to start this quest?");
        int excitedinput = int.Parse(Console.ReadLine());

        if (excitedinput > 7)
        {
            Console.WriteLine("Fantastic! You seem ready to take on any challenge!");
            
        }
        else
        {
            Console.WriteLine("Chin up! You can do it!");
        }
    }
}