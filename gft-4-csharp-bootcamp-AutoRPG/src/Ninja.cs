namespace gft_4_csharp_bootcamp_AutoRPG;

public class Ninja : Character
{
    public int WeaponCounter = 1;
    
    public Ninja(string name, int hp, int level) : base(name, hp, level)
    {
    }

    public int Throw()
    {
        Console.WriteLine(this.Name + " threw a weapon.");
        return this.WeaponCounter;
    }

    public int Scatter()
    {
        Console.WriteLine(this.Name + "scattered weapons around");
        this.WeaponCounter = this.WeaponCounter + (Convert.ToInt32(Math.Ceiling(this.WeaponCounter*0.25)));
        return Throw();
    }

    public override int ChoseAttack()
    {
        Random rng = new Random();
        int scatter = rng.Next(256);
        if (scatter >= 231)
        {
            return Scatter();
        }
        else
        {
            return Throw();
        }
    }
}