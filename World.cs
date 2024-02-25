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
        Location loc1Start = new Location(LOCATION_ID_LOC1, "Start");
        Location loc2      = new Location(LOCATION_ID_LOC2, "Empty location");
        Location loc3      = new Location(LOCATION_ID_LOC3, "Empty location");
        Location loc4      = new Location(LOCATION_ID_LOC4, "Goal");
        Location loc5      = new Location(LOCATION_ID_LOC5, "Empty location");
        Location loc6      = new Location(LOCATION_ID_LOC6, "Empty location");
        Location loc7      = new Location(LOCATION_ID_LOC7, "Empty location");
        Location loc8      = new Location(LOCATION_ID_LOC8, "Empty location");
        Location loc9      = new Location(LOCATION_ID_LOC9, "Empty location");
        Location loc10     = new Location(LOCATION_ID_LOC10, "Empty location");
        Location loc11     = new Location(LOCATION_ID_LOC11, "Empty location");


        /* Map of locations
         * +---+
         * |123|
         * | 4 |
         * | 56|
         * +---+
         */

        // Link the locations together
        loc1Start.LocationToNorth = loc2;

        loc2.LocationToWest = loc3;
        loc2.LocationToEast = loc5;
        loc2.LocationToSouth = loc1Start;

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

        Locations.Add(loc1Start);
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
    }
}