Console.Write("Hoeveel graden Celcius is het: ");
int gradenCelcius = int.Parse(Console.ReadLine());

int gradeFahrenheit = gradenCelcius * 9 / 5 + 32;

Console.WriteLine($"Fahrenheit:{gradeFahrenheit}");
