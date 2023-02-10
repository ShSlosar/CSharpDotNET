public class Program
{
    private static void Main(string[] args)
    {
        //Loops:
        int start = 0;
        int end =5;
        for (int i=1; i<=5; i++){
            Console.WriteLine($"Hello, World {i}!");
        }
        for (int i=start; i<=end; i++){
            Console.WriteLine($"Jello, World {i}!");
        }
        int n = 1;
        while (n < 6){
            Console.WriteLine(n);
            n = n + 1;
        }
        //Random Values:
        Random rand = new Random();
        for(int val = 0; val <10; val++){
            Console.WriteLine($"Hello, {rand.Next(2,8)}!");
        }
    }
}