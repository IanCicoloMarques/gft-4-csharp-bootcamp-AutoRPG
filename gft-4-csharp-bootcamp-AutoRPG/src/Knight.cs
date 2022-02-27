namespace gft_4_csharp_bootcamp_AutoRPG;

public class Knight : Character
{
    public int Focus = 0;
    
    public Knight(string name, int hp, int level) : base(name, hp, level)
    {
        
    }

    public int Slash()
    {
        Console.WriteLine(this.Name + " attacked.");
        this.Focus = this.Focus + 10;
        return 10;
    }

    public int FocusAttack()
    {
        Console.WriteLine(this.Name + " attacked with full force!");
        this.Focus = 0;
        return 40;
    }

    public override int ChoseAttack()
    {
        Random rng = new Random();
        int option = rng.Next(1, 100);
        if (Focus >= option)
        {
           return FocusAttack();
        }
        else
        {
            return Slash();
        }
    }
}