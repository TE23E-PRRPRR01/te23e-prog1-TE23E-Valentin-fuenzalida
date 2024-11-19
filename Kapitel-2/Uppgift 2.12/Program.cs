Console.Clear();

Console.WriteLine("Detta program ska skriva ut hur mycket billhyra kostar");

int Startavgiften = 300;

Console.WriteLine("hur många kilometer vill du köra med bilen: ");
double kilometer = double.Parse(Console.ReadLine());

Console.WriteLine("hur många dagar vill du hyra bilen: ");
double dagar = double.Parse(Console.ReadLine());

double totalkostnaddagar = (dagar - 1) * 500;

double totalkostnad = Startavgiften + kilometer + totalkostnaddagar;

Console.WriteLine($"total kostnaden för hyran blir {totalkostnad} kr");