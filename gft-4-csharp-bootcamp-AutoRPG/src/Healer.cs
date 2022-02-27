namespace gft_4_csharp_bootcamp_AutoRPG;

public class Healer : Mage
{
    public int BanishChance;
    
    public Healer(string name, int hp, int level, int mp) : base(name, hp, level, mp)
    {
    }

    public int Heal()
    {
        Console.WriteLine(this.Name + " recovered HP.");
        int value = Convert.ToInt32(Math.Ceiling((MaxHp - CurrentHp) * 0.5));
        RecoveryHp(value);
        this.BanishChance = this.BanishChance + 10;
        return 0;
    }

    public int Banish()
    {
        Console.WriteLine(this.Name + " banished the enemy!");
        return -1;
    }
    
    public override int ChoseSpell()
    {
        Random rng = new Random();
        int option = rng.Next(1, 1000);
        if (this.BanishChance >= option)
        {
            return Banish();
        }
        else
        {
            return Heal();
        }
    }
}