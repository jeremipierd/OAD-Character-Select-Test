using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Thief : Entity.Character
{
    public Thief(string name) : base(name, CharacterClass.Rogue)
    {
        Health = 80;
        Strength = 9;
        Intelligence = 80;
        Agility = 20;
        Magic = 0;
        Aura = 0;
    }
}

/* skopiowalem klase i zamienilem statystyki i imie */
/* dodalem magic i aura */