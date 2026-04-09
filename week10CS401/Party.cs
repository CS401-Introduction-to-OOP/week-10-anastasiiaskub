namespace week10CS401;
using System.Collections;
using System.Collections.Generic;

public class Party : IEnumerable<Character>

{
    private List<Character> _characters = new List<Character>();

    public void AddCharacter(Character character)
    {
        _characters.Add(character);
    }

    public IEnumerator<Character> GetEnumerator()
    {
        foreach (var charact in _characters)
        {
            yield return charact;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerable<Character> GetWoundedMembers(int limit)
    {
        foreach (var character1 in _characters)
        {
            if (character1.HP < limit)
            {
                yield return character1;
            }
            
        }
    }

    public IEnumerable<Character> GetActiveCharacter()
    {
        foreach (var character2 in _characters)
        {
            if (character2.Status == "active")
            {
                yield return character2;
            }
            
        }
    }
}
