Console.Clear();

Console.WriteLine("Detta program ska se om du är gammal nog att gå med i seniormästerskapet för en goldklubb");

Console.WriteLine("Hur gammal är du? ");
int svar = int.Parse(Console.ReadLine().ToLower());

if (svar >= 50)
{
    Console.WriteLine("Du är gammal nog att vara med i golfklubbens seniormästerskap");
}

if (svar < 50)
{
    Console.WriteLine("Du är inte gammal nog för goldklubbens seniormästerskap");
}

