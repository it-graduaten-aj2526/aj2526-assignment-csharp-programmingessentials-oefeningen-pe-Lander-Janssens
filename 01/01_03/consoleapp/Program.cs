
double volwassenen, kinderen;

Console.Write("Met hoeveel volwassenen zijn jullie?: ");
volwassenen = double.Parse(Console.ReadLine());

Console.Write("Met hoeveel kinderen zijn jullie?: ");
kinderen = double.Parse(Console.ReadLine());

Console.WriteLine($"Totaal te betalen: {(10 * volwassenen) + (7.50 * kinderen)}");
