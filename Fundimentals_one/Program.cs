// See https://aka.ms/new-console-template for more information
int num = 1;
Console.WriteLine($"{num} Hello, World!");

//1-255
for (int i=1; i<=255; i++){
    Console.WriteLine(i);
}

//1-100 (3/5 divisible)
for (int n=1; n<=100; n++){
    
    if(n % 5 == 0){
        if(n % 3 == 0){
        Console.WriteLine($"1-100:");
    }
        else{
        Console.WriteLine($"1-100(%5): {n}");
        }
    }
    if(n % 3 == 0){
        if(n % 5 == 0 ){
        Console.WriteLine($"1-100:");
    }
        else{
        Console.WriteLine($"1-100(%3): {n}");
    }
    }
    

}

//FizzBuzz
for (int n=1; n<=100; n++){
    
    if(n % 5 == 0){
        if(n % 3 == 0){
        Console.WriteLine($"FizzBuzz");
    }
        else{
            Console.WriteLine($"Buzz");
        }
    }
    if(n % 3 == 0){
        if(n % 5 == 0 ){
        Console.WriteLine($"FizzBuzz");
    }
        else{
            Console.WriteLine($"Fizz");
            }
    }
    

}
