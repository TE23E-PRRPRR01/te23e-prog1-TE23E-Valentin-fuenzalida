Console.Clear();

Console.WriteLine("Säg hur många kvadrattal du vill programmet ska skriva ut (kvadrattalen kommer börja från 1)");
int antalKvadrater = int.Parse(Console.ReadLine());

for (int i = 1; i <= antalKvadrater; i++)
{
    Console.WriteLine($"{i}*{i} = {i*i} ");
}