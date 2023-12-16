String[] tablicaImion = new string[] { "Anna", "Tomasz", "Anita", "Adam", "Paweł", "Piotr"};

foreach (String imie in tablicaImion)
{
    Console.WriteLine( Powitanie(imie) ); 
}


static string Powitanie(string imie)
{
    return $"Witaj, {imie}!";
}