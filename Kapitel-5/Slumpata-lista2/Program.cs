// slumpa lista med slumpade tal
// validerar användarens inmatning

Console.Clear();

// deklarera variabler
// skapa en lista för att spara des slumpade talen

List<int> listaSlumptal = [];

// fråga använderaren hur många slumptal som ska skapas
Console.WriteLine("Ange antal slumptal ");

bool lyckades = int.TryParse(Console.ReadLine(), out int antal);

if (lyckades)
{
    Console.WriteLine($"du vill ha {antal} slumptal");

}
else
{
    Console.WriteLine("Du måste skriva ett heltal");
}
