
public class Animal : Alive
{
    public string Type { get; set; }

    public Animal(string name, string type) : base(name)
    {
        Type = type;
    }
}

