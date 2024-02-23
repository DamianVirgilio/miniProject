public class healing
{
    public int Medkit = 0;
    public int Bandage = 0;

    public void PickUpMed(int AmountOfMedkits)
    {
        Medkit += AmountOfMedkits;
    }

    public void PickUpBandaid(int AmountOfBandage)
    {
        Bandage += AmountOfBandage;
    }

    public void ShowHealing()
    System.Console.WriteLine("---------------------");
    System.Console.WriteLine($"You have {Medkit} medkits");
    System.Console.WriteLine("---------------------");
    

}