public class Ember
{
    public string? Nev { get; set; }
    public int Kor { get; set; }

    public override string ToString()
    {
        return $"{Nev}, {Kor} éves";
    }
}
