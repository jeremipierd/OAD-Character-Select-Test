using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Sorcerer : Entity.Character
{
    public Sorcerer(string name) : base(name, CharacterClass.Rogue)
    {
        Health = 80;
        Strength = 9;
        Intelligence = 80;
        Agility = 15;
        Magic = 0;
        Aura = 0;
    }
}

/* skopiowalem klase i zamienilem statystyki i imie */
/* dodalem magic i aura */