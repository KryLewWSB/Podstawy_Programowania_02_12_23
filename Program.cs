/* 7. Napisz metodę rekurencyjną w C#,
 która przyjmuje liczbę 10 od użytkownika i oblicza sumę liczb od 1 do tej liczby.*/

 Console.WriteLine( Suma(10) );
 
static int Suma(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else
    {
        return n + Suma(n - 1);// przekazujemy 10:  10 + 9 + 8 + 7 + 6 + 5 + 4 + 3 + 2 + 1 wynik: 55
    }
}