
Console.WriteLine("Proszę o podanie dnia w formie liczby(1-7): [zatwierdź enterem]");
int day = Convert.ToInt32( Console.ReadLine() );

//Instrukcja switch:
switch (day) {
    case 1:
        Console.WriteLine("Poniedziałek");
        break;
    case 2:
        Console.WriteLine("Wtorek");
        break;
    case 3:
        Console.WriteLine("Środa");
        break;
    case 4:
        Console.WriteLine("Czwartek");
        break;
    case 5:
        Console.WriteLine("Piątek");
        break;
    case 6:
        Console.WriteLine("Sobota");
        break;
    case 7:
        Console.WriteLine("Niedziela");
        break;
    default:
        Console.WriteLine("Nieznany dzień tygodnia");
        break;
}

//Instrukcja wrunkowa:
if (day == 1)
{
    Console.WriteLine("Poniedziałek");
}else if (day == 2)
{
    Console.WriteLine("Wtorek");
}else if (day == 3)
{
    Console.WriteLine("Środa");
}else if (day == 4)
{
    Console.WriteLine("CZwartek");
}else if (day == 5)
{
    Console.WriteLine("Piątek");
}else if (day == 6)
{
    Console.WriteLine("Sobota");
}else if (day == 7)
{
    Console.WriteLine("Niedziela");
}
else
{
    Console.WriteLine("Nieznany dzień tygodnia");
}

