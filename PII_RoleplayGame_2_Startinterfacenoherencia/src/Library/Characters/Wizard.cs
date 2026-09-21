namespace Ucu.Poo.RoleplayGame;

public class Wizard : MagicCharacter
{
    private int health = 100;
    public Wizard(string name)
    {
        this.Name = name;
        this.MagicItems = new List<MagicItems>();
    }

    public string Name { get; set; }

    public List<MagicItems> MagicItems { get; set; }  
    public int AttackValue
    {
        get
        {
            int total = 0;
            foreach (MagicItems item in this.MagicItems)
            {
                total += item.AttackValue;
            }
            return total;
        }
    }

    public int DefenseValue
    {
        get
        {
            int total = 0;
            foreach (MagicItems item in this.MagicItems)
            {
                total += item.DefenseValue;
            }
            return total;
        }
    }

    public int Health 
    {
        get
        {
            return this.health;
        }
        set
        {
            this.health = value < 0 ? 0 : value;
        }
    }

    public void ReceiveAttack(int power)
    {
        if (this.DefenseValue < power)
        {
            this.health -= power - this.DefenseValue;
            if (this.health < 0)
            {
                this.health = 0;
            }
        }
    }

    public void Cure()
    {
        this.health = 100;
    }

}  
}
