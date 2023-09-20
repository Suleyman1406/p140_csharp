using System;
namespace Generics.List;

public class GenericList<T>
{
    private T[] items;
    public T[] Items { get => items; set => items = value; }

    public GenericList(params T[] items)
    {
        this.items = items;
    }

    public void Add(T item)
    {
        Array.Resize(ref items, items.Length + 1);
        items[items.Length - 1] = item;
    }

    public T GetAtIndex(int idx) {
        if (idx < 0 || idx >= items.Length)
        {
            throw new IndexOutOfRangeException();
        }
        return items[idx];
    }

    public void Print()
    {
        foreach(T item in items)
        {
            Console.WriteLine(item);
        }
    }

}

