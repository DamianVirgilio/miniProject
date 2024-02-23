class Weapons
{
    public string weaponName;
    public int damage;
    public List<Weapons> WeaponList = new();

    public Weapons(string _weaponName, int _damage){
        weaponName = _weaponName;
        damage = _damage;
    }

    ShowWeapons()
    {
        if (WeaponList.Count > 0)
        {
            foreach (Weapons weapon in WeaponList)
            {
                System.Console.WriteLine(weapon);
            }
        }
        else
        {
            System.Console.WriteLine("You have no weapons. ");
        }
    }
}