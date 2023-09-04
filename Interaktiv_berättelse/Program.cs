// See https://aka.ms/new-console-template for more information
Console.WriteLine("What do you want to be called?");
String name = Console.ReadLine();
Console.WriteLine($"Welcome to the game {name}!");
Thread.Sleep(1000);
// Start info
Console.WriteLine("Answer a, b or c to take different paths in the game.");
Thread.Sleep(1000);
Console.WriteLine("Keep in mind that there are X possible endings..."); 
Thread.Sleep(1000);
Console.WriteLine("...and perhaps a few secret ones as well");
// game start :)
Console.WriteLine("Well then, are you ready to start the adventure?");
Thread.Sleep(500);
Console.WriteLine("Write yes or no");
String start = Console.ReadLine();
