/* *************************************************************
* **********************     M A I N            ***********************
**************************************************************** */


Console.Clear();

SägHejNamn("Valentin");

KvadratTal(3);

/* *************************************************************
* ********************* M E T O D E R *************************
**************************************************************** */

/// <summary>
/// Hälsar med input
/// </summary>
/// <param name="namn">Namnet</param>
static void SägHejNamn(string namn)
{
    Console.WriteLine($"Hej på {namn}!");
}

/// <summary>
/// Metod som kvaderar ett tal
/// </summary>
/// <param name="Tal"></param>

static void KvadratTal(int Tal)
{
    Console.WriteLine($"{Tal} i kvadrat = {Tal*Tal}");
}