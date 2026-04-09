namespace week10CS401;

public class Character
{
    public string Name { get; set; }
    public string Role { get; set; }
    public int Level { get; set; }
    public int HP { get; set; }
    public int Gold { get; set; }
    public string Status { get; set; }

    public override string ToString()
    {
        return $"{Name}, {Role} - HP: {HP}, Gold: {Gold}, Status: {Status}, Level:{Level}";
    }
    
    
}