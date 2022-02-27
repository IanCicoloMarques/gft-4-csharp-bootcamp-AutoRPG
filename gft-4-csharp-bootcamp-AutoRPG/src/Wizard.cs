namespace gft_4_csharp_bootcamp_AutoRPG;

public class Wizard : Mage
{
    public Wizard(string name, int hp, int level, int mp) : base(name, hp, level, mp)
    {
    }
    
    public int Fireball()
    {
        Console.WriteLine(this.Name + "used fireball.");
        return -1;
    }

    public int Thunderbolt()
    {
        Console.WriteLine(this.Name + "used thunderbolt.");
        return 20;
    }

    public override int ChoseSpell()
    {
        Random rng = new Random();
        bool fireball = Convert.ToBoolean(rng.Next(2));
        if (fireball)
        {
            return Fireball();
        }
        else
        {
            return Thunderbolt();
        }
    }
}