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
    Console.Write($"{naam} {achternaam}: Jeugd");
}
