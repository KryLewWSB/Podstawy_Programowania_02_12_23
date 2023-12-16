/* Przykład metody podziel */

Console.WriteLine( Podziel(2, 2) );//wynik 1
Console.WriteLine( Podziel(2, 8) );//wynik 0,25
Console.WriteLine( Podziel(b:2, a:8) );//wynik 4
Console.WriteLine( Podziel(8, 2) );//wynik 4

static double Podziel(double a, double b)
{
    return Convert.ToDouble(a / b);
}