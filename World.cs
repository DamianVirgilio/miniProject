public static class World
{
    public static readonly List<Location> Locations = new List<Location>();

    public const int LOCATION_ID_LOC1 = 1;
    public const int LOCATION_ID_LOC2 = 2;
    public const int LOCATION_ID_LOC3 = 3;
    public const int LOCATION_ID_LOC4 = 4;
    public const int LOCATION_ID_LOC5 = 5;
    public const int LOCATION_ID_LOC6 = 6;
    public const int LOCATION_ID_LOC7 = 7;
    public const int LOCATION_ID_LOC8 = 8;
    public const int LOCATION_ID_LOC9 = 9;
    public const int LOCATION_ID_LOC10 = 10;
    public const int LOCATION_ID_LOC11 = 11;
    public const int LOCATION_ID_LOC12 = 12;
    public const int LOCATION_ID_LOC13 = 13;
    public const int LOCATION_ID_LOC14 = 14;
    public const int LOCATION_ID_LOC15 = 15;
    public const int LOCATION_ID_LOC16 = 16;
    public const int LOCATION_ID_LOC17 = 17;
    public const int LOCATION_ID_LOC18 = 18;
    public const int LOCATION_ID_LOC19 = 19;
    public const int LOCATION_ID_LOC20 = 20;
    public const int LOCATION_ID_LOC21 = 21;
    public const int LOCATION_ID_LOC22 = 22;
    public const int LOCATION_ID_LOC23 = 23;
    public const int LOCATION_ID_LOC24 = 24;
    public const int LOCATION_ID_LOC25 = 25;
    public const int LOCATION_ID_LOC26 = 26;
    public const int LOCATION_ID_LOC27 = 27;
    public const int LOCATION_ID_LOC28 = 28;
    public const int LOCATION_ID_LOC29 = 29;
    public const int LOCATION_ID_LOC30 = 30;
    public const int LOCATION_ID_LOC31 = 31;
    public const int LOCATION_ID_LOC32 = 32;
    public const int LOCATION_ID_LOC33 = 33;
    public const int LOCATION_ID_LOC34 = 34;
    public const int LOCATION_ID_LOC35 = 35;
    public const int LOCATION_ID_LOC36 = 36;
    public const int LOCATION_ID_LOC37 = 37;
    public const int LOCATION_ID_LOC38 = 38;
    public const int LOCATION_ID_LOC39 = 39;
    public const int LOCATION_ID_LOC40 = 40;
    public const int LOCATION_ID_LOC41 = 41;
    public const int LOCATION_ID_LOC42 = 42;



    static World() => PopulateLocations();

    private static void PopulateLocations()
    {
        // Create each location
        Location loc1      = new Location(LOCATION_ID_LOC1, "Home", "");
        Location loc2      = new Location(LOCATION_ID_LOC2, "Sector 1", "");
        Location loc3      = new Location(LOCATION_ID_LOC3, "Sector 1", "");
        Location loc4      = new Location(LOCATION_ID_LOC4, "Sector 1", "");
        Location loc5      = new Location(LOCATION_ID_LOC5, "Sector 1", "");
        Location loc6      = new Location(LOCATION_ID_LOC6, "Sector 1", "");
        Location loc7      = new Location(LOCATION_ID_LOC7, "Sector 2", "");
        Location loc8      = new Location(LOCATION_ID_LOC8, "Sector 2", "");
        Location loc9      = new Location(LOCATION_ID_LOC9, "Sector 2", "Boltcutter");
        Location loc10     = new Location(LOCATION_ID_LOC10, "Sector 2", "Bandage");
        Location loc11     = new Location(LOCATION_ID_LOC11, "Sector 2", "");
        Location loc12     = new Location(LOCATION_ID_LOC12, "Sector 3", "");
        Location loc13     = new Location(LOCATION_ID_LOC13, "Sector 3", "B");
        Location loc14     = new Location(LOCATION_ID_LOC14, "Sector 3", "");
        Location loc15     = new Location(LOCATION_ID_LOC15, "Sector 3", "Riddle");
        Location loc16     = new Location(LOCATION_ID_LOC16, "Sector 3", "");
        Location loc17     = new Location(LOCATION_ID_LOC17, "Sector 4", "");
        Location loc18     = new Location(LOCATION_ID_LOC18, "Sector 4", "Assault Rifle");
        Location loc19     = new Location(LOCATION_ID_LOC19, "Sector 1", "GrieverFight");
        Location loc20     = new Location(LOCATION_ID_LOC20, "Sector 1", "");
        Location loc21     = new Location(LOCATION_ID_LOC21, "Sector 1", "");
        Location loc22     = new Location(LOCATION_ID_LOC22, "Sector 3", "");
        Location loc23     = new Location(LOCATION_ID_LOC23, "Sector 4", "");
        Location loc24     = new Location(LOCATION_ID_LOC24, "Sector 2", "");
        Location loc25     = new Location(LOCATION_ID_LOC25, "Sector 1", "D");
        Location loc26     = new Location(LOCATION_ID_LOC26, "Sector 2", "Stungun");
        Location loc27     = new Location(LOCATION_ID_LOC27, "Sector 2", "");
        Location loc28     = new Location(LOCATION_ID_LOC28, "Sector 2", "N");
        Location loc29     = new Location(LOCATION_ID_LOC29, "Sector 2", "");
        Location loc30     = new Location(LOCATION_ID_LOC30, "Sector 2", "");
        Location loc31     = new Location(LOCATION_ID_LOC31, "Sector 3", "Handgun");
        Location loc32     = new Location(LOCATION_ID_LOC32, "Sector 1", "");
        Location loc33     = new Location(LOCATION_ID_LOC33, "Sector 3", "Shovel");
        Location loc34     = new Location(LOCATION_ID_LOC34, "Sector 4", "");
        Location loc35     = new Location(LOCATION_ID_LOC35, "Sector 4", "");
        Location loc36     = new Location(LOCATION_ID_LOC36, "Sector 4", "");
        Location loc37     = new Location(LOCATION_ID_LOC37, "Sector 4", "");
        Location loc38     = new Location(LOCATION_ID_LOC38, "Sector 4", "Goal");
        Location loc39     = new Location(LOCATION_ID_LOC39, "Sector 4", "Medkit");
        Location loc40     = new Location(LOCATION_ID_LOC40, "Sector 4", "M");
        Location loc41     = new Location(LOCATION_ID_LOC41, "Sector 4", "");
        Location loc42     = new Location(LOCATION_ID_LOC42, "Sector 3", "");


        // Link the locations together
        loc1.LocationToNorth = loc2; // naar Sector 1
        loc1.LocationToSouth = loc21;

        loc2.LocationToWest = loc3;
        loc2.LocationToEast = loc5;
        loc2.LocationToSouth = loc1;

        loc3.LocationToEast = loc2;
        loc3.LocationToNorth = loc4;
        loc3.LocationToWest = loc3;

        loc4.LocationToSouth = loc3; 
        loc4.LocationToNorth = loc12; //naar Sector 3

        loc5.LocationToNorth = loc6;
        loc5.LocationToWest = loc2;
        loc5.LocationToEast = loc11;

        loc6.LocationToEast = loc7; // naar Sector 2
        loc6.LocationToSouth = loc5;

        loc7.LocationToWest = loc6;
        loc7.LocationToNorth = loc8;
        loc7.LocationToEast = loc10;

        loc8.LocationToSouth = loc7;
        loc8.LocationToNorth = loc9;

        loc9.LocationToSouth = loc8;

        loc10.LocationToWest = loc7;
        loc10.LocationToEast = loc30;
        loc10.LocationToSouth = loc11;

        loc11.LocationToNorth = loc10;
        loc11.LocationToEast = loc5; // naar Sector 1
        loc11.LocationToSouth = loc24;
        loc11.LocationToWest = loc29;

        loc12.LocationToSouth = loc4; // naar Sector 1
        loc12.LocationToNorth = loc13;
        loc12.LocationToWest = loc15;

        loc13.LocationToSouth = loc12;
        loc13.LocationToNorth = loc14;

        loc14.LocationToSouth = loc13;
        loc14.LocationToWest = loc31;

        loc15.LocationToEast = loc12;
        loc15.LocationToSouth = loc16;

        loc16.LocationToSouth = loc17; // naar Sector 4
        loc16.LocationToNorth = loc15;
        loc16.LocationToWest = loc42;

        loc17.LocationToNorth = loc16;
        loc17.LocationToSouth = loc18;

        loc18.LocationToNorth = loc17;
        loc18.LocationToEast = loc19; // naar Sector 1

        loc19.LocationToNorth = loc32;
        loc19.LocationToWest = loc18; // naar Sector 4
        loc19.LocationToEast = loc20;

        loc20.LocationToWest = loc19;
        loc20.LocationToNorth = loc21;
        loc20.LocationToEast = loc25;

        loc21.LocationToNorth = loc1;
        loc21.LocationToSouth = loc20;

        loc22.LocationToNorth = loc33;
        loc22.LocationToSouth = loc42;

        loc23.LocationToEast = loc42;
        loc23.LocationToWest = loc35;
        loc23.LocationToSouth = loc34;

        loc24.LocationToSouth = loc25;
        loc24.LocationToEast = loc26;
        loc24.LocationToNorth = loc11;

        loc25.LocationToWest = loc20;
        loc25.LocationToNorth = loc24; // naar Sector 2

        loc26.LocationToWest = loc24;
        loc26.LocationToNorth = loc29;
        loc26.LocationToEast = loc27;

        loc27.LocationToWest = loc26;
        loc27.LocationToNorth = loc28;
        
        loc28.LocationToSouth = loc27;
        loc28.LocationToWest = loc29;
        
        loc29.LocationToSouth = loc26;
        loc29.LocationToEast = loc28;
        loc29.LocationToNorth = loc30;
        loc29.LocationToWest = loc11;

        loc30.LocationToSouth = loc29;
        loc30.LocationToWest = loc10;

        loc31.LocationToEast = loc14;
        loc31.LocationToWest = loc33;

        loc32.LocationToEast = loc3;
        loc32.LocationToSouth = loc19;

        loc33.LocationToEast = loc31;
        loc33.LocationToSouth = loc22;

        loc34.LocationToNorth = loc23;
        loc34.LocationToEast = loc41;
        loc34.LocationToSouth = loc36;

        loc35.LocationToEast = loc23;
        loc35.LocationToSouth = loc37;

        loc36.LocationToNorth = loc34;
        loc36.LocationToWest = loc38;
        loc36.LocationToSouth = loc40;

        loc37.LocationToNorth = loc35;

        // loc38 is goal

        loc39.LocationToNorth = loc41;
        
        loc40.LocationToNorth = loc36;

        loc41.LocationToNorth = loc42;
        loc41.LocationToWest = loc34;
        loc41.LocationToSouth = loc39;

        loc42.LocationToNorth = loc22;
        loc42.LocationToWest = loc23; // naar Sector 4
        loc42.LocationToEast = loc16;
        loc42.LocationToSouth = loc41; // naar Sector 4


        Locations.Add(loc1);
        Locations.Add(loc2);
        Locations.Add(loc3);
        Locations.Add(loc4);
        Locations.Add(loc5);
        Locations.Add(loc6);
        Locations.Add(loc7);
        Locations.Add(loc8);
        Locations.Add(loc9);
        Locations.Add(loc10);
        Locations.Add(loc11);
        Locations.Add(loc12);
        Locations.Add(loc13);
        Locations.Add(loc14);
        Locations.Add(loc15);
        Locations.Add(loc16);
        Locations.Add(loc17);
        Locations.Add(loc18);
        Locations.Add(loc19);
        Locations.Add(loc20);
        Locations.Add(loc21);
        Locations.Add(loc22);
        Locations.Add(loc23);
        Locations.Add(loc24);
        Locations.Add(loc25);
        Locations.Add(loc26);
        Locations.Add(loc27);
        Locations.Add(loc28);
        Locations.Add(loc29);
        Locations.Add(loc30);
        Locations.Add(loc31);
        Locations.Add(loc32);
        Locations.Add(loc33);
        Locations.Add(loc34);
        Locations.Add(loc35);
        Locations.Add(loc36);
        Locations.Add(loc37);
        Locations.Add(loc38);
        Locations.Add(loc39);
        Locations.Add(loc40);
        Locations.Add(loc41);
        Locations.Add(loc42);
    }

    public static void Home(Player player)
    {
        System.Console.WriteLine(@"
        You are now back home safe luckily. 
        You take some rest so you can go back in the maze the next day. 

        ZZZzzZZZzzzzZZZzZzZzzzZ

        You have woken up and feel rested!
        Your HP is now full!
        
        ");

      
      player.Health = player.MaxHealth;
    }
<<<<<<< HEAD
    public static void Combat(Player player, Enemy enemy)
    {
        while (player.IsAlive() && enemy.IsAlive())
        {
            int totalDamage = player.Strength + player.EquippedWeapon.damage;

            enemy.TakeDamage(totalDamage);

            if (enemy.IsAlive())
            {
                player.TakeDamage(enemy.Damage);
            }
        }
        // if (player.IsAlive && !enemy.IsAlive())
        // {
        //     Console.WriteLine("Griever Defeated!");
        // }
        // else if (!player.IsAlive && enemy.IsAlive())
        // {
        //     Console.WriteLine("You have been defeated!");
        // }
    }
=======
>>>>>>> 75b0b00686ae8efdc398d2f80cf09f44690d5019
}