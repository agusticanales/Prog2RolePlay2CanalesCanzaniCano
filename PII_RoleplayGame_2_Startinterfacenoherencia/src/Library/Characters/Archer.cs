using System.Diagnostics;

namespace Ucu.Poo.RoleplayGame;

public class Archer : Character
{
    private int health = 100;

    public Archer(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }
    
    public list <Item> ItemsDamage;
     public list <Item> ItemsDefense;



    public int AttackValue
    {
        set
        {
            foreach (i in Items)
            {
                if (i.type != Axe || Bow || Sword)
                {
                  AttackValue+= i.AttackValue;    
                }
            }
        } 
    }

    public int DefenseValue
    {
        get
        {
            return Helmet.DefenseValue;
        }
    }

    public int Health
    {
        get
        {
            return this.health;
        }
        private set
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
