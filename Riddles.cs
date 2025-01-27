// allows for use of system namespaces like array, string, etc.
using System;

// initialize game status as active and will run while in the loop
bool game = true;

// display welcome message
Console.WriteLine("\nWelcome to Riddle Mania!");

// game loop
while (game)
{
    // Level 1 console logs
    Console.WriteLine("\nLevel 1: ");
    Console.WriteLine("What is the only color you can eat? ");
    // first input is a string, read line, ignore caps/lowecase
    string guessOne = Console.ReadLine().ToLower();

    // if else for answer functionality 
    if ("orange".Equals(guessOne))
    {
        Console.WriteLine("Congrats you passed Level 1!");
    }
    else
    {
        Console.WriteLine($"In what world can you eat the color {guessOne}?");
        Console.WriteLine("GAME OVER");
        break;
    }

    // Level 2
    Console.WriteLine("\nLevel 2: ");
    Console.WriteLine("What has many words but never speaks? ");
    string guessTwo = Console.ReadLine().ToLower();

    if (guessTwo.Contains("book"))
    {
        Console.WriteLine("Congrats you passed Level 2!");
    }
    else
    {
        Console.WriteLine($"I am sorry, {guessTwo} was not the right answer.");
        Console.WriteLine("GAME OVER");
        break;
    }

    // Level 3
    Console.WriteLine("\nLevel 3: ");
    Console.WriteLine("What must be broken before its used? ");
    string guessThree = Console.ReadLine().ToLower();

    if (guessThree.Contains("egg"))
    {
        Console.WriteLine("Congrats you passed Level 3!");
    }
    else
    {
        Console.WriteLine($"Oh no, {guessThree} was not the correct answer.");
        Console.WriteLine("GAME OVER");
        break;
    }

    // Level 4
    Console.WriteLine("\nLevel 4: ");
    Console.WriteLine("They come out in the night without being called and are lost in the day without being stolen. What are they? ");
    string guessFour = Console.ReadLine().ToLower();

    if (guessFour.Contains("star"))
    {
        Console.WriteLine("Congrats you passed Level 4!");
        Console.WriteLine("Victory is near!");
    }
    else
    {
        Console.WriteLine("So close to winning, but yet so far!");
        Console.WriteLine("GAME OVER");
        break;
    }

    // Final Level
    Console.WriteLine("\nFinal Level: ");
    Console.WriteLine("What has 13 hearts, but no other organs? ");
    string guessFive = Console.ReadLine().ToLower();

    if (guessFive.Contains("card"))
    {
        Console.WriteLine("\nRejoice! You are now the master of riddles!");
        Console.WriteLine("\nThanks for playing!");
    }
    else
    {
        Console.WriteLine("Victory was not yours this time!");
        Console.WriteLine("GAME OVER");
        // end game loop
        break;
    }

    // End game loop
    break;
}


