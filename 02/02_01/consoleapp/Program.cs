int getal1, getal2;

Console.Write("Voer het eerste getal in: ");
getal1 = int.Parse(Console.ReadLine());

Console.Write("Voer het tweede getal in: ");
getal2 = int.Parse(Console.ReadLine());

if (getal1 >= getal2)
{
    getal1 = getal1 - getal2;
}
else
{
    getal1 = getal2 - getal1;
}
Console.WriteLine($"De uitkomst is {getal1}");