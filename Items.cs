public class Items
{
    List<string> ItemList = new();
    
    public Items(string item)
    {
        ItemList.Add(item);
    }

    public void ShowItems()
    {
        foreach (string Item in ItemList)
        {
            System.Console.WriteLine(Item);
        }
    }
}