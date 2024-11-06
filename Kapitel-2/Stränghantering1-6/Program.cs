using System.Text;

Console.Clear();

Console.WriteLine("Första stränghanteringen");

// skapar en variabel
String mening = "Den mätta dagen, den är aldrig störst. Den bästa dagen är en dag av törst";

// Delar upp menningen i olika ord och lägger de i en lista (mellanrum separerar bara orden)

List<string> d_ordlåda = new();
String[] ordlåda = mening.Split(' ');

//List<string> nyaord = new();

// ska se om d finns i första bokstaven
foreach (var ord in ordlåda)
{
    if (ord.ToLower()[0] == 'd')
    {
        d_ordlåda.Add(ord);
    }
}
foreach (string ord in d_ordlåda)
{
    Console.WriteLine(ord);
}



// skapar en mening variabel
String mening1 = "Nog finns det mål och mening i vår färd - men det är vägen, som är mödan värd.";

// sparar variabeln som har byt ut alla mellanslag i meningen till #
mening1 = mening1.Replace(' ', '#');

// skriver ut den nya meningen
Console.WriteLine(mening1);


// skapar en ny varibel
String mening2 = "Det bästa målet är en nattlång rast, där elden tänds och brödet bryts i hast.";
String[] allaord = mening2.Split(' '); // delar up meningen i specifika ord
String sistaordet = allaord[allaord.Length - 1].Trim(); // extrehearar sista ordet

Console.WriteLine(sistaordet);


String mening3 = "På ställen, där man sover blott en gång, blir sömnen trygg och drömmen full av sång.";

int antalE = 0;

for (int i = 0; i < 4; i++)
{
    
}
