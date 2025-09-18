double prijs1;
double BTW;

Console.WriteLine("Geef de prijs in");
prijs1 = double.Parse(Console.ReadLine());

Console.WriteLine("Geef de BTW in"); 
BTW = double.Parse(Console.ReadLine());

prijs1 += (prijs1 * (BTW / 100) );

Console.WriteLine($"Prijs inclusief BTW: {Convert.ToInt32(prijs1)}");
