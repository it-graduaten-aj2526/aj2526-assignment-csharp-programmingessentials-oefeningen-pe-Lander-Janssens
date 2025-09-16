//Declaratie variabelen
int getal1, getal2, getal3, getal4, optelling, vermenigvuldiging;

Console.WriteLine("Geef uw eerste getal voor de optelling.");
getal1 = int.Parse(Console.ReadLine());

Console.WriteLine("Geef uw tweede getal voor de optelling.");
getal2 = int.Parse(Console.ReadLine());

Console.WriteLine("Geef uw eerste getal voor de vermenigvuldiging");
getal3 = int.Parse(Console.ReadLine());

Console.WriteLine("Geef uw tweede getal voor de vermenigvuldiging");
getal4 = int.Parse(Console.ReadLine());

optelling = (getal1 + getal3);
vermenigvuldiging = (getal2 * getal4);

Console.WriteLine($"Optelling: {optelling}");
Console.WriteLine($"Vermenigvuldiging: {vermenigvuldiging}");
