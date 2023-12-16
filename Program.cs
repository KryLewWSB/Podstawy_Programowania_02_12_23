Console.WriteLine(Powitanie("Anna")); 
Console.WriteLine(Powitanie("Tomasz")); 
Console.WriteLine(Powitanie("Anita")); 

static string Powitanie(string imie)
{
    return $"Witaj, {imie}!";
}