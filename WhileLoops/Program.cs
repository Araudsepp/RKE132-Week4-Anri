﻿Random rnd  = new Random();
int cpuRandom;

bool loopActive  = true; //bool t/f

while(loopActive)
{
    cpuRandom = rnd.Next(1,4);
    Console.WriteLine("Make a guess, enter number between 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom);
    {
        Console.WriteLine("Congratulations, you won!");
        loopActive = false;
    }
}
Console.WriteLine("Have a nice day!");
