namespace Ucu.Poo.RoleplayGame;

public class Dwarf : Character
{
    private int health = 100;
     public List<DamageItems> ItemsDamage { get; set; }

    public List<DefenseItems> ItemsDefense { get; set; }
    public Dwarf(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public int AttackValue
    {
        get
        {
           int Damage = 0;
            foreach (DamageItems i in ItemsDamage)
            {   
                  Damage+= i.AttackValue;    
            }
            return Damage;
        } 
    }

  public int DefenseValue
    {
        get
        {
           int Defense = 0;
            foreach (DefenseItems i in ItemsDefense)
            {   
                  Defense+= i.DefenseValue;    
            }
            return Defense;
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
            this.Health -= power - this.DefenseValue;
        }
    }

    public void Cure()
    {
        this.Health = 100;
    }
}
