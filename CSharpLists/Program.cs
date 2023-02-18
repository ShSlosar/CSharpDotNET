using System.Collections.Generic;
Console.WriteLine("Hello, World!");
List<string> bikes = new List<string>();
bikes.Add("kawasaki");
bikes.Add("Schwinn");
bikes.Add("Huffy");
bikes.Add("Diamond Back");
bikes.Add("Murray");

Console.WriteLine($"There are {bikes.Count} bikes on the list. The first bike on the list is {bikes[0]}.");
Console.WriteLine("The bike manufacturers in the list are:");
for (var idx = 0; idx < bikes.Count; idx++){
    Console.WriteLine("-" + bikes[idx]);
}
bikes.Insert(2, "Yamaha");
Console.WriteLine("The updated list is :");
foreach(string manu in bikes){
    Console.WriteLine("-"+ manu);
}