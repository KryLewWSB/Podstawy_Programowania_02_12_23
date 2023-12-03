
Console.WriteLine("Proszę o podanie liczby: [zatwierdź enterem]");
int liczba = Convert.ToInt32( Console.ReadLine() );

if ( liczba % 2 == 0 && liczba != 0 && liczba % 3 == 0 )
{
    Console.WriteLine("Liczba " + liczba + " jest podzielna przez 2 i 3!");
}
else
{
    Console.WriteLine("Liczba " + liczba + " jest niepodzielna przez 2 i 3");
}




