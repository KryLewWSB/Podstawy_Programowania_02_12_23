/*Zadanie 1.6. Napisz prosty konwerter godzin na minuty i odwrotnie. Pobierz liczbę godzin od użytkownika, przelicz
 *je na minuty i wypisz. Następnie pobierz od użytkownika informację o liczbie minut i zamień je na godziny i wypisz.*/
Console.WriteLine("Proszę o podanie liczby minut: [zatwierdź enterem]");
int liczbaMinut = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Proszę o podanie liczby godziny: [zatwierdź enterem]");
int liczbaGodzin = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"Podałeś {liczbaMinut} minut. Jest to tyle godzin: {liczbaMinut / 60}");
Console.WriteLine($"Podałeś {liczbaGodzin} godzin. Jest to tyle minut: {liczbaGodzin * 60}");