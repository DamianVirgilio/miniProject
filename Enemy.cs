public class Enemy
{
    public string NameEnemy;
    public int Health;
    public int Damage;

    public Enemy(string name_enemy, int health, int damage)
    {
        NameEnemy = name_enemy;
        Health = health;
        Damage = damage;
    }
    public static Enemy GetEnemy(int level)
    {
        Enemy BabyGriever = new Enemy("Baby Griever", 40, 20);
        Enemy StalkerGriever = new Enemy("Stalker Griever", 150, 50);
        Enemy TankGriever = new Enemy("Tank Griever", 300, 50);
        Enemy InfernoGriever = new Enemy("Inferno Griever", 500, 150);
        List<Enemy> Enemies = new() {BabyGriever, StalkerGriever, TankGriever, InfernoGriever};
        Random random = new Random();
        if(level == 1)
        {
            return BabyGriever;
        }
        else if(level == 2)
        {
            int randint = random.Next(2);
            return Enemies[randint];
        }
        else if(level == 3)
        {
            int randint = random.Next(3);
            return Enemies[randint]; 
        }
        else
        {
            int randint = random.Next(4);
            return Enemies[randint];
        }
    }
}