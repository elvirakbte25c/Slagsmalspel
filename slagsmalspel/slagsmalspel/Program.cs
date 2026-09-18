// Elvira TE25c //

int heroHp = 100;
int villainHp = 100;

string heroName = "Hero";
string villainName = "Villain";

//----------------------------------------//

while (heroHp > 0 && villainHp > 0)
{
    
    Console.WriteLine("~~ NEW ROUND ~~");
    Console.WriteLine($"{heroName}: {heroHp}  {villainName}: {villainHp}");

    int villainDamage =Random.Shared.Next(25);
    heroHp -= villainDamage;
    heroHp = Math.Max(0, heroHp);
    Console.WriteLine($"{villainName} has dealt {villainDamage} damage to {heroName}");

     int heroDamage =Random.Shared.Next(25);
    villainHp -= heroDamage;
    villainHp = Math.Max(0, villainHp);
    Console.WriteLine($"{heroName} has dealt {heroDamage} damage to {villainName}");

    Console.WriteLine("Press any key to proceed.");
    Console.ReadLine();
}

//----------------------------------------//

Console.WriteLine("~~ THE FIGHT IS OVER! ~~");

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
    Console.WriteLine("The Hero has won!");
}

Console.WriteLine("Press any key to close.");
Console.ReadLine();