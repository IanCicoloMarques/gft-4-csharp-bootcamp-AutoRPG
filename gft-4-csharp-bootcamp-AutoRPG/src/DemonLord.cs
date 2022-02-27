namespace gft_4_csharp_bootcamp_AutoRPG;

public class DemonLord : Character
{
    public int Rage = 1;
    
    public DemonLord(string name, int hp, int level) : base(name, hp, level)
    {
    }

    public int Attack()
    {
        Console.WriteLine("The Demon Lord attacked.");
        this.Rage = this.Rage + 1;
        return this.Rage;
    }

    public override int ChoseAttack()
    {
        return Attack();
    }
}