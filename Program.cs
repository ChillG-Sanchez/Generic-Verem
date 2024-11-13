using System;

class Program
{
    static void Main()
    {
        // Szám típusú verem
        Verem<int> szamVerem = new Verem<int>();
        szamVerem.Push(10);
        szamVerem.Push(20);
        szamVerem.Push(30);
        Console.WriteLine(szamVerem.ToString());
        Console.WriteLine($"Peek: {szamVerem.Peek()}");
        Console.WriteLine($"Pop: {szamVerem.Pop()}");
        Console.WriteLine($"Count: {szamVerem.Count}");
        Console.WriteLine($"IsEmpty: {szamVerem.IsEmpty}");
        Console.WriteLine(szamVerem.ToString());

        // Szöveg típusú verem
        Verem<string> szovegVerem = new Verem<string>();
        szovegVerem.Push("Első");
        szovegVerem.Push("Második");
        szovegVerem.Push("Harmadik");
        Console.WriteLine(szovegVerem.ToString());
        Console.WriteLine($"Peek: {szovegVerem.Peek()}");
        Console.WriteLine($"Pop: {szovegVerem.Pop()}");
        Console.WriteLine($"Count: {szovegVerem.Count}");
        Console.WriteLine($"IsEmpty: {szovegVerem.IsEmpty}");
        Console.WriteLine(szovegVerem.ToString());

        // Ember típusú verem
        Verem<Ember> emberVerem = new Verem<Ember>();
        emberVerem.Push(new Ember { Nev = "János", Kor = 30 });
        emberVerem.Push(new Ember { Nev = "Anna", Kor = 25 });
        Console.WriteLine(emberVerem.ToString());
        Console.WriteLine($"Peek: {emberVerem.Peek()}");
        Console.WriteLine($"Pop: {emberVerem.Pop()}");
        Console.WriteLine($"Count: {emberVerem.Count}");
        Console.WriteLine($"IsEmpty: {emberVerem.IsEmpty}");
        Console.WriteLine(emberVerem.ToString());
    }
}
