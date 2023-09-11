﻿// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Security.Cryptography.X509Certificates;
Console.WriteLine("What do you want to be called?");
String name = Console.ReadLine().ToLower();
if (name == "micke")
{
    Console.WriteLine("Automatic game over. Try again with a different name.");
}
else
{
Console.WriteLine($"Welcome to the game {name}!");
Thread.Sleep(1000);
// Start info
Console.WriteLine("Type in a, b or c to make your choices in the game.");
Thread.Sleep(1000);
Console.WriteLine("Keep in mind that there are 5 possible endings...");
Thread.Sleep(1000);
Console.WriteLine("...and 2 secret ones as well.");
Thread.Sleep(1000);
// game start :)
Console.WriteLine("Well then, are you ready to start the adventure?");
Console.WriteLine("Write yes or no");
string start = Console.ReadLine().ToLower();

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
    Console.ReadLine();
    Console.WriteLine("Well");
    Console.ReadLine();
    Console.WriteLine("Game over then, I guess??");
    Console.ReadLine();

}
else if (start == "yes")
    {
    Console.WriteLine("Let's begin!");
    Console.ReadLine();
    Console.WriteLine("You wake up in a dark room with no windows. It's cold and wet and you feel as if you haven't eaten in days. You can't remember a thing.");
    Console.ReadLine();
    Console.WriteLine($"From the other side of the wall you can hear something shouting. You don't know what it is or what it's saying. The only words you can make out is '{name}' and 'gone'. People? Maybe. Maybe they can help you? In the roof of the room you see a little hole where sunlight seems to be seeping in. Maybe it's a trap door? Maybe it leads outside?");
    Console.ReadLine();
    Console.WriteLine("What do you do?");
    Console.WriteLine("Type A to try to call out to the voice or B to try escaping throuhg the trap door in the roof");
    string first = Console.ReadLine().ToLower();

    if (first == "a")
    // goblin army finds you
    {
        Thread.Sleep(1500);
        Console.WriteLine("You yell as loud as you can to get its attention. You can hear the noise on the outside stopping abruptly before someone, or rather a bunch of someones starts loudly stomping closer to you.");
        Console.ReadLine();
        Console.WriteLine("Suddelny the wall breaks down and you see an army of small green mean looking people staring at you from the outside.");
        Console.ReadLine();
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.WriteLine("Right.");
        Console.ReadLine();
        Console.WriteLine("Everything starts coming back to you now. You we're hiding from these people. That's why you locked yourself in there in the first place.");
        Console.ReadLine();
        Console.WriteLine("The goblins, because that's what they are, stare at you grinning at your stupidity.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("How do you get yourself out of this situation?");
        Console.WriteLine("Type A to faint from the fear of it all, B to attack the goblin army, or C to turn around and try escaping through the trap door in the roof instead");
        string firstA = Console.ReadLine().ToLower();

        if (firstA == "a")
        // faint
        {
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.WriteLine("Well that was stupid.");
            Console.ReadLine();
            Console.WriteLine("Everything goes black as you faint. The goblins laugh at you and call you pathetic.");
            Console.ReadLine();
            Console.WriteLine("When you wake up again you fin yourself hanging over a campfire surrounded by goblins pointing and laughing at you.");
            Console.ReadLine();
            Console.WriteLine("Congratulations. You just became dinner.");
            Console.WriteLine("Game over. lol");
        }
        else if (firstA == "b")
        // attack
        {
            Thread.Sleep(1000);
            Console.WriteLine("Really?");
            Console.ReadLine();
            Console.WriteLine("Really??????");
            Console.ReadLine();
            Console.WriteLine("You, a small, fragile, starving human is goign to attack a literal army of armed goblins?????");
            Console.ReadLine();
            // lägg till så att man kan ångra sig här
            Console.WriteLine("Well then, suit yourself.");
            Console.WriteLine("You charge forward with a mighty roar, it actually comes out more as an eek but we'll pretend it was intimidating.");
            Console.ReadLine();
            Console.WriteLine("The goblins, shocked, freeze in their tracks as you charge forward, bulldozing through like a bowling ball.");
            Console.ReadLine();
            Console.WriteLine("They stare at you in awe. They were planning on making you into a stew but how could they possibly eat such a strong and wonderous creature, with such a mighty roar.");
            Console.ReadLine();
            Console.WriteLine("To your surprise, and mine, they bring you to their camp and crown you chiefton of the goblin village.");
            Console.ReadLine();
            Console.WriteLine("Congratulations, for real. How incredible! You're alive! Well, at least for now you are.");
            Console.WriteLine("The end. You won!");
        }
        else if (firstA == "c")
        // run
        {
            Thread.Sleep(1000);
            Console.WriteLine("You spin around and quickly start fiddling with the handles.");
            Console.ReadLine();
            Console.WriteLine("The goblins stare at you in disbelief. As you tinker with the lock less than 3 meters away from them.");
            Console.ReadLine();
            Console.WriteLine("They are so dissapointed in your attempt to escape that they don't even try to stop you. You could've at least tried to fight them. They continue watching, mouths agape, as you clumsily climp up through the trapdoor and out.");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Congrats, you won. Though it wasn't as action filled as we'd hoped I suppose it still counts...");

        }
    }

    else if (first == "b")
    // trapdoor route
    {
        Thread.Sleep(1000);
        Console.WriteLine("You stand up to go inspect the trap door.");
        Console.ReadLine();
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write("It's locked.");
        Console.ReadLine();
        Console.WriteLine("The lock looks old and rusty. Whoever decided to put that there must be stupid, you think to youself, a child could probably break open that lock, the condition that it's in.");
        Console.ReadLine();
        Console.Write("You try to pull it open.");
        Thread.Sleep(1000);
        Console.Write(" It's stuck.");
        Console.ReadLine();
        Console.WriteLine("You try again, a little harder this time, and the door swings open.");
        Console.WriteLine("");
        Console.WriteLine("Type A to duck out of the way or B to just stand still like an idiot.");
        string firstB = Console.ReadLine().ToLower();

        if (firstB == "a")
        {
            Thread.Sleep(1000);
            Console.WriteLine("You swiftly duck out of the way as the door swings open.");
            Console.ReadLine();
            Console.WriteLine("Nice.");
            Console.ReadLine();
            Console.WriteLine("You jump up and pull yourself out of the room and into freedom.");
            Console.ReadLine();
            Console.WriteLine("A group of bald green creatures stare at you from the ground below.");
            Console.ReadLine();
            Console.WriteLine("You wave at them happily before you run off into the sunset.");
            Console.ReadLine();
            Console.WriteLine("Yay! You did it! You won.");
        }

        if (firstB == "b")
        {
            Thread.Sleep(1000);
            Console.WriteLine("You stare blankly as the door swings open right towards your head in what seems like slow motion.");
            Console.ReadLine();
            Console.WriteLine("And then everything goes black.");
            Console.ReadLine();
            Console.WriteLine("Well. That was that. You died. Game over.");
        }
    }

}
else
{
    Console.WriteLine("Since you didn't follow the instructions I'm giving you a short cut to the end.");
    Console.ReadLine();
    Console.WriteLine("That means I'm giving you a game over. For free. You haven't even started the game and you already lost. Good job.");
    Console.ReadLine();
    Console.WriteLine("Try again if you feel like it. Or don't. It's up to you.");
}
}
Console.ReadLine();
// if (start != "no" || start == "NO")
// {
//     Console.WriteLine("ghasdujiflknrhPJDSL");
// }