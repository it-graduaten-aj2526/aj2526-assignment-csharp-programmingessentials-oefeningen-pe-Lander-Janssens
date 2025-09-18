string naam;
int leeftijd;

Console.Write("Wat is uw volledige naam?");
naam = Console.ReadLine();

Console.Write("Wat is uw leeftijd?");
leeftijd = int.Parse(Console.ReadLine());

if (leeftijd >= 18)
{
    Console.Write($"Dag {naam} u behoort tot de volwassenen");
}
else
{
    Console.Write($"Dag {naam} u behoort tot de jeugd");
}