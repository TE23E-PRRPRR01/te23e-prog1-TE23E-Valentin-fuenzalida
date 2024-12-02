Console.Clear();

Console.WriteLine("Detta ska lista ut om en låt får spelas på en radiostation");

Console.WriteLine("Hur många minuter har låten? ");
int minuter = int.Parse(Console.ReadLine());

Console.WriteLine("Hur många sekunder har låten? ");
int sek =  int.Parse(Console.ReadLine());

double sekunder = sek/100;
double tid = sekunder + minuter;

double maxgräns = 4.2;
double mingräns = 2.45;

if (tid <= maxgräns && tid >= mingräns)
{
    Console.WriteLine("Din låt får spelas i radiostationen");
}
else
{
    Console.WriteLine("Din låt får inte spelas på radiostationen");
}

