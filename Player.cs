
public class Player
{
    public string Name;
    public int MaxHealth;
    public int Health;
    public int Strength;
    public int Medkit = 0;
    public int Bandage = 0;
    public int level = 1;
    
    public Player(string _name)
    {
        Name = _name;
        MaxHealth = 100;
        Health = MaxHealth;
        Strength = 10;
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

    public void TakeDamage(int damage)
    {
        Health =- damage;
    }

    public void HealthUpgrade(int AmountHealth)
    {
        MaxHealth += AmountHealth;
        Health = MaxHealth;
    }

    public void StrengthUpgrade(int AmountStrength)
    {
        Strength += AmountStrength;
    }

     public void PickUpMed(int AmountOfMedkits)
    {
        Medkit += AmountOfMedkits;
    }

    public void PickUpBandaid(int AmountOfBandage)
    {
        Bandage += AmountOfBandage;
    }

    public void ShowHealing()
    {
        System.Console.WriteLine("---------------------");
        System.Console.WriteLine($"You have {Medkit} medkits");
        System.Console.WriteLine($"You have {Bandage} bandages");
        System.Console.WriteLine("---------------------");
    }
    

    public void HealPlayer(string choice)    // We moeten even bespreken hoe we kiezen uit een healthkit en een bandage
    {
<<<<<<< HEAD
        if (choice == "1") // voer string in voor medkit
=======
        if (choice == "Medkit") // voer string in voor medkit
>>>>>>> 5640e3c5900040e2b4bab7ae7ddac0015167114b
        {
            if (Medkit > 0)
            {
                Health = MaxHealth;
                Medkit =- 1;
            }
            else 
            {
                System.Console.WriteLine("You do not have any medkits");
            }
        }
<<<<<<< HEAD
        else if (choice == "2") // voer string voor bandage
=======
        else if (choice == "bandage") // voer string voor bandage
>>>>>>> 5640e3c5900040e2b4bab7ae7ddac0015167114b
        {
            if (Bandage > 0)
            {
                int healing = MaxHealth / 2;
                Health += healing;
                Bandage =- 1;
            }
            else 
            {
                System.Console.WriteLine("You do not have any Bandages");
            }
        }
    }
}
