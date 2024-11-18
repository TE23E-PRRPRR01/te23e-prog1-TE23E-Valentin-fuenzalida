Console.Clear();

Console.WriteLine("Skriv in en addition");
string addition = Console.ReadLine();
int plusindex = addition.IndexOf("+");
string tal1Text = addition[..plusindex];
string tal2Text = addition[(plusindex + 1)..];

int tal1 = int.Parse(tal1Text);
int tal2 = int.Parse(tal2Text);
int summa = tal1 + tal2;

Console.WriteLine(addition + " = " + summa);