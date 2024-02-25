
public class Player
{
    public string Name;
    public int MaxHealth;
    public int Health;
    public int Strength;
    public int Medkit = 0;
    public int Bandage = 0;
    public int level = 1;
    public Location CurrentLocation;

    public Player(Location currentLocation)
    {
        CurrentLocation = currentLocation;
    }

    public Player(string _name)
    {
        Name = _name;
        MaxHealth = 100;
        Health = MaxHealth;
        Strength = 10;
    }

    public bool TryMoveTo(Location newLocation)
    {
        if (newLocation != null)
        {
            CurrentLocation = newLocation;
            return true;
        }
        return false;
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

        if (choice == "Medkit") // voer string in voor medkit

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

        else if (choice == "bandage") // voer string voor bandage

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
