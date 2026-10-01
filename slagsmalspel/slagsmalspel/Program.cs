// Elvira TE25c  :P//
using System.Data;
using System.Formats.Asn1;
Console.ForegroundColor = ConsoleColor.White;
while (true)
{
    int heroHp = 100;
    int villainHp = 100;

    Console.WriteLine("\x1b[45mType in the name of your hero:\x1b[49m");

    string heroName = Console.ReadLine(); // Här läser programmet vad du vill att din superhjälte ska heta.//
    string villainName = "Villain";

    //----------------------------------------//

    while (heroHp > 0 && villainHp > 0) // i den här while loopen så gör det så att koden spelas om så länge badå av dom har mer än 0 Hp//
    {
        // Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\x1b[45m~~ NEW ROUND ~~\x1b[49m");
        // Console.BackgroundColor = ConsoleColor.Black;  istället för att använde mig av Console.BackgroundColor så skriver jag istället in color codes= \x1b[
        Console.WriteLine();

        Console.WriteLine($"{heroName}: {heroHp}  {villainName}: {villainHp}");

        int villainDamage = Random.Shared.Next(25); // här så tar superhjälten skada från mellan 0-24 //
        heroHp -= villainDamage;
        heroHp = Math.Max(0, heroHp);
        Console.WriteLine($"{villainName} has dealt {villainDamage} damage to {heroName}");

        int heroDamage = Random.Shared.Next(25);
        villainHp -= heroDamage;
        villainHp = Math.Max(0, villainHp);     
        Console.WriteLine($"{heroName} has dealt {heroDamage} damage to {villainName}");

        Console.WriteLine("Press any key to proceed.");
        Console.ReadLine();
    }

    //----------------------------------------//
    // Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("\x1b[45m~~ THE FIGHT IS OVER! ~~\x1b[49m"); // de nästa 13 raderna är kod som väljer vad prorgammet ska skriva ut baserat på vem som vann eller förlora //
    //Console.BackgroundColor = ConsoleColor.Black; 
    if (heroHp == 0 && villainHp == 0)
    {
        Console.WriteLine("It's a tie!");
    }
    else if (heroHp == 0)
    {
        Console.WriteLine("The Villain has won!");
    }
    else if (villainHp == 0)
    {
        Console.WriteLine($"{heroName} has won!");
    }
//Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("\x1b[45m! Do you want to play again? (yes/no)\x1b[49m");
//Console.BackgroundColor = ConsoleColor.DarkMagenta;
    string answer = Console.ReadLine().ToLower();

    if (answer != "yes")
    {
        break;
    } // här så får spelaren välja om de vill spela om eller stänga ner programmet //
}