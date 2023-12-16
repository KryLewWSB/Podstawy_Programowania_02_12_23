/* 8. Napisz program, który tworzy listę jednokierunkową liczb całkowitych,
 dodaje kilka elementów na jej koniec, a następnie wyświetla zawartość listy.*/

LinkedList<int> linkedList = new LinkedList<int>();

// Dodawanie elementów na koniec listy
linkedList.AddLast(10);
linkedList.AddLast(20);
linkedList.AddLast(30);
linkedList.AddLast(40);

// Wyświetlanie zawartości listy
foreach (var item in linkedList)
{
    Console.WriteLine(item);
}

