public interface Character{
    public string Name {get ; set;}

    public int AttackValue;

    public int DefenseValue;

    public int Health;

    public void ReceiveAttack(int power){
        if (this.DefenseValue < power)
        {
            this.Health -= power - this.DefenseValue;
        }
    }

        public void Cure(){
        this.Health = 100;
    }
}