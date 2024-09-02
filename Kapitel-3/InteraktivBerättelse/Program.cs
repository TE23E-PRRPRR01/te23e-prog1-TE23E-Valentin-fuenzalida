// en berättelse
Console.WriteLine("Hej");
Console.Clear();

Console.WriteLine("are you stressed? (y/n)");
string answer = Console.ReadLine();

//continue the conversation
if (answer = "y")
{
    Console.Write("do you want to talk about it? (y/n)");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.Write("don't worry it will be okay in time. is it school your stressed about (y/n)");
        answer = Console.ReadLine();
        if (answer == "y")
        {
            Console.WriteLine("then don't worry, if you study enough you will be okay");
        }
        else
        {
            Console.WriteLine("I hope you will find someone to talk about your stress with");
        } 
    }
    else
    {
        Console.WriteLine("then get lost, because i will not talk to anybody who doesn't want to share anthing with me");
    }
}
else
{
    Console.Write("do you like any sports");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("do you like table tennis");
        answer = Console.ReadLine();
        if (answer == "y")
        {
            Console.WriteLine("Me to, i love that sweden is one of the best in the world at it");
        }
        else
        {
            Console.WriteLine("i am asuming you like football then, bc that is what everybody likes in sweden even if we are not good at it");
        }
    }
    else
    {
        Console.WriteLine("that is sad");
    }
}