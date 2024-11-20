Console.Clear();

Console.WriteLine("Skriv in en mening med tre ord, avsluta med punkt");
string mening = Console.ReadLine();

int förstamellanslag = mening.IndexOf(" ");
int andramellanslag = mening.IndexOf(" ", förstamellanslag + 1);
int punkt = mening.IndexOf(".");


string förstaordet = mening[..förstamellanslag];
string andraordet = mening[(förstamellanslag + 1)..andramellanslag];
string tredjeordet = mening[(andramellanslag + 1)..punkt];

Console.WriteLine($"{tredjeordet} {andraordet} {förstaordet}.");