Console.Clear();
Console.WriteLine("program för att konvertera temperaturen i celsius till fahrenheit");


//läs in temperaturen som en sträng, och du kan också ta bort stringen och istället ta in readline i int.parse för att då läser den bara cw
Console.WriteLine("Ange temperaturen i Celsius: ");
string celsiusString  = Console.ReadLine();

//konvertera strängen till ett heltal
int celsius = int.Parse(celsiusString);

//beräkna temperaturen i fahrenheit
int fahrenheit  = celsius * 9 / 5 + 32;

//skriv ut allt
Console.WriteLine($"{celsius} Celsius är {fahrenheit} Fahrenheit");




//samma men omvänt och mer noggrant
Console.WriteLine("program för att konvertera temperaturen i fahrenheit till  celsius");

Console.WriteLine("Ange temperaturen i Fahrenheit");
double tempFahrenheit = double.Parse(Console.ReadLine());

double tempCelsius = (tempFahrenheit - 32) * 5/9;

Console.WriteLine($"{tempFahrenheit} Fahrenheit blir {tempCelsius} Celsius");
