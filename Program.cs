// See https://aka.ms/new-console-template for more information
// Starting the player out in a room
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;

Console.WriteLine("You wake up in a room the only thing you can see is a door with a golden handle, what do you do?");
// Give the player the choice
Console.WriteLine("Do you");
Console.WriteLine("A:Try to open the door");
Console.WriteLine("B:Look around");
// The Meat and Potaoes of the code
string input = Console.ReadLine();
if (input == "A")
{
    Console.WriteLine("You wiggle the door handle for a bit but it does nothing.  You think to yourself that the door must be locked");
    Console.WriteLine("What do you do?");
    Console.WriteLine("A: Cry");
    Console.WriteLine("B: Look Around for something");
    string _ = Console.ReadLine();
    if (_ == "A")
    { //This took TO GODDAMN LONG TO CODE I'M GOING TO BED I'LL FINISH THE "A" ROUTE IN TOMORROW (this was writen on September 12 at 9:30pm)  
        Console.WriteLine("You cry your eyes out like the little baby you are then pass out from exaustion GAME OVER (press ENTER to restart the game)");


    }
    else if (_ == "B")
    { Console.WriteLine("You begin to look around the room and find a desk drawer, it looks like the drawer has no lock on it so you should be able to open it easily, what do you do?");
        Console.WriteLine("A:Open the first drawer");
        Console.WriteLine("B:Open the second drawer");
    } string a = Console.ReadLine();
    if (a == "A")
    {
        Console.WriteLine("You open the first drawer and find a pair of mismatched socks and a golden key, you decide to take the key what do you do now?");
        Console.WriteLine("A:Try to open the door with the key");
        Console.WriteLine("B:Look through the second drawer");
    }
    string b = Console.ReadLine();
    if (b =="A")
    {
        Console.WriteLine("You put the golden key into the doors keyhole and turn the doorknob the lock makes a click sound and the door opens to reveal another room with two doors, what do you do?");
    }
    Console.WriteLine("A:Go through the left door");
    Console.WriteLine("B:Go through the right door");
    string c = Console.ReadLine();
    if (c == "A")
    {
        Console.WriteLine("You open the left door and find a clear blue sky and a field of flowers the smell of fresh air wafts over you as you realize that your finally free (ENDING A:THE ESCAPE)(Press ENTER to restart the game and try to get ending B!");
    }
    else if (c == "B")
    {
       //The random zombie encounter was an idea given to me by my mother
        Console.WriteLine("You open the right door to find a random ass zombie encounter unfortunatlly this isn't an RPG so you can't fight it and you scream in horror as your slowly eaten alive by the zombie GAME OVER (Press ENTER to restart)");
    }

    else if (b == "B")
    {
        //This line will be used twice because of the same action being taken
        Console.WriteLine("You open the second drawer and trigger a trap that blows both your legs off GAME OVER (press ENTER to restart)");
    }
    else if (a == "B")
    {
        Console.WriteLine("You open the second drawer and trigger a trap that blows both your legs off GAME OVER (press ENTER to restart)");

    }
}
else if (input == "B")
{
    Console.WriteLine("You look around the room to find a dresser drawer with two drawers, what do you do?");
    Console.WriteLine("A:Open the first drawer");
    Console.WriteLine("B:open the second drawer");
}


    string d = Console.ReadLine();
if (d == "A")
{
    Console.WriteLine("You open the first drawer and trigger a trap that blows both your legs off GAME OVER (press ENTER to restart)");
    
}
else if (d == "B")
{
    Console.WriteLine("You open the second drawer and find a key that almost looks like the endless void of space it's warm to the touch, you decide to pocket it what do you do?");
}

string e = Console.ReadLine();
if(e == "A")
{
    Console.WriteLine("You put the void-like key into the keyhole the key is absorbed into the keyhole and the door turns into a portal that sucks you into it");
    Console.WriteLine("When you arrive on the other side of the portal it closes behind you and your left in a room with one door infront of you, what do you do");
}
else if (e == "B")
{
    Console.WriteLine("You open the first drawer and trigger a trap that blows both your legs off GAME OVER(press ENTER to restart)");
}
Console.WriteLine("A:Open the door");
Console.WriteLine("B:Think before you act");
string f = Console.ReadLine();
if (f == "A")
{
    Console.WriteLine("You open the door and find an almost empty computer lab with only one person inside typing away on a laptop it looks like their coding somthing, you try to speak to them but you find you have no voice, you look at their screen and find that they are typing out the exact same route you took to get here the thought of that drives you mad as you colapse into the floor writhing in pain (ENDING B: SELF AWARE MADNESS)(Press ENTER to restart to try and get ending A!)");
}
else if (f == "B")
{
    Console.WriteLine("You think about your options and you keep think for about an hour, what do you do now?");
}
Console.WriteLine("A:Go through the door");
Console.WriteLine("B:End the game");
string g = Console.ReadLine();
if (g == "A")
{
    Console.WriteLine("You open the door and enter the room and find a door and you open that door and you find another door and you open that door and you find another door and you open that door and you find another door and you open that door and you find another door and you open that door and you find another door and you open that door and you find another door and you open that door and you find another door and you open that door and you find another door and you open that door and you find another door and you open that door and you find another door and you open that door and you find another door and you open that door and you find another door this goes on for several more hours untill you pass out from exuastion GAME OVER Press ENTER to restart");
}
else if (g == "B")
{
    Console.WriteLine("You and the game developer agree that your finished with this project and you tell the developer to stop coding (ENDING C:I'M TRIED)(You got the secert ending thank you for playing! I'm gonna get some sleep)");
}
