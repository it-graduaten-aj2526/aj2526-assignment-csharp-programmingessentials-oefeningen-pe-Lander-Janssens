//Declaratie variabelen
int kortezijde;
int langezijde;
int omtrek, oppervlakte;

Console.WriteLine("Geef de korte zijde: ");
kortezijde = int.Parse(Console.ReadLine());

Console.WriteLine("Geef de lange zijde: ");
langezijde = int.Parse(Console.ReadLine());

omtrek = (kortezijde + langezijde);
oppervlakte = kortezijde * langezijde;

Console.WriteLine($"Omtrek: {omtrek}");
Console.WriteLine($"Oppervlakte: {oppervlakte}");