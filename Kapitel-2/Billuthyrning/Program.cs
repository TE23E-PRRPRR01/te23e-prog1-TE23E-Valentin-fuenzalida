//program för att räkna ut billhyrning
Console.Clear();

Console.WriteLine("ett program för att beräkna kostnaden för att hyra bil hos en biluthyrningsfirma");

//gör dagar till en variable som sen kan användas i formeln
Console.WriteLine("Ange hur många dagar du ska hyra");
double dagar = double.Parse(Console.ReadLine());

//gör dagar till en variable som sen kan användas i formeln
Console.WriteLine("Ange hur många mil du ska köra");
double mil = double.Parse(Console.ReadLine());


//beräkna billhyran med alla variabler och hur mycket billhyran kostar
double billuthyrning = (mil * 5) * (dagar * 100) + 500;


//skriv ut allting
Console.WriteLine($"billuthyrningen kommer bli {billuthyrning} kr");
