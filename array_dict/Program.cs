internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] numArray = new int[5];
        int[] arrayOfInts = {1,2,3,4,5};
        int[] arr = {1,2,3,4};
        Console.WriteLine($"index 1 of array is {arr[0]}.");
        arr[0] = 8;
        Console.WriteLine($"index 1 of array is {arr[0]}.");

        //foreach loop, string array
        string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"}; 
        foreach (string car in myCars){
            Console.WriteLine($"I own a {car}");
            }
    }
}