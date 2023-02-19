class MagicCaster : Enemy
{
    public MagicCaster(string theName) : base(theName)
    {
        Health = 80;
        AllAttacks = new List<Attack>() {
            new Attack("Fireball", 20),
            new Attack("Lightning", 25),
            new Attack("Force push", 15)
        };
    }

    public void Heal(Enemy helpHeal)
    {
        this.Health += 40;
        Console.WriteLine($"{this.Name} has healed {helpHeal.Name} 40 health");
    }


}