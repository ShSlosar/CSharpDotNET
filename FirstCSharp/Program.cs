internal class Program
{
    private static void Main(string[] args)
    {
        string greeting = "how are you doing today?";
        string place = "Sarah";
        int age = 27;
        int numRings = 5;
        bool blueEyed = true;
        string message = $"hello {place}, {greeting}, you are {age}, and it is {blueEyed} that you have blue eyes.";
        Console.WriteLine(message);
        if (numRings >= 5){
            Console.WriteLine($"Welcome to the party {place}!");
        }
        else{
            Console.WriteLine($"Sorry, {place}, you need more rings to get in!");
        }
    }
}