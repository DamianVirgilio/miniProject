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
    public static Enemy GetEnemy(string sector)
    {
        Enemy BabyGriever = new Enemy("Baby Griever", 40, 20);
        Enemy StalkerGriever = new Enemy("Stalker Griever", 150, 50);
        Enemy TankGriever = new Enemy("Tank Griever", 300, 50);
        Enemy InfernoGriever = new Enemy("Inferno Griever", 500, 150);
        List<Enemy> Enemies = new() {BabyGriever, StalkerGriever, TankGriever, InfernoGriever};
        Random random = new Random();
        if(sector == "Sector 1")
        {
            return BabyGriever;
        }
        else if(sector == "Sector 2")
        {
            int randint = random.Next(2);
            return Enemies[randint];
        }
        else if(sector == "Sector 3")
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
    public void TakeDamage(int damage)
    {
        Health =- damage;
    }
    public bool IsAlive()
    {
        return Health > 0;
    }
    public static void HandCombatGally()
    {
        string SparInput;
        do
        {
            Console.WriteLine("type 'spar' if you want to fight Gally:");
            SparInput = Console.ReadLine();

            if (SparInput == "Spar" || SparInput == "spar")
            {
                Console.WriteLine("AND THE FIGHT STARTS!");
                Console.WriteLine
                (@"
                Gally HITS almost ALL his punches on you
                You struggle to hit him back...
                He seems stronger than you anticipated!

                Choose which tactic you want to use (1 or 2)!
                1. Position yourself to apply JOINT LOCK!
                2. Position yourself to EXECUTE a TRHOW!
                ");
                
                string ChooseTactic = Console.ReadLine();

                if (ChooseTactic == "1")
                {
                    Console.WriteLine
                    (@"
                    You find a way to USE his OWN STRENGTH AGAINST HIM!
                    YOU SWIPE HIS LEGS AND MAKE HIM FALL!
                    You RUN over to HIS BODY AND POSITION YOURSELF in a way to LOCK HIS ELBOW!
                    
                    -------------------------
                    THE REFF STOPS THE FIGHT
                    -------------------------

                    He DECLARES THAT YOU ARE THE WINNER!

                    SUDDENLY Gally RUNS over to you and HITS your HEAD!
                    You FALL AND HIT YOUR HEAD ON THE GROUND!
                    ");

                }
                else if (ChooseTactic == "2")
                {
                    Console.WriteLine
                    (@"
                    You find a way to USE his OWN STRENGTH AGAINST HIM!
                    HE JUMPS ON TO YOU AND YOU THROW HIS BODY TO THE GROUND!
                    YOU HIT HIM A FEW TIMES AND IT LOOKS LIKE HES ABOUT TO LOSE CONSIOUSNESS!

                    -------------------------
                    THE REFF STOPS THE FIGHT
                    -------------------------

                    HE DECLARES THAT YOU ARE THE WINNER!

                    SUDDENLY Gally RUNS over to you and HITS your HEAD!
                    You FALL AND HIT YOUR HEAD ON THE GROUND!
                    ");
                }

                break;
            }
            else
            {
                Console.WriteLine("Dont be a baby! Fight Gally to show him that you're capable of being a Runner!");
            }
        }
        while (SparInput == "Spar" || SparInput == "spar");       
    }
}
