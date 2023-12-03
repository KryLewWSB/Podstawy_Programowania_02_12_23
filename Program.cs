Console.WriteLine("Proszę o podanie liczby: [zatwierdź enterem]");
int liczba = Convert.ToInt32( Console.ReadLine() );


if (liczba > 0) {
    Console.WriteLine("Liczba jest dodatnia.");
}else if (liczba < 0) {
    Console.WriteLine("Liczba jest ujemna.");
}else{
    Console.WriteLine("Liczba wynosi zero.");
}