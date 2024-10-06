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

