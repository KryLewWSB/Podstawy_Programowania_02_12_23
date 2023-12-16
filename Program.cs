/* Zadanie kategorii 2 - Zweryfikuj czy liczba pobrana z konsoli jest parzysta czy nie. */
Console.WriteLine("Podaj liczbę:");
int liczba = Convert.ToInt16( Console.ReadLine() );

/* 1 sposób to operator warunkowy: */
Console.WriteLine( liczba % 2 == 0 ? $"Liczba {liczba} jest podzielna przez 2!" :  
                                     $"Liczba {liczba} NIE jest podzielna przez 2!");

/* 2 Instrukcja warunkowa */

if (liczba % 2 == 0) // 2 % 2 zwraca: 0 PRAWDA!          3 % 2 zwracało 1
{
    Console.WriteLine($"Liczba {liczba} jest podzielna przez 2!");
}
else
{
    Console.WriteLine($"Liczba {liczba} NIE jest podzielna przez 2!");
}

/* Inny sposób zapisu */

if (liczba % 2 == 0) 
    Console.WriteLine($"Liczba {liczba} jest podzielna przez 2!");
else 
    Console.WriteLine($"Liczba {liczba} NIE jest podzielna przez 2!");

/* Inny sposób zapisu */

if (liczba % 2 == 0){
    Console.WriteLine($"Liczba {liczba} jest podzielna przez 2!");
}else {
    Console.WriteLine($"Liczba {liczba} NIE jest podzielna przez 2!");
}