while (true)
{
//Przyjmowanie pierwszej wartości string od użytkowenika z konsoli:
Console.WriteLine("Proszę o podanie liczby 1: [zatwierdź enterem]");
int liczba1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Proszę o podanie liczby 2: [zatwierdź enterem]");
int liczba2 = Convert.ToInt16(Console.ReadLine());

//Przyjmowanie drugiego wartości string od użytkowenika z konsoli:
Console.WriteLine("Proszę o podanie operatora arytmetycznego (+,-,*,/): [zatwierdź enterem]");
string operatorArytmetyczny = Console.ReadLine();//camelCase jest to sposób nazewnictwa zmiennych 


    switch (operatorArytmetyczny)
    {
        case "+":
        {
            Console.WriteLine($"Dodawanie: {liczba1} + {liczba2} = {liczba1 + liczba2}");
            break;
        }
        case "-":
        {
            Console.WriteLine($"Odejmowanie: {liczba1} - {liczba2} = {liczba1 - liczba2}");
            break;
        }
        case "*":
        {
            Console.WriteLine($"Mnożenie: {liczba1} * {liczba2} = {liczba1 * liczba2}");
            break;
        }
        case "/":
        {
            Console.WriteLine($"Dzielenie: {liczba1} / {liczba2} = {liczba1 / liczba2}");
            break;
        }
    }
}


/*
 * Zadanie 3.9. Napisz program który przyjmie dwie wartości od użytkownika oraz informację o działaniu arytmetycznym, które ma wykonać program (np.. +, -, *, /).
Należy wykorzystać instrukcję switch w celu sprawdzenia znaku operacji i wykonania operacji arytmetycznej. Proszę spróbować zapętlić program tak aby przyjmował dane od użytkownika ponownie po wykonaniu 1 operacji.
 */