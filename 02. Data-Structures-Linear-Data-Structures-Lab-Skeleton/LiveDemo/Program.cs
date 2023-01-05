// See https://aka.ms/new-console-template for more information

using Problem04.SinglyLinkedList;

var collection = new SinglyLinkedList<int>();
collection.AddFirst(5);
collection.AddLast(6);
collection.RemoveFirst();

Console.WriteLine(string.Join(", ", collection.ToList()));