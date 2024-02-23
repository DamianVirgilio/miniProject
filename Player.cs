
public class Player
{
    public string Name;
    public int MaxHealth;
    public int Health;
    public int Strength;
    
    public Player(string _name)
    {
        Name = _name;
        MaxHealth = 100;
        Health = MaxHealth;
        Strength = 10;
    }

    public bool IsAlive()
    {
        return HealthPoints > 0;
    }

    public void TakeDamage(int damage)
    {
        HealthPoints =- damage;
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

    public void HealPlayer(string choice)    // We moeten even bespreken hoe we kiezen uit een healthkit en een bandage
    {
        if (choice == ...) // voer string in voor medkit
        {
            Health = MaxHealth;
        }
        else if (choice == ...) // voer string voor bandage
        {
            int healing = MaxHealth / 2;
            Health += healing;
        }
    }
}
