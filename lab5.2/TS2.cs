using System;
using System.Collections;
class MyList<T> : IEnumerable<T>
{
    private T[] list;
    int length
    {
        get => list.Length;
    }
    public MyList(params T[] args)
    {
        int c = 0;
        list = new T[args.Length];
        foreach (T i in args)
        {
            list[c] = i;
            c++;
        }
    }
    public void Add(T new_element)
    {
        var new_list = new T[this.list.Length + 1];
        list.CopyTo(new_list, 0);
        new_list[list.Length] = new_element;
        list = new_list;
    }
    public T this[int i]
    {
        get => list[i];
        set => list[i] = value;
    }
    public void Print()
    {
        foreach (T i in list)
        {
            Console.Write(i + "\t");
        }
        Console.WriteLine();
    }
    public IEnumerator<T> GetEnumerator()
    {
        return (IEnumerator<T>)list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}