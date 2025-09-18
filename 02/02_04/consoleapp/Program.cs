int getal1;

Console.Write("Geef het deeltal in: ");
getal1 = int.Parse(Console.ReadLine());

int getal2 = getal1 % 5;
int getal3 = getal1 % 11;
getal1 = getal3 + getal2;

if (getal1  != 0)
{
    Console.Write("Niet deelbaar");
}
else
{
    Console.Write("Deelbaar");
}
