// See https://aka.ms/new-console-template for more information
Console.WriteLine("What do you want to be called?");
String name = Console.ReadLine();
Console.WriteLine($"Welcome to the game {name}!");
Thread.Sleep(1000);
// Start info
Console.WriteLine("Type in a, b or c to make your choices in the game.");
Thread.Sleep(1000);
Console.WriteLine("Keep in mind that there are X possible endings..."); 
Thread.Sleep(1000);
Console.WriteLine("...and perhaps a few secret ones as well");
Thread.Sleep(1500);
// game start :)
Console.WriteLine("Well then, are you ready to start the adventure?");
Thread.Sleep(600);
Console.WriteLine("Write yes or no");
String start = Console.ReadLine().ToLower();

if (start == "no")
{
Thread.Sleep(1000);
Console.Write(".");
Thread.Sleep(700);
Console.Write(".");
Thread.Sleep(700);
Console.Write(".");
Thread.Sleep(1500);
Console.Write("oh.");
Thread.Sleep(1500);
Console.WriteLine("Well");
Thread.Sleep(1000);
Console.WriteLine("Game over then, I guess??");
}
else if (start == "yes")
{
Console.WriteLine("Let's begin!");
Thread.Sleep(1000);
}


Console.ReadLine();
// if (start != "no" || start == "NO")
// {
//     Console.WriteLine("ghasdujiflknrhPJDSL");
// }