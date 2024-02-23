public class Items
{
    List<string> ItemList = new();
    
    public Items(string item)
    {
        ItemList.Add(item);
    }

    public void ShowItems()
    {
        System.Console.WriteLine("---------------------");

        if (ItemList.Count > 0)
        {
            foreach (string Item in ItemList)
            {
                System.Console.WriteLine(Item);
            }
        }
        else
        {
            System.Console.WriteLine("You have no items");
        }
        System.Console.WriteLine("---------------------");

    }
}
