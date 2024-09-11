using System.Runtime.CompilerServices;

Console.Clear();

Console.WriteLine("program för att räkna ut din BMI");


Console.WriteLine("Ange din vikt i kg");
double vikt = double.Parse(Console.ReadLine());

Console.WriteLine("Ange din länd i meter");
double längd = double.Parse(Console.ReadLine());

double BMI = vikt / (längd * längd);

Console.WriteLine($"din BMI är {BMI:00.00}");