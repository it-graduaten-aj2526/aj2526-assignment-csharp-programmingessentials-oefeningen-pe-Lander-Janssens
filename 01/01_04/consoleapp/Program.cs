int internationale, nationale;

Console.Write("Hoeveel internationale oproepen heeft u gemaakt: ");
internationale = int.Parse(Console.ReadLine());

Console.Write("Hoeveel nationale oproepen heeft u gemaakt: ");
nationale = int.Parse(Console.ReadLine());

int totaleGesprekken = internationale + nationale;

double eindprijs = totaleGesprekken * 0.12 + 23 + (totaleGesprekken * 0.12 + 23 ) * 0.21;

Console.WriteLine($"Het totaal te betalen bedrag is: {Convert.ToInt32(eindprijs)}");