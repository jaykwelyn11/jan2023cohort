class RangedFighter : Enemy
{
    public int Distance;
    public RangedFighter(string theName) : base(theName)
    {
        Distance = 5;
        AllAttacks = new List<Attack>() {
            new Attack("Arrow", 25),
            new Attack("Knife", 10)
        };
    }

    public override void PerformAttack(Enemy target, Attack chosenAttack)
    {
        if (this.Distance < 10)
        {
            Console.WriteLine($"{this.Name} is too close to attack");
        }
        else
        {
            base.PerformAttack(target, chosenAttack);
        }
    }

    public int Dash()
    {
        this.Distance = 20;
        Console.WriteLine($"{this.Name} has moved to attack distance");
        return this.Distance;
    }

}