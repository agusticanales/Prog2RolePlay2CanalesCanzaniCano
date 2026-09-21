using System.Net.Mail;

namespace Ucu.Poo.RoleplayGame;

public class SpellsBook : MagicItems
{
    public List<ISpell> Spells { get; set; } = new List<ISpell>();
    
    public int AttackValue
    {
        get
        {
            int value = 0;
            foreach (ISpell spell in this.Spells)
            {
                value += spell.AttackValue;
            }
            return value;
        }
    }

    public int DefenseValue
    {
        get
        {
            int value = 0;
            foreach (ISpell spell in this.Spells)
            {
                value += spell.DefenseValue;
            }
            return value;
        }
    }
    public void AddSpell(ISpell spell)
    {
        this.Spells.Add(spell);
    }
}
