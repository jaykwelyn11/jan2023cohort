class MeleeFighter : Enemy
{
    public MeleeFighter(string theName) : base(theName)
    {
        Health = 120;
        AllAttacks = new List<Attack>() {
            new Attack("Punch", 15),
            new Attack("Slap", 25),
            new Attack("Kick", 20)
        };
    }

    public Attack Rage()
    {
        Random rand = new Random();
        int attack = rand.Next(AllAttacks.Count);
        AllAttacks[attack].DamageAmount += 10;
        Console.WriteLine($"{AllAttacks[attack].Name} new damage dealt {AllAttacks[attack].DamageAmount}");
        return AllAttacks[attack];
    }

}