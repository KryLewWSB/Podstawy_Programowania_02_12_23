Console.WriteLine("Proszę o podanie liczby: [zatwierdź enterem]");
int liczba = Convert.ToInt32( Console.ReadLine() );


Console.WriteLine( liczba > 0 ? "Liczba jest dodatnia!" : 
                                "Liczba jest ujemna!" );//to co w nawiasie, to operator warunkowy.
