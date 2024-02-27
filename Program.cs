public class Program01
{
    public static void Main()
    {
        System.Console.WriteLine("What is your Name?");
        string Username = System.Console.ReadLine();
        Player player = new Player(Username, World.Locations[0]);
        System.Console.WriteLine(player.CurrentLocation);
        System.Console.WriteLine(player.Name);
        System.Console.WriteLine(player.Health);
        System.Console.WriteLine(player.Strength);
        System.Console.WriteLine(player.Medkit);
        Enemy enemy1 = Enemy.GetEnemy(1);
        System.Console.WriteLine(enemy1.NameEnemy);
        Enemy enemy2 = Enemy.GetEnemy(2);
        System.Console.WriteLine(enemy2.NameEnemy);
        Enemy enemy3 = Enemy.GetEnemy(3);
        System.Console.WriteLine(enemy3.NameEnemy);
        Enemy enemy4 = Enemy.GetEnemy(4);
        System.Console.WriteLine(enemy4.NameEnemy);
        Enemy enemy5 = Enemy.GetEnemy(5);
        System.Console.WriteLine(enemy5.NameEnemy);
        while (player.CurrentLocation.Name != "Goal")
        {
            Console.WriteLine("Current location: " + player.CurrentLocation.Sector);
            Console.WriteLine(player.CurrentLocation.Compass());
            System.Console.WriteLine("Where do you want to go? (N/E/S/W)");
            string LocationMove = System.Console.ReadLine().ToUpper();
            player.TryMoveTo(player.CurrentLocation.GetLocationAt(LocationMove));
        };
        Console.WriteLine("You have arrived at the goal!");
    }
}