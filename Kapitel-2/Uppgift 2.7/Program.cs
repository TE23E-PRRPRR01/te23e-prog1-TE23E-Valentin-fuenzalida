Console.Clear();

Console.WriteLine("Detta program ska byta håll på orden i en två ords mening");

Console.WriteLine("Vänligen skriv en mening men två ord och utan punkt");
string svar = Console.ReadLine();

int Mellanslag = svar.IndexOf(" ");

string förstaordet = svar[..Mellanslag];
string andraordet = svar[(Mellanslag + 1)..];

Console.WriteLine(andraordet + " " + förstaordet);