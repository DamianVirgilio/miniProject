using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Program
{
    public static void Main()
    {
        Console.WriteLine
        (@"
        You open your eyes and realize that you're in a lift that speeds up and abruptly halts.
        A group of young men open the lift and one of them shoves you out.
        You start running but before getting too far you realize that the whole area is walled off.

        They then imprison you and not long after one of the young met free you.
        His name is Alby.

        Alby asks you who you are, but you have no memory.
        He then tells you that it's normal since nobody had memory on arrival.

        He further explains that all the young men known as *GLADERS* work together to gether food and build shelters.
        He also says that the lift where you came from known as *THE BOX* is sent up once a month to deliver anything that they need.
        It also always carries a new person up but no one ever has any memory.

        Alby introduces you to Newt, his second in command.

        That day you notice an opening in the wall so Alby quickly explains that going beyond the wall is prohibited.

        Later that day, a younger teenager named Chuck comes to help you set up a place to sleep.
        He also hands you a *WOODEN SPEAR* and a *COMPASS*
        ");

        Weapons WoodenSpear = new Weapons("WoodenSpear", 10);

        //[ADD WOODEN SPEAR AND COMPASS]
        
        //[CHECK WHAT IS AVAILIBLE TO DO IN BASE]
        
        System.Console.WriteLine
        (@" 
        Choose what you want to do in your base:
        1. Sleep
        2. Use Crafting Bench
        3. Exit and Continue
        ");

        //[WHEN EXITING BASE]

        Console.WriteLine
        (@"
        You and chuck head to the opening in the wall.
        2 Runners come out of the Wall and Chuck clarifies that one one except runners are allowed past the Walls.

        Newt comes to you and explains that past the Wall lies a Maze. He further says that the Runners have been mapping the maze for 3 years.
        He further points out that there is a sublte sound that echoes around them noting that it is the mazed that is constantly changing.
        Only the strongers and fastest Gladers can be Runners because no one has been able to survive being stuck through the night.
        He then tells you about the mechanical Monsters called Grievers that kill whoever gets stuck in the Maze.

        Later that day you declare that you want to be a runner.
        As soon as you say that you want to be a runner, one of the Gladers called Gally challenges you to spar.
        ");

        //[HAND COMBAT, YOU VS GALLY]
        //[HE FIRST DEFEATS YOU AND TAUNTS YOU BUT THEN YOU FIND A WAY TO USE HIS OWN STRENGTH AGAINST HIM]
        //[IMPORTANT: AT THE END OF THE FIGHT YOU FALL AND HIT YOUR HEAD]

        Console.WriteLine
        (@"
        You suddenly remember your NAME!
        ");

        Console.WriteLine("What is your Name?");
        string Username = System.Console.ReadLine();
        Player player = new Player(Username, World.Locations[0]);

        Console.WriteLine
        (@$"
        You scream that your name is {Username}
        The Gladers celibrate and welcome you to the group, even Gally.

        The celebration cuts when something wails in the distance.
        Gally notes that that is a Griever which luckily cannot get past the Walls.

        When you sleep, you get flashes of MEMORY.
        You see FACES of DOCTORS and a *YOUNG WOMAN*

        In the morning ALBY takes you for a walk. He notes that it wasn't always this peaceful in the Glade.
        Others died due to FEAR, so they established order to maintain peace.
        Alby notes that you are very curious unlike the others but even whith that you have to follow the rules.

        Later you help with farming while coming up with ways to escape.
        Everything you come up with has already been tried and failed.

        You then head to the woods, but one of the Gladers; Ben SUDDENLY appears and JUMPS on you.
        He LOOKS SICK and JUMPS on you and attemps to CHOKE you!
        ");

        //[TRY TO BREATHE]
        //[FIND AN OBJECT NEAR YOU TO SLAM BENS HEAD TO ESCAPE]

        Console.WriteLine
        (@"
        After slamming [OBJECT] on his head you run and try to escape.
        You RUN back to the Glade and get into a FIGHT with Ben!
        ");

        //[HAND COMBAT, YOU VS BEN]
        //[YOU GRAB YOUR SPEAR AND THROW IT STRAIGHT INTO BENS HEAD]

        Console.WriteLine
        (@"
        All the gladers come and see Ben lying dead on the floor.
        You explain that Ben just ATTACKED YOU out of nowhere!
        Newt Comes and lifts up Ben's Shirt showing an infected wound.

        Alby explains that Ben was stung by a Griever causing him to be infected by *THE CHANGING*
        Albny asks what Ben said to you.
        You say that Ben said that everything was your fault.

        By nightfall the Gladers dump Ben's body in the Maze.

        That evening you dream about a laboratory and a scientist who assures you that *WCKD* is good!
        You see the young woman's face again and she promises that everything will change.
        You wake up and find Minho and Alby heading inside the Maze.
        You wonder why Alby went in since he's not a runner.
        Newt assumes that Alby wanted to track if Ben's body got eaten.
        Newt insists that they all trust Alby since he was the first one to arrive at the Glade.
        He helped everyone who came after.

        The Gladers wait for them to return near nightfall, but the doors soon start closing.
        Suddenly they spot Minho carrying an Injured Alby.
        Everyone SCREAMS for him to cross without Alby but with the doors nearly closed Minho is still far behind.

        You IMPULSIVELY slip inside  barelyg making it to the other side before the doors fully close.
        The two of you check on Alby who got stung.

        The Grievers start wailing into the distance and the walls start to move.
        Minho gets up to leave Alby behind but you insist on not leaving him.
        The two of you traverse the maze while carrying Alby!

        You notice vine on the walls so the two of you hoist Alby to hide him up in the vines.
        
        A GRIEVER JUMPS ON YOU!

        You have 2 options:
        1. Use Your Spear
        2. Use Tactical Strategy
        ");

        player.EquippedWeapon = WoodenSpear;
        
        string SpearOrTacticalStrat = Console.ReadLine();
        if (SpearOrTacticalStrat == "1")
        {
            Enemy enemy = Enemy.GetEnemy("Sector 1");
            player.Combat(player, enemy);
            
        }
        else if (SpearOrTacticalStrat == "2")
        {
            Console.WriteLine
            (@"
            You Started RUNNING while the Griever is coming after you!
            You SEE an OPENING and JUMP through!
            He STILL follows you while you run past a few WALLS CLOSING!
            You squeeze through TWO of the CLOSING WALLS!
            YOU BARELY GET OUT!
            The Griever gets STUCK inside and gets KILLED!
            ");
        }

        Console.WriteLine
        (@"
        While finding the exit of the Maze you find a slingshot.
        You take it and Equip it.
        ");
        
        Weapons SlingShot = new Weapons("SlingShot", 30);
        player.EquippedWeapon = SlingShot;

        Console.WriteLine
        (@"
        The next day the Maze opens and to everyone's surprise they see the two of you carrying Alby back.
        
        Minho announces: '[NAME] KILLLED A GRIEVER!'

        All of you return to the Council Hall...
        Gally Highlights: [NAME] killing a Griever could spell trouble for the others.
        No one knows what happens when you kill a griever.
        Minho Announces that [NAME] is now a RUNNER!

        Suddenly they hear something moving outside:
        *THE BOX* is being lifted up outside out of the normal schedule!

        When they open it:
        They see a young Woman with a note in her hand.
        The Note says: 'SHE'S THE LAST ONE! EVER!'

        Suddenly she WAKES up and GHASPS [NAME] before passing out.

        Newt asks you if you know her but you SAY that you don't.
        The others get nervous with the idea of the box not returning anymore supplies.

        You decide to gack to the Maze but you're stopped by Minho.
        You point out that no one has ever captured or killed a griever before.
        It would be in our best intrest to investigate the body.
        ");

        //[GO BACK INTO THE MAZE TO THE GRIEVERS BODY]

        Console.WriteLine
        (@"
        You look at the Griever and pull out the Grievers LEG which then comes apart.
        You find a *CILINDER-LIKE DEVICE* inside of it's leg.
        The device has a little light which is 'RED', the NUMBER '4' and a LABEl: 'WCKD'.
        ");

        //[RETURN TO THE GLADE]
        //[RETURN TO BASE OR EXPLORE MAZE]
        //[EXPLORE ALL SECTORS (1-4)]

        //[CONTINUE STORY AFTER EXPLORING ALL SECTORS]

        Console.WriteLine
        (@"
        Minho and you look at the number on the *CILINDER-LIKE-DEVICE*
        You take a look at the NUMBER: '4'.

        The maze is devided into 4 SECTORS.
        That could mean that the Griever probably came from sector 4.

        Finally the girl wakes up but has climbed the watch tower and throws rocks at the Gladers.
        You get her to stop.
        You climb up the tower but when you reach the top you find her holding a knife.
        You calm her down and she reveals that her name is Theresa.
        You introduce yourself and she claims that she doesn't know you.

        Later you mention to her that she came with *The Note*.
        The Box hasn't lowered since.
        She recalls being in the water, being watched over by people and a woman that mentions that *WCKD* is good.
        You recall seeing the woman that said *WCKD* is good.
        The two of you wonder why no one else has memories other than their names.
        Theresa shows you 2 syringes that she found in her pocket with the label *WCKD*.

        You get the idea of injecting Alby that is infected with *THE CHANGING* with one of these syringes.
        You hold Alby down while theresa INJECTS him with one of the syringes.
        He immediately loses conciousness.

        The two of them head to *THE PIT*
        You ask why gally HATES you.
        He reveals that everything started falling apart as soon as you arrived.

        Chuck comes up to you to talk to you about what it's like to live outside of the walls and if he will ever meet his parents.
        He hands you a toy that he said he thinks came from his parents.
        He wants you find his parents and give it to them.
        You assure Chuck that you will find a way for all of you escape and hand him back his toy.
        You tell him that he will get the chance to give his toy to his parents himself.


        By sunrise You amd Minho run back into the maze and see that *SECTOR 4* is open again eventhough it's not supposed to be.
        The *CILINDER-LIKE-DEVICE starts beeping.
        They follow to where the beep STOPS.
        When they reach a dead end, the small light on the CILINDER-LIKE-DEVICE turns *GREEN*.
        Suddenly the walls open a path.
        At the end of the path a *RED* light scans them.
        The light turns *GREEN* and they see a way to leave the maze.

        Suddenly the WALLS start CLOSING.
        Minho and you run back to The Glade.

        When arriving in The Glade:
        You see that the main walls stay open during the NIGHT.
        Grievers start coming in and you GATHER everyone to escape.

        Run back to SECTOR 4 with EVERYONE:
        ");

        //[RUN THROUGH THE MAZE TO SECTOR 4]

        Console.WriteLine
        (@"
        Uppon arrival at SECTOR 4, you get greeted with a puzzle:
        ");

        //[END GAME PUZZLE]

        Console.WriteLine
        (@"
        PUZZLE COMPLETED:
        The DOORS OPEN and everyone ESCAPES.

        The outisde world looks like an ABANDONED DESERT with BARRON SKYSCRAPERS.
        An EMPTY world with NO ONE AROUND.
        ");
  
        System.Console.WriteLine(player.CurrentLocation);
        System.Console.WriteLine(player.Name);
        System.Console.WriteLine(player.Health);
        System.Console.WriteLine(player.Strength);
        System.Console.WriteLine(player.Medkit);
        // Enemy enemy1 = Enemy.GetEnemy("S");
        // System.Console.WriteLine(enemy1.NameEnemy);
        // Enemy enemy2 = Enemy.GetEnemy(2);
        // System.Console.WriteLine(enemy2.NameEnemy);
        // Enemy enemy3 = Enemy.GetEnemy(3);
        // System.Console.WriteLine(enemy3.NameEnemy);
        // Enemy enemy4 = Enemy.GetEnemy(4);
        // System.Console.WriteLine(enemy4.NameEnemy);
        // Enemy enemy5 = Enemy.GetEnemy(5);
        // System.Console.WriteLine(enemy5.NameEnemy);

        List<string> passwordList = new List<string>();
        int time_count = 7;
        bool check_boltcutter = false; // gedaan
        bool check_bandage = false; // gedaan
        bool check_B = false;
        bool check_D = false;
        bool check_M = false;
        bool check_N = false;
        bool check_riddle = false; // gedaan
        bool check_assaultrifle = false; // gedaan
        bool check_grieverfight = false; // gedaan soortvan
        bool check_stungun = false; // gedaan
        bool check_handgun = false; // gedaan
        bool check_shovel = false; // gedaan
        bool check_medkit = false; // gedaan
        bool check_watch = false;
        string DayOrNight = "Day";
        while (player.CurrentLocation.Name != "Goal")
        {
            Console.WriteLine("Current sector: " + player.CurrentLocation.Name);
            Console.WriteLine(player.CurrentLocation.Compass());
            System.Console.WriteLine("Where do you want to go? (N/E/S/W)");
            string LocationMove = System.Console.ReadLine().ToUpper();
            if (LocationMove == "I")
            {
                player.ShowChoices(player.EquippedWeapon, time_count, check_watch);
            }

            else if (LocationMove == "N" || LocationMove == "W" || LocationMove == "S" || LocationMove == "E")
            {

            if (player.CurrentLocation.GetLocationAt(LocationMove).Sector == "Home" && DayOrNight == "Night")
            {
                System.Console.WriteLine("The doors are closed you can't return home (watch out for grievers...)");
            }

            if (player.CurrentLocation.GetLocationAt(LocationMove).Name == "Gate 2" && check_grieverfight)
            {
                player.TryMoveTo(player.CurrentLocation.GetLocationAt(LocationMove));
                System.Console.WriteLine("You have opened the gate to sector 2. ");
            }

            else if (player.CurrentLocation.GetLocationAt(LocationMove).Name == "Gate 2" && !check_grieverfight)

            {
                System.Console.WriteLine("You can't move to this sector yet");
            }
            else if (player.CurrentLocation.GetLocationAt(LocationMove).Sector == "Sector 3" && check_boltcutter)
            {
                player.TryMoveTo(player.CurrentLocation.GetLocationAt(LocationMove));
                System.Console.WriteLine
                (@"
                you are standing infront of the gate to sector 3. There is a very big padlock locking the gate
                Lucky you just found a big boltcutter. 
                ");
            }
            else if (player.CurrentLocation.GetLocationAt(LocationMove).Sector == "Sector 3" && !check_boltcutter)
            {
                System.Console.WriteLine("You can't move to this sector yet");
            }
            else if (player.CurrentLocation.GetLocationAt(LocationMove).Sector == "Sector 4" && check_shovel)
            {
                player.TryMoveTo(player.CurrentLocation.GetLocationAt(LocationMove));
                System.Console.WriteLine("there is a wall between sector 3 and 4. You dig through it with your shovel. ");
            }
            else if (player.CurrentLocation.GetLocationAt(LocationMove).Sector == "Sector 4" && !check_shovel)
            {
                System.Console.WriteLine("You can't move to this sector yet");
            }
            // sectors 
            else if (player.CurrentLocation.GetLocationAt(LocationMove).Name == "Boltcutter" && !check_boltcutter)
            {
                player.TryMoveTo(player.CurrentLocation.GetLocationAt(LocationMove));
                Items Boltcutter = new Items("boltcutter");
                check_boltcutter = true;
            }
            else if (player.CurrentLocation.GetLocationAt(LocationMove).Name == "Riddle" && !check_riddle)
            {
                while (!check_riddle)
                {
                    player.TryMoveTo(player.CurrentLocation.GetLocationAt(LocationMove));
                    System.Console.WriteLine(@"There is a riddle written on the wall. It reads:
                    I am a path with walls on each side, 
                    Twists and turns where you must decide. 
                    Dead ends and choices to make, 
                    Navigate wisely, don't make a mistake.
                    What am I?
                    ");
                    string riddleAwnser = Console.ReadLine().ToUpper();

                    if (riddleAwnser == "MAZE")
                    {
                        check_riddle = true;
                        System.Console.WriteLine("You got it right!");
                        System.Console.WriteLine("A small trapdoor opens and inside is a shovel! You may need this to get in another sector. ");
                        check_shovel = true;
                    }
                    else
                    {
                        System.Console.WriteLine("That does not seem to be the awnser but the gods of the maze are kind enough to let you try again. ");
                    }
                };
            }
            else if (player.CurrentLocation.GetLocationAt(LocationMove).Name == "Assault Rifle" && !check_assaultrifle)    
            {
                player.TryMoveTo(player.CurrentLocation.GetLocationAt(LocationMove));
                System.Console.WriteLine(@"You find an Assault rifle on the ground. You wonder who left it there.... 
                Acquires Assault Rifle!");
                player.EquippedWeapon = new Weapons("Assault Rifle", 250);
                check_assaultrifle = true;
            }     

            else if (player.CurrentLocation.GetLocationAt(LocationMove).Name == "B" && !check_B)
            {
                System.Console.WriteLine($"You see a paper with a letter on the ground its the letter B. You take the paper. ");
                passwordList.Add("B");
                check_B = true;

            }

            else if (player.CurrentLocation.GetLocationAt(LocationMove).Name == "D" && !check_D)
            {
                System.Console.WriteLine($"You see a paper with a letter on the ground its the letter D. You take the paper. ");
                passwordList.Add("D");
                check_D = true;
            }

            else if (player.CurrentLocation.GetLocationAt(LocationMove).Name == "M" && !check_M)
            {
                System.Console.WriteLine($"You see a paper with a letter on the ground its the letter M. You take the paper. ");
                passwordList.Add("M");
                check_M = true;
            }

            else if (player.CurrentLocation.GetLocationAt(LocationMove).Name == "N" && !check_N)
            {
                System.Console.WriteLine($"You see a paper with a letter on the ground its the letter N. You take the paper. ");
                passwordList.Add("N");
                check_N = true;
            }
            
            else if (player.CurrentLocation.GetLocationAt(LocationMove).Name == "GrieverFight" && !check_grieverfight)
            {
                player.TryMoveTo(player.CurrentLocation.GetLocationAt(LocationMove));
                check_grieverfight = true;
            }

            else if (player.CurrentLocation.GetLocationAt(LocationMove).Name == "Stungun" && !check_stungun)
            {
                player.TryMoveTo(player.CurrentLocation.GetLocationAt(LocationMove));
                System.Console.WriteLine(@"You see a dead body... but he is holding a stungun!
                You take it because he does not need it anymore. ");
                player.EquippedWeapon = new Weapons("StunGun", 50);
                check_stungun = true;
            }
            else if (player.CurrentLocation.GetLocationAt(LocationMove).Name == "Watch" && !check_watch)
            {
                player.TryMoveTo(player.CurrentLocation.GetLocationAt(LocationMove));
                System.Console.WriteLine(@"You see light reflecting of a metal object.
You walk towards and see that it's a watch! You can now see the time in your inventory");
                check_watch = true;
            }

            else if (player.CurrentLocation.GetLocationAt(LocationMove).Name == "Handgun" && !check_handgun)
            {
                player.TryMoveTo(player.CurrentLocation.GetLocationAt(LocationMove));
                System.Console.WriteLine(@"You find a dead griever and see a Handgun in its stomach. 
                You wonder and ponder how it ended up there before you pick it up...
                Handgun acquired!");
                player.EquippedWeapon = new Weapons("Handgun", 100);
                check_handgun = true;
            }

            else if (player.CurrentLocation.GetLocationAt(LocationMove).Name == "Medkit" && !check_medkit)
            {
                player.TryMoveTo(player.CurrentLocation.GetLocationAt(LocationMove));
                System.Console.WriteLine("You have found a medkit!");
                player.PickUpMed(1);
                check_medkit = true;
            }

            else if (player.CurrentLocation.GetLocationAt(LocationMove).Name == "Bandage" && !check_bandage)
            {
                player.TryMoveTo(player.CurrentLocation.GetLocationAt(LocationMove));
                System.Console.WriteLine("You have found a  bandage!");
                player.PickUpBandaid(1);
                check_bandage = true;
            }

            else if (player.CurrentLocation.GetLocationAt(LocationMove).Name == "Goal")
            {
                System.Console.WriteLine("There seems to be a keypad. It asks you to enter a code. ");
                System.Console.WriteLine("Enter code: ");
                string code = Console.ReadLine().ToUpper();

                if (code == "BADMAN")
                {
                    player.TryMoveTo(player.CurrentLocation.GetLocationAt(LocationMove));
                }
                else
                {
                    System.Console.WriteLine("That awnser was wrong. You walk away dissapointed but hopeful. ");
                }
            }
            else
            {
                player.TryMoveTo(player.CurrentLocation.GetLocationAt(LocationMove));
            };
            if (DayOrNight == "Night")
            {
                Random random = new Random();
                int randint = random.Next(4);
                if (randint == 1)
                {
                    Enemy enemy = Enemy.GetEnemy(player.CurrentLocation.Sector);
                    System.Console.WriteLine($"You have encountered a {enemy.NameEnemy}, prepare for battle!");
                    player.Combat(player, enemy);
                }
            }
            if (!player.IsAlive())
            {
                player.CurrentLocation.ID = 1;
            }
            if (time_count == 24)
            {
                time_count = 0;
            }
            else
            {
                time_count += 1
            }
        }

            else
            {
                System.Console.WriteLine("Invalid input");
            }
        }
        System.Console.WriteLine("You have arrived at the goal!");
}
            }
 