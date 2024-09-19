while (true)
{int dmg =Random.Shared.Next(50, 100);
Console.WriteLine(dmg);
Console.ReadLine();
}


Console.WriteLine("Skriv ditt namn HÄR--->:");
string name = Console.ReadLine();

while (name == "")
{
    Console.WriteLine("Hmar skärp dig dachri lek inte speciel");
    Console.WriteLine("Försök igen hmar");
    name = Console.ReadLine();
}
Console.ReadLine();