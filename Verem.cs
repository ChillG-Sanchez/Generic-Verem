using System;
using System.Collections.Generic;
using System.Text;

public class Verem<T>
{
    private List<T> elemek = new List<T>();

    public int Count => elemek.Count;

    public bool IsEmpty => elemek.Count == 0;

    public void Push(T item)
    {
        elemek.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty)
            throw new InvalidOperationException("A verem üres, nem lehet eltávolítani elemet.");
        
        T teteje = elemek[elemek.Count - 1];
        elemek.RemoveAt(elemek.Count - 1);
        return teteje;
    }

    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("A verem üres, nincs lekérhető elem.");
        
        return elemek[elemek.Count - 1];
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Verem elemei: ");
        for (int i = elemek.Count - 1; i >= 0; i--)
        {
            sb.Append($"{elemek[i]} ");
        }
        return sb.ToString().Trim();
    }
}
