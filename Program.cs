/*
Console.WriteLine("Proszę o podanie liczby: [zatwierdź enterem]");
int liczba = Convert.ToInt32( Console.ReadLine() );

if ( liczba % 2 == 0 && liczba != 0 )
{
    Console.WriteLine("Liczba " + liczba + " jest podzielna przez 2!");
}
*/

Console.WriteLine(2 == 2 || 3 < 4); // true ||  true    wypisze finalnie: True
Console.WriteLine(2 == 2 || 3 > 4); // true ||  false    wypisze finalnie: True
Console.WriteLine(2 != 2 || 3 < 4); // true ||  false    wypisze finalnie: True
Console.WriteLine(2 != 2 || 3 > 4); // false ||  false    wypisze finalnie: False

bool herbata = true;
bool kawa = false;

Console.WriteLine(herbata || kawa);//Idź do sklepu i kup herbatę lub kawę True

