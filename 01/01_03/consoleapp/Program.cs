
int volwassenen, kinderen;

Console.Write("Met hoeveel volwassenen zijn jullie?: ");
volwassenen = int.Parse(Console.ReadLine());

Console.Write("Met hoeveel kinderen zijn jullie?: ");
kinderen = int.Parse(Console.ReadLine());

Console.WriteLine($"Totaal te betalen: {Convert.ToInt32((10 * volwassenen) + (7,50 * kinderen))}");
