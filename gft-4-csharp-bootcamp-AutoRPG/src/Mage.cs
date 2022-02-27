namespace gft_4_csharp_bootcamp_AutoRPG;

public class Mage : Character
{
    public int CurrentMp;
    public int MaxMp;
    
    public Mage(string name, int hp, int level, int mp) : base(name, hp, level)
    {
        this.CurrentMp = mp;
        this.MaxMp = mp;
    }

    public int Recharge()
    {
        this.CurrentMp = this.MaxMp;
        Console.WriteLine(this.Name + " is recharging MP.");
        return 0;
    }

    public override int ChoseAttack()
    {
        if (CurrentMp <= 0)
        {
            return Recharge();
        }
        else
        {
            this.CurrentMp--;
           return ChoseSpell();
        }
    }

    public virtual int ChoseSpell()
    {
        return 0;
    }
}

