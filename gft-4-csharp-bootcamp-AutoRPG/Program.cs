// See https://aka.ms/new-console-template for more information

using gft_4_csharp_bootcamp_AutoRPG;

Random rng = new Random();

Knight knight = new Knight("Arus", 200, 42);
Ninja ninja = new Ninja("Wedee", 120, 41);
Healer healer = new Healer("Jenica", 50, 43,5);
Wizard wizard = new Wizard("Topapa", 100, 42, 5);
DemonLord demonLord = new DemonLord("Maou", 800, 99);


while (demonLord.CurrentHp > 0)
{
    if (demonLord.CurrentHp > 0 && knight.CurrentHp > 0)
    {
        demonLord.LoseHp((knight.ChoseAttack()));
    }
    if (demonLord.CurrentHp > 0 && ninja.CurrentHp > 0)
    {
        demonLord.LoseHp((ninja.ChoseAttack()));
    }
    if (demonLord.CurrentHp > 0 && healer.CurrentHp > 0)
    {
        demonLord.LoseHp((healer.ChoseAttack()));
    }
    if (demonLord.CurrentHp > 0 && wizard.CurrentHp > 0)
    {
        demonLord.LoseHp((wizard.ChoseAttack()));
    }
    
    if (demonLord.CurrentHp > 0){
        int attacks = rng.Next(1,4);
        for (int i = 0; i < attacks; i++)
        {
            int target = rng.Next(1, 5);
            switch (target)
            {
                case 1:
                    if (knight.CurrentHp > 0)
                    {
                        knight.LoseHp(demonLord.ChoseAttack());
                    }

                    break;

                case 2:
                    if (ninja.CurrentHp > 0)
                    {
                        ninja.LoseHp(demonLord.ChoseAttack());
                    }

                    break;

                case 3:
                    if (healer.CurrentHp > 0)
                    {
                        healer.LoseHp(demonLord.ChoseAttack());
                    }

                    break;
                case 4:
                    if (wizard.CurrentHp > 0)
                    {
                        wizard.LoseHp(demonLord.ChoseAttack());
                    }

                    break;
            }
        }
    }

    if (knight.CurrentHp <= 0 && ninja.CurrentHp <= 0 && healer.CurrentHp <= 0 && wizard.CurrentHp <= 0)
    {
        Console.WriteLine("You lose.");
        break;
    }
}

if(demonLord.CurrentHp <= 0) {Console.WriteLine("You win.");}