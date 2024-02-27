
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
    public Weapons EquippedWeapon;

    public Player(string _name, Location currentLocation)
    {
        CurrentLocation = currentLocation;
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

    public void ShowChoices(Weapons CurrentWeapon)
    {
        System.Console.WriteLine(@"1. Equip Weapon
                                   2. Heal yourself
                                   3. Show Items
                                   4. Continue the Maze");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CurrentWeapon.ShowWeapons();
                break;
            case "2":
                ShowHealing();
                break;

            default:
                break;
        }

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
    public void Combat(Player player, Enemy enemy)
    {
        while (player.IsAlive() && enemy.IsAlive())
        {
            int PlayerDamage = player.Strength + player.EquippedWeapon.damage;
            enemy.TakeDamage(totalDamage);

            Console.WriteLine($"Player attacks for {PlayerDamage} damage.");
            Console.WriteLine($"Enemy health: {enemy.Health}");

            if (enemy.IsAlive())
            {
                player.TakeDamage(enemy.Damage);

                Console.Writeline($"Enemy attacks for {enemy.Damage} damage.");
                Console.Writeline($"Players health: {player.Health}")
            }
        }
        if (player.IsAlive() && !enemy.IsAlive())
        {
            Console.WriteLine("Griever Defeated!");
        }
        else if (!player.IsAlive() && enemy.IsAlive())
        {
            Console.WriteLine("You have been defeated!");
        }
    }
}
