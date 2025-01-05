Console.Clear();

Console.WriteLine("skriv ett ord");
string ord = Console.ReadLine();
bool NågotTeckenFörekommerMerÄn1Gång = false;

for (int i = 0; i < ord.Length; i++)
{
     // ord[..i] är den del av ordet som finns innan tecknet på index i
    if (ord[..i].Contains(ord[i]))
    {
        // Tecknet finns tidigare, gå vidare till nästa tecken
        continue;
    }
    // Kolla om tecknet finns på något senare ställe i ordet
    if (ord[(i+1)..].Contains(ord[i]))
    {
        Console.WriteLine($"'{ord[i]}' förekommer mer än 1 gång.");
        NågotTeckenFörekommerMerÄn1Gång = true;
    }
}

if (NågotTeckenFörekommerMerÄn1Gång == false)
{
    Console.WriteLine("inget tecken förekommer mer än 1 gång");
}