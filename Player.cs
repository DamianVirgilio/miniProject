
public class Player
{
    public string Name;
    public int MaxHealth;
    public int Health;
    public int Strength;
    public int Level;
    
    public Player(string _name, int _strength)
    {
        Name = _name;
        MaxHealth = 100;
        Health = MaxHealth;
        Strength = _strength;
        Level = 1;
    }

    public bool IsAlive()
    {
        return HealthPoints > 0;
    }
}
