int getal1, getal2;

Console.Write("Geef je eerste getal in");
getal1 = int.Parse(Console.ReadLine());

Console.Write("Geef je tweede getal in");
getal2 = int.Parse(Console.ReadLine());

if (getal2 == 0)
{
    Console.Write("Is niet deelbaar door nul");
}
else
{
    Console.WriteLine($"de uitkomst is {getal1 = getal1 / getal2}");
}