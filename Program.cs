public class Program
{
    public void Main()
    {
        do
        {
            Enemy enemy1 = Enemy.GetEnemy(1);
            System.Console.WriteLine(enemy1);
            Enemy enemy2 = Enemy.GetEnemy(2);
            System.Console.WriteLine(enemy2);
            Enemy enemy3 = Enemy.GetEnemy(3);
            System.Console.WriteLine(enemy3);
            Enemy enemy4 = Enemy.GetEnemy(4);
            System.Console.WriteLine(enemy4);
            Enemy enemy5 = Enemy.GetEnemy(5);
            System.Console.WriteLine(enemy5);
            break;
        } while (true);
    }
}
