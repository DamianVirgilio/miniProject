
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
    public List<Weapons> WeaponList = new List<Weapons>();

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
        Health -= damage;
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

    public void ShowChoices(List<string> password, int time, bool watch)
    {
        if (watch)
        {
            System.Console.WriteLine(@"1. Show Weapons
2. Heal yourself
3. Show Collected Letters
4. Look at watch
5. Continue the Maze");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowWeapons();
                    break;
                    
                case "2":
                    ShowHealing();
                    break;

                case "3":
                    foreach (string letter in password)
                    {
                        System.Console.WriteLine(letter);
                    }
                    break;

                case "4":
                    Watch(time);
                    break;

                default:
                    break;
            }
        }
        else
        {
            System.Console.WriteLine(@"1. Show Weapons
2. Heal yourself
3. Show collected Letters
4. Continue the Maze");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowWeapons();
                    break;
                    
                case "2":
                    ShowHealing();
                    break;

                case "3":
                    System.Console.WriteLine("---------------------");
                    foreach (string letter in password)
                    {
                        System.Console.WriteLine(letter);
                    }
                    System.Console.WriteLine("---------------------\n");
                    break;

                default:
                    break;
            }        
        }
    }


        public void ShowWeapons()
        {
            System.Console.WriteLine("---------------------");
            if (WeaponList.Count > 0)
            {
                foreach (Weapons weapon in WeaponList)
                {
                    System.Console.WriteLine(weapon.WeaponName);
                }
            }
            else
            {
                System.Console.WriteLine("You have no weapons. ");
            }
            System.Console.WriteLine("---------------------");
        }

    public void AddWeapons(Weapons _weapon)
    {
        WeaponList.Add(_weapon);
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
            enemy.TakeDamage(PlayerDamage);

            Console.WriteLine($"Player attacks for {PlayerDamage} damage.");
            Console.WriteLine($"Enemy health: {enemy.Health}");

            if (enemy.IsAlive())
            {
                player.TakeDamage(enemy.Damage);

                Console.WriteLine($"Enemy attacks for {enemy.Damage} damage.");
                Console.WriteLine($"Players health: {player.Health}");
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
    public void Watch(int time)
    {
        if (time >= 0 && time <= 9)
        {
            System.Console.WriteLine("You look at your watch and see:\n");
            System.Console.WriteLine("   -------");
            System.Console.WriteLine($"  | 0{time}:00 |");
            System.Console.WriteLine("   -------\n");
        }
        else
        {
            System.Console.WriteLine("You look at your watch and see:\n");
            System.Console.WriteLine("   -------");
            System.Console.WriteLine($"  | {time}:00 |");
            System.Console.WriteLine("   -------\n");
        }
    }

        public int Home()
    {
        
        System.Console.WriteLine
        (@" 
        Choose what you want to do in your base:
        1. Sleep
        2. Exit and Continue
        ");

        string playerinput = Console.ReadLine();

        if (playerinput == "1")
        {
            Console.WriteLine
            (@"
            You are now back home safe luckily. 
            You take some rest so you can go back in the maze the next day. 

            ZZZzzZZZzzzzZZZzZzZzzzZ

            You have woken up and feel rested!
            Your HP is now full!
            ");

            Health = MaxHealth;

            return 7
        }
        else if (playerinput == "2")
        {
            Console.WriteLine(" You chose to continue...");
        }
       
        Health = MaxHealth;
    }
}
