//Declaratie variabelen
int getal1;
int getal2;
int getal3;
int getal4;
int optelling, vermenigvuldiging;

Console.WriteLine("Geef uw eerste getal voor de optelling.");
getal1 = int.Parse(Console.ReadLine());

Console.WriteLine("Geef uw tweede getal voor de optelling.");
getal2 = int.Parse(Console.ReadLine());

optelling = (getal1 + getal2);

Console.WriteLine($"Optelling: {optelling}");

Console.WriteLine("Geef uw eerste getal voor de vermenigvuldiging");
getal3 = int.Parse(Console.ReadLine());

Console.WriteLine("Geef uw tweede getal voor de vermenigvuldiging");
getal4 = int.Parse(Console.ReadLine());

vermenigvuldiging = (getal3 * getal4);

Console.WriteLine($"Vermenigvuldiging: {vermenigvuldiging}");