string naam, achternaam;
int leeftijd;

Console.Write("Wat is uw naam: ");
naam = Console.ReadLine();

Console.Write("Wat is uw familie naam: ");
achternaam = Console.ReadLine();

Console.Write("Wat is uw leeftijd: ");
leeftijd = int.Parse(Console.ReadLine());

if (leeftijd >= 18)
{
    Console.Write($"{naam} {achternaam}: Volwassenen");
}
else
{
<<<<<<< HEAD
    Console.Write($"Dag {naam} u behoort tot de jeugd");
}
=======
    Console.Write($"{naam} {achternaam}: Jeugd");
}
>>>>>>> a46c910b445fe4c8f9b2a51657f4ac13d90a62f0
