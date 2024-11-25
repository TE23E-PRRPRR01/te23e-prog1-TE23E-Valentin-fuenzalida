Console.Clear();

Console.WriteLine("Detta program frågar användaren hur många poäng hen fick På det nationella provet i Matematik 4 våren 2013. Programmet ska säga vilket provbetyg användaren fick.");

Console.WriteLine("Vad fick du för poäng på mattematik provet? ");
int poäng = int.Parse(Console.ReadLine().ToLower());

if (poäng >= 55)
{
    Console.WriteLine("Du fick A i provbetyg gratis");
}
else if (poäng >= 46)
{
    Console.WriteLine("Du fick B i provbetyg gratis");
}
else if (poäng >= 35)
{
    Console.WriteLine("Du fick C i provbetyg gratis");
}
else if (poäng >= 27)
{
    Console.WriteLine("Du fick D i provbetyg, du gör bättre nästa gång");
}
else if (poäng >= 18)
{
    Console.WriteLine("Du fick D i provbetyg, du gör bättre nästa gång");
}
else
{
    Console.WriteLine("Du fick F i provbetyg, du gör bättre nästa gång");
}