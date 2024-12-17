Console.Clear();

Console.Clear();

Console.Write("Skriv in ett ord: ");
string ord = Console.ReadLine();

bool AllaTeckenMinstTvåGånger = true;
for (int i = 0; i < ord.Length; i++)
{
    bool ettteckenminsttvågånger = false;
    for (int j = 0; j < ord.Length; j++)
    {
        if (i != j && ord[i] == ord[j])
        {
            ettteckenminsttvågånger = true;
        }
    }
    if (ettteckenminsttvågånger == false)
    {
        AllaTeckenMinstTvåGånger = false;        
    }
}
if (AllaTeckenMinstTvåGånger)
{
    Console.WriteLine("Alla tecken förekommer minst två gånger ");
}
else
{
    Console.WriteLine("Det finns minst ett tecken som bara förekommer en gång i ordet");
}