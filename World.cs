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


    static World() => PopulateLocations();

    private static void PopulateLocations()
    {
        // Create each location
        Location loc1 = new Location(LOCATION_ID_LOC1, "Home");
        Location loc2      = new Location(LOCATION_ID_LOC2, "Zone 1");
        Location loc3      = new Location(LOCATION_ID_LOC3, "Zone 1");
        Location loc4      = new Location(LOCATION_ID_LOC4, "Zone 1");
        Location loc5      = new Location(LOCATION_ID_LOC5, "Zone 1");
        Location loc6      = new Location(LOCATION_ID_LOC6, "Zone 1");
        Location loc7      = new Location(LOCATION_ID_LOC7, "Empty location");
        Location loc8      = new Location(LOCATION_ID_LOC8, "Empty location");
        Location loc9      = new Location(LOCATION_ID_LOC9, "Empty location");
        Location loc10     = new Location(LOCATION_ID_LOC10, "Empty location");
        Location loc11     = new Location(LOCATION_ID_LOC11, "Empty location");
        Locations loc12    = new Location(LOCATION_ID_LOC12, "Empty location");
        Location loc13     = new Location(LOCATION_ID_LOC13, "Empty location");
        Location loc14     = new Location(LOCATION_ID_LOC14, "Empty location");
        Location loc15     = new Location(LOCATION_ID_LOC15, "Empty location");
        Location loc16     = new Location(LOCATION_ID_LOC16, "Empty location");
        Location loc17     = new Location(LOCATION_ID_LOC17, "Empty location");
        Location loc18     = new Location(LOCATION_ID_LOC18, "Empty location");
        Location loc19     = new Location(LOCATION_ID_LOC19, "Zone 1");
        Location loc20     = new Location(LOCATION_ID_LOC20, "Zone 1");
        Location loc21     = new Location(LOCATION_ID_LOC21, "Zone 1");
        Location loc22     = new Location(LOCATION_ID_LOC22, "Empty location");
        Location loc23     = new Location(LOCATION_ID_LOC23, "Empty location");
        Location loc24     = new Location(LOCATION_ID_LOC24, "Empty location");
        Location loc25     = new Location(LOCATION_ID_LOC25, "Zone 1");
        Location loc26     = new Location(LOCATION_ID_LOC26, "Empty location");
        Location loc27     = new Location(LOCATION_ID_LOC27, "Empty location");
        Location loc28     = new Location(LOCATION_ID_LOC28, "Empty location");
        Location loc29     = new Location(LOCATION_ID_LOC29, "Empty location");
        Location loc30     = new Location(LOCATION_ID_LOC30, "Empty location");
        Location loc31     = new Location(LOCATION_ID_LOC31, "Empty location");
        Location loc32     = new Location(LOCATION_ID_LOC32, "Empty location");
        Location loc33     = new Location(LOCATION_ID_LOC33, "Empty location");
        Location loc34     = new Location(LOCATION_ID_LOC34, "Empty location");
        Location loc35     = new Location(LOCATION_ID_LOC35, "Empty location");
        Location loc36     = new Location(LOCATION_ID_LOC36, "Empty location");
        Location loc37     = new Location(LOCATION_ID_LOC37, "Empty location");
        Location loc38     = new Location(LOCATION_ID_LOC38, "Empty location");
        Location loc39     = new Location(LOCATION_ID_LOC39, "Empty location");
        Location loc40     = new Location(LOCATION_ID_LOC40, "Empty location");


        /* Map of locations
         * +---+
         * |123|
         * | 4 |
         * | 56|
         * +---+
         */

        // Link the locations together
        loc1.LocationToNorth = loc2;

        loc2.LocationToWest = loc3;
        loc2.LocationToEast = loc5;
        loc2.LocationToSouth = loc1;

        loc3.LocationToEast = loc2;
        loc3.LocationToNorth = loc4;

        loc4.LocationToSouth = loc3;

        loc5.LocationToNorth = loc6;
        loc5.LocationToWest = loc2;

        loc6.LocationToEast = loc7;
        loc6.LocationToSouth = loc5;

        loc7.LocationToWest = loc6;
        loc7.LocationToNorth = loc8;
        loc7.LocationToEast = loc10;

        loc8.LocationToSouth = loc7;
        loc8.LocationToNorth = loc9;

        loc9.LocationToSouth = loc8;

        loc10.LocationToWest = loc7;
        loc10.LocationToSouth = loc11;

        loc11.LocationToNorth = loc10;

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

    }
}