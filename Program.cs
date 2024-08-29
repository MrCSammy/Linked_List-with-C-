using System;
using System.Collections.Generic;

public class MyLinkedList<T>
{
    private LinkedList<T> linkedList;

    public MyLinkedList()
    {
        linkedList = new LinkedList<T>();
    }

    public int Add(T item)
    {
        linkedList.AddLast(item);
        return linkedList.Count;
    }

    public bool Remove(T item)
    {
        return linkedList.Remove(item);
    }

    public bool Check(T item)
    {
        return linkedList.Contains(item);
    }

    public int Index(T item)
    {
        int index = 0;
        foreach (var value in linkedList)
        {
            if (EqualityComparer<T>.Default.Equals(value, item))
                return index;
            index++;
        }
        return -1;
    }
}

class Program
{
    static void Main()
    {
        var myList = new MyLinkedList<string>();
        myList.Add("Apple");
        myList.Add("Banana");
        myList.Add("Cherry");

        Console.WriteLine($"Size of the linked list: {myList.Add("Date")}"); 

        Console.WriteLine($"Is 'Banana' removed? {myList.Remove("Banana")}"); 

        Console.WriteLine($"Is 'Cherry' in the list? {myList.Check("Cherry")}");
        Console.WriteLine($"Index of 'Apple': {myList.Index("Apple")}"); 
        Console.WriteLine($"Index of 'Grapes': {myList.Index("Grapes")}"); 
    }
}
