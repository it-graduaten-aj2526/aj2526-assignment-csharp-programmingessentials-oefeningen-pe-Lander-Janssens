int prijs1 = 10;
double prijs2 = 7.50;
int volwassenen, kinderen;

Console.Write("Met hoeveel volwassenen zijn jullie?: ");
volwassenen = int.Parse(Console.ReadLine());

Console.Write("Met hoeveel kinderen zijn jullie?: ");
kinderen = int.Parse(Console.ReadLine());

Console.WriteLine($"Totaal te betalen: {Convert.ToInt32((prijs1 * volwassenen) + (prijs2 * kinderen))}");
