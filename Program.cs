/*Zadanie 1.3. Napisz program, który pobiera od użytkownika liczbę a następnie wykonuje potęgowanie i pierwiastkowanie. W zadaniu należy wykorzystać Math.pow() i Math.sqrt(). Lub ^.*/
Console.WriteLine("Proszę o podanie liczby: [zatwierdź enterem]");
int liczba = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"Wynik potęgowania: {Math.Pow(liczba, 2)}");//Operacja 2 do potęgi 2
Console.WriteLine($"Wynik pierwiastkowania: {Math.Sqrt(liczba)}");//pierewiastkowanie