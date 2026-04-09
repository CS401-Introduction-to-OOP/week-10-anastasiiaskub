namespace week10CS401;

public class Event
{
    public int Turn { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public string Impact { get; set; }
    public override string ToString()
    {
        return $"turn: {Turn}, {Type}: {Description} {Impact}";
    }
}