//Zadanie 1.1. Napisz program, który przyjmie od użytkownika w konsoli 2 wartości typu String i wyświetli je w konsoli użytkownikowi w ten sposób:
//Przyjmowanie pierwszej wartości string od użytkowenika z konsoli:
Console.WriteLine("Proszę o podanie swojego imienia: [zatwierdź enterem]");
string imie = Console.ReadLine();

//Przyjmowanie drugiego wartości string od użytkowenika z konsoli:
Console.WriteLine("Proszę o podanie swojego nazwisko: [zatwierdź enterem]");
string nazwisko = Console.ReadLine();

//Wyświetlanie przyjętych wartości:
Console.WriteLine("Cześć!\nTwoje imię to: " + imie + "\nA nazwisko to: " + nazwisko);//1 sposób
Console.WriteLine($"Cześć!\nTwoje imię to: {imie}\nA nazwisko to: {nazwisko}");

//3 sposób
/*Console.WriteLine("Cześć!");
Console.WriteLine("Twoje imię to: " + imie);
Console.WriteLine("A nazwisko to: " + nazwisko);*/