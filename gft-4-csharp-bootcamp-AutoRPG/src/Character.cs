namespace gft_4_csharp_bootcamp_AutoRPG;

public class Character

{
    public string Name;
    public int MaxHp;
    public int CurrentHp;
    public int Level;
    
    public Character(string name, int hp, int level)
    {
        this.Name = name;
        this.CurrentHp = hp;
        this.MaxHp = hp;
        this.Level = level;
    }

    public void LoseHp(int value)
    {
        if (value == -1)
        {
            value = Convert.ToInt32(Math.Floor(this.CurrentHp * 0.1));
        }

        if (value != 0)
        {
            if (CurrentHp > value)
            {
                CurrentHp = CurrentHp - value;
                Console.WriteLine(this.Name + " lose " + value + " HP. [" + this.CurrentHp + "/" + this.MaxHp + "].");
            }
            else
            {
                CurrentHp = 0;
                Console.WriteLine(this.Name + " lose " + value + " HP.");
                Console.WriteLine(this.Name + " died!");
            }
        }
    }

    public void RecoveryHp(int value)
    {
        CurrentHp = CurrentHp + value;
        if (CurrentHp > MaxHp)
        {
            CurrentHp = MaxHp;
        }
    }

    public virtual int ChoseAttack()
    {
        return 0;
    }
    
    
}