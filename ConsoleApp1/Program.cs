// Spel ide, Spelaren är en äventyrare som ska ge sig in i den ny världen och bli starkare så de kan skydda det som de bryr sig om
// Spelet börjar med att vi får veta lite om äventyraren och historian bakom denna värld man ger sig in i och staden, Elysium.
// Spelet börjar

// Del 1.

// Splearen får välja mellan mage och swordsman.
// Spelaren får välja namn på sin karaktär 
// Spelaren går till sin class guild house och ska få sina abilities och skills.
// Slumpar mellan en lista på abilities beroende på den klass man väljer.
// Går till quest boarden som finns i guild houses och får 3 options.
// Quest 1: 
// Quest 2: 
// Quest 3: 
// Spelaren väljer vilken quest de vill ha och får se infon om vilka rewards man får av questen.
// Man blir teleporterad till questen.

// Start

using System.ComponentModel;
using System.Formats.Asn1;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

everything();
static void everything()
{

    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[~~~~Welcome to the world of Rodirion~~~~]");
    Thread.Sleep(1000);
    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Rodirion is a land recovering from the great cataclysm 100 years ago where the demon realm invaded");
    Thread.Sleep(1200);
    Console.WriteLine("Wreckage and chaos spread throughout the lands as demons took over a big part of the continent.");
    Thread.Sleep(1200);
    Console.WriteLine("Humanity started recovering and the age of Renewal began, more adventurers trained and wanted to head into the new world");
    Thread.Sleep(1200);
    Console.WriteLine("Now its time for you adventurer to join the battle and go out into the world.");
    Thread.Sleep(1000);
    Console.WriteLine("\n[Press enter to start game]");
    Console.ReadLine();
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[Welcome to the start of your adventure]");
    Thread.Sleep(200);

    List<Ability> myAbilities = [];

    // // Choose class.
    Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Now choose your class\nWill you take the roll of Mage or Swordsman\nMage\n[140 Hp, 120 mana, 100 gold] \nSwordsman\n[140 hp, 90 stamina, 100 gold]?"); Console.ForegroundColor = ConsoleColor.White;

    // Stats för mage
    int health = 140;
    int mana = 120;
    // Stats för swordsman
    int stamina = 90;
    string class1 = "";

    bool classchoice = true;
    while (classchoice == true)
    {
        class1 = Console.ReadLine().ToLower();
        classchoice = false;
        if (class1 != "mage" && class1 != "swordsman" && class1 != "swordman")
        {
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("[ERROR]Please choose one of the mentioned classes."); Console.ForegroundColor = ConsoleColor.White;
            classchoice = true;
        }
        else if (class1 == "mage")
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Ah i see we have a magic wielder present, a mage is a mighty choice for a adventurer like you");
        }
        else if (class1 == "swordsman" || class1 == "swordman")
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Ah a might swordsman we got here, a mighty warrior like you will do great deeds.");
        }
    }
    Thread.Sleep(1000);
    // Choose name
    Console.WriteLine($"Now you have chosen a {class1} now what is your name adventurer\n[Choose a name between 1-10 letters] "); Console.ForegroundColor = ConsoleColor.White;
    bool namesucces = true;
    string name = "";

    while (namesucces == true)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("???: ");
        name = Console.ReadLine();
        namesucces = int.TryParse(name, out int ä);

        if (namesucces == true)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("[ERROR]Please type a name between 1-10 letters"); Console.ForegroundColor = ConsoleColor.White;
        }
        if (name.Length > 10)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("[ERROR]Please type a name between 1-10 letters"); Console.ForegroundColor = ConsoleColor.White;
            namesucces = true;
        }
        if (name.Length < 1)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("[ERROR]Please type a name between 1-10 letters"); Console.ForegroundColor = ConsoleColor.White;
            namesucces = true;
        }
        else if (name.Length >= 1 && name.Length <= 10)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"Welcome {name} to the world of Rodirion\nYour adventure begins here");
        }
    }
    Thread.Sleep(500);
    Console.WriteLine($"Press enter to go to the {class1} Guild");
    Console.ReadLine();
    Console.Clear();
    // Go to respective class guild.
    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"You enter the {class1} guild and you start to walk towards the counter.");
    Thread.Sleep(200);
    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"Clerk: Welcome adventurer to the {class1} guild");
    Thread.Sleep(200);
    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine($"{name}: Hello i would like to register and get my abilities");
    Thread.Sleep(200);
    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Clerk: Of course one second you will recieve 3 skills");
    Thread.Sleep(200);
    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine($"{name}: I would also like to see the available skills");
    Thread.Sleep(200);

    // Mage abilities here.
    // List<string> mageability = ["Fireball[8-22 dmg 10 mana]", "Lightning bolt[14-28dmg 20 mana]", "Vine whip[9-12 dmg 5 mana]", "Heal pulse[20-30 hp 50 mana]", "Stone quake[25-30dmg 40 mana]", "Water gun[10-15 dmg 10 mana]", "Light beam[20-25 dmg 35 mana]"];
    List<Ability> mageAbilities = [
        new() {name = "Fireball[14-31 dmg 20 mana]", minDmg = 14, maxDmg = 31, mana=20},
        new() {name = "Lightning[18-38 dmg 25 mana]", minDmg = 18, maxDmg = 38, mana=25},
        new() {name = "Vine whip[12-50 dmg 25 mana]", minDmg = 12, maxDmg = 50, mana = 25},
        new() {name = "ice beam[0-120 dmg 55 mana]", minDmg = 0, maxDmg = 121, mana = 55},
        new() {name = "Stone quake[35-55 dmg 45 mana]", minDmg = 35, maxDmg = 55, mana = 45},
        new() {name = "Water gun[17-26 dmg 20 mana]", minDmg = 17, maxDmg = 26, mana = 20},
        new() {name = "Light beam[27-50 dmg 40 mana]", minDmg = 27, maxDmg = 50, mana = 40}
    ];

    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Clerk: Of course one second here is the list.");
    if (class1 == "mage")
    {
        Thread.Sleep(700);
        Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine($"List of avilable {class1} abilities");
        Thread.Sleep(700);
        for (int ma = 0; ma < mageAbilities.Count; ma++)
        {
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(mageAbilities[ma].name);
            Thread.Sleep(200);
        }
    }
    // Swordsman abilities here.
    List<Ability> swordAbilities = [
        new() {name = "Quick slash[16-56 dmg 25 stamina]", minDmg = 16, maxDmg = 56, stamina = 25},
        new() {name = "Heavy strike[17-28 dmg 15 stamina]", minDmg = 17, maxDmg = 28, stamina = 15},
        new() {name = "Wind cutter[13-26 dmg 10 stamina]", minDmg = 13, maxDmg = 26, stamina = 10},
        new() {name = "Crescent slash[23-38 dmg 20 stamina]", minDmg = 23, maxDmg = 38, stamina = 20},
        new() {name = "Heavenly sword[0-120 dmg 50 stamina]", minDmg = 0, maxDmg = 121, stamina = 50},
        new() {name = "Earthsplitter[30-58 dmg 35 stamina]", minDmg = 30, maxDmg = 58, stamina = 35},
        new() {name = "Shadow thrust[25-37 dmg 25 stamina]", minDmg = 25, maxDmg = 37, stamina = 25},
    ];
    if (class1 == "swordsman" || class1 == "swordman")
    {
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine($"List of avilable {class1} abilities");
        Thread.Sleep(200);
        for (int sa = 0; sa < swordAbilities.Count; sa++)
        {
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(swordAbilities[sa].name);
            Thread.Sleep(500);
        }
    }

    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[Press enter to register and get 3 abilities]");
    Console.ReadLine();
    Console.Clear();

    // Register to guild and get abilities

    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"Clerk: You have now registerd with the {class1} guild.\nNow you will get your abilities.");
    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Your first ability is");
    if (class1 == "mage")
    {
        List<Ability> choices = [];
        for (int n = 0; n < mageAbilities.Count; n++)
        {
            choices.Add(mageAbilities[n]);
        }

        for (int i = 0; i < 3; i++)
        {
            Ability tmp = choices[Random.Shared.Next(choices.Count)];
            myAbilities.Add(tmp);
            choices.Remove(tmp);
        }


        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(myAbilities[0].name);
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Your Second ability is");
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(myAbilities[1].name);
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Your Last ability is");
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(myAbilities[2].name);
        Thread.Sleep(500);
    }
    if (class1 == "swordsman" || class1 == "swordman")
    {
        List<Ability> choices = [];
        for (int n = 0; n < swordAbilities.Count; n++)
        {
            choices.Add(swordAbilities[n]);
        }


        for (int i = 0; i < 3; i++)
        {
            Ability smp = choices[Random.Shared.Next(choices.Count)];
            myAbilities.Add(smp);
            choices.Remove(smp);
        }


        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(myAbilities[0].name);
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Your Second ability is");
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(myAbilities[1].name);
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Your Last ability is");
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(myAbilities[2].name);
        Thread.Sleep(500);
    }
    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Clerk: These are the 3 abilities you get for now.\nNow will you go to:\n1.Shop\n2.Quest");

    string choice1 = "";

    bool choice = true;
    // Wallet
    int wallet = 100;
    int c = -1;
    List<string> options = ["shop", "quest"];
    while (options.Contains(choice1) == false || choice == true)
    {
        Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
        choice1 = Console.ReadLine().ToLower();
        choice = int.TryParse(choice1, out c);

        if (choice1 != "shop" && choice1 != "quest" && c != 1 && c != 2)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Please choose one of the mentioned choices."); Console.ForegroundColor = ConsoleColor.White;
            choice = true;
        }
        if (c == 1) choice1 = "shop";
        if (c == 2) choice1 = "quest";

        // Shoppen startar här
        if (choice1 == "quest")
        {
            choice = false;
            break;
        }
        if (choice1 == "shop")
        {
            choice = false;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("You start to head to the shop");

            Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("Shopkeeper: Ah i see i have a new customer and who might you be?");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine($"{name}: My name is {name}");
            Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine($"Shopkeeper: Welcome {name} these are my items for you");
            bool buyagain = true;
            while (buyagain == true)
            {
                List<string> shopitem = ["1. Mana necklace[+10 mana/stamina, 55 gold]", "2. Dark robe[15 mana/stamina, 10hp, 80 gold]", "3. Health ring[+ 5 health, 30 gold]", "4. Celestial grieves[ +30 hp 90 gold]", "5. Leave shop"];
                buyagain = false;
                Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Items");
                for (int ms = 0; ms < shopitem.Count; ms++)
                {
                    Thread.Sleep(100);
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(shopitem[ms]);
                    Thread.Sleep(100);
                }
                Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine($"What would you like to purchase? [you have {wallet} gold]");
                // Antalet saker man vill köpa
                string purchase = "";

                bool köp = true;
                while (köp == true)
                {
                    köp = false;
                    Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                    purchase = Console.ReadLine();
                    köp = int.TryParse(purchase, out int pu);
                    if (pu < 1 || pu > 5 || köp == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please choose 1, 2, 3, 4 or 5");
                        köp = true;
                    }
                    else if (pu == 1)
                    {
                        if (wallet < 55)
                        {
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Not enough money");
                            köp = true;
                        }
                        else if (wallet >= 55)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine($"You have purchased {shopitem[0]} for 55 gold");
                            mana += 10;
                            stamina += 10;
                            wallet -= 55;
                            köp = false;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("Would you like to purchase anything else"); Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                            string buyagain1 = Console.ReadLine().ToLower();
                            bool ba = true;
                            while (ba == true)
                            {
                                if (ba = false || buyagain1.Length == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("I asked if you wanted to purchase anything else");
                                }
                                else if (buyagain1 == "yes")
                                {
                                    Console.Clear();
                                    buyagain = true;
                                }
                                else if (buyagain1 == "no")
                                {
                                    Console.Clear();
                                    choice = true;
                                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Clerk: Would you like to go to\n1.Shop\n2.Quest");
                                }
                            }
                        }
                    }
                    else if (pu == 2)
                    {
                        if (wallet < 80)
                        {
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Not enough money");
                        }
                        else if (wallet >= 80)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine($"You have purchased {shopitem[1]} for 80 gold");
                            mana += 15;
                            stamina += 15;
                            health += 10;
                            wallet -= 80;
                            köp = false;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("Would you like to purchase anything else"); Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                            string buyagain2 = Console.ReadLine().ToLower();
                            bool la = true;
                            while (la == true)
                            {
                                if (la = false || buyagain2.Length == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("I asked if you wanted to purchase anything else");
                                }
                                else if (buyagain2 == "yes")
                                {
                                    Console.Clear();
                                    buyagain = true;

                                }
                                else if (buyagain2 == "no")
                                {
                                    Console.Clear();
                                    choice = true;
                                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Clerk: Would you like to go to\n1.Shop\n2.Quest");
                                }
                            }
                        }
                    }
                    else if (pu == 3)
                    {
                        if (wallet < 30)
                        {
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Not enough money");
                        }
                        else if (wallet >= 30)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine($"You have purchased {shopitem[2]} for 30 gold");
                            wallet -= 30;
                            health += 5;
                            köp = false;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("Would you like to purchase anything else"); Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                            string buyagain3 = Console.ReadLine().ToLower();
                            bool mpa = true;
                            while (mpa == true)
                            {
                                if (mpa = false || buyagain3.Length == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("I asked if you wanted to purchase anything else");
                                }
                                else if (buyagain3 == "yes")
                                {
                                    Console.Clear();
                                    buyagain = true;
                                }
                                else if (buyagain3 == "no")
                                {
                                    Console.Clear();
                                    choice = true;
                                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Clerk: Would you like to go to\n1.Shop\n2.Quest");
                                }
                            }
                        }
                    }
                    else if (pu == 4)
                    {
                        if (wallet < 90)
                        {
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Not enough money");
                        }
                        else if (wallet >= 90)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine($"You have purchased {shopitem[3]} for 90 gold");
                            wallet -= 90;
                            health += 30;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("Would you like to purchase anything else"); Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                            string buyagain4 = Console.ReadLine().ToLower();
                            bool hpa = true;
                            köp = false;
                            while (hpa == true)
                            {
                                if (hpa = false || buyagain4.Length == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("I asked if you wanted to purchase anything else");
                                }
                                else if (buyagain4 == "yes")
                                {
                                    Console.Clear();
                                    buyagain = true;
                                }
                                else if (buyagain4 == "no")
                                {
                                    Console.Clear();
                                    choice = true;
                                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Clerk: Would you like to go to\n1.Shop\n2.Quest");
                                }
                            }
                        }
                    }
                    else if (pu == 5)
                    {
                        köp = false;
                        Console.Clear();
                        choice = true;
                        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Clerk: Would you like to go to\n1.Shop\n2.Quest");
                    }
                }
            }
        }
    }
    // Quest start
    int r1 = Random.Shared.Next(40, 100);
    int r2 = Random.Shared.Next(40, 100);
    int r3 = Random.Shared.Next(40, 100);
    int er1 = Random.Shared.Next(2, 4);
    int er2 = Random.Shared.Next(2, 4);
    int er3 = Random.Shared.Next(2, 4);
    int round = 0;
    int bandh = 65 * er1;
    int gobh = 75 * er2;
    int wolfh = 70 * er3;

    List<Ability> goblinad = [
        new() {name = "Slash", minDmg = 5*er2, maxDmg = 7*er2},
        new() {name = "Pierce", minDmg = 4*er2, maxDmg = 8*er2},
        new() {name = "Stab", minDmg = 5*er2, maxDmg = 6*er2}
    ];
    List<Ability> banditad = [
        new() {name = "Kick", minDmg = 7*er1, maxDmg = 9*er1},
        new() {name = "Sever", minDmg = 6*er1, maxDmg = 10*er1},
        new() {name = "Punch", minDmg = 7*er1, maxDmg = 8*er1}
    ];
    List<Ability> wolfad = [
        new() {name = "Claw attack", minDmg = 5*er3, maxDmg = 7*er3},
        new() {name = "Bite", minDmg = 4*er3, maxDmg = 8*er3},
        new() {name = "Headbutt", minDmg = 5*er3, maxDmg = 7*er3}
    ];
    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("You walk up to the questboard");
    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("On the board you see 3 pieces of paper with different quests.\nChoose a quest");
    Thread.Sleep(500);
    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($""" 

_________________________      _________________________      _________________________
|        Quest 1        |      |        Quest 2        |      |        Quest 3        |
|  Defeat {er1} bandits     |      |  Defeat {er2} goblins     |      |  Defeat {er3} Wolfs       |
|                       |      |                       |      |                       |
|        Reward         |      |        Reward         |      |        Reward         |
|          {r1}           |      |          {r2}           |      |          {r3}           |
|         Gold          |      |         Gold          |      |         Gold          |
|_______________________|      |_______________________|      |_______________________|


""");
    // Välj quest
    string questchoice = "";
    bool quest = true;
    while (quest == true)
    {
        Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
        questchoice = Console.ReadLine();
        quest = int.TryParse(questchoice, out int qC);
        // Ifall du inte väljer en quest
        if (quest == false || qC <= 0 || qC > 3)
        {
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please choose quest 1,2 or 3"); Console.ForegroundColor = ConsoleColor.White;
            quest = true;
        }
        // Quset 3
        else if (qC == 3)
        {
            quest = false;
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"You run out of town and walk onto the plains.\nYou encounter {er3} Wolfs\n[Press enter to start battle]");
            Console.ReadLine();
            Console.Clear();
            bool bstart = true;
            while (bstart == true)
            {
                bstart = false;
                if (health <= 0)
                {
                    //    Message for when you die
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("""
         
                    ___  _  ____  _       ____   _   _____ ____ 
                    \  \// /  _ \/ \ /\  /  _ \ / \ /  __//  _ \
                     \  /  | / \|| | ||  | | \ | | | |  \  | | \ |
                     / /   | \_/|| \_/|  | |_/ | | | |  /_ | |_/ |
                    /_/    \____/\____/  \____/ \_/ \____\\____/
                                         
                 """);
                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Will you play again?[Yes/no]");
                    String playagain = Console.ReadLine().ToLower();
                    if (playagain == "yes")
                    {
                        everything();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Thank you for playing");
                        Console.ReadLine();
                    }
                }
                // Message when you win
                else if (wolfh <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("""
                    ___  _  ____   _   _    _    _  _  _    _ 
                    \  \// /  _ \ / \ / \  / \  / |/ \/ \  / |
                     \  /  | / \| | | | |  | |  | || || |\ | |
                     / /   | \_/| | \_/ |  | |/\| || || | \| |
                    /_/    \____/ \____/   \_/  \_|\_/\_/  \_|
                                     
                 """);
                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Will you play again?[Yes/no]");
                    String playagain = Console.ReadLine().ToLower();
                    if (playagain == "yes")
                    {
                        everything();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Thank you for playing");
                        Console.ReadLine();
                    }
                }
                else if (health > 0 && bandh > 0)
                {
                    if (class1 == "swordsman" || class1 == "swordman")
                    {
                        string battlec = "";
                        bool battle = true;
                        while (battle == true)
                        {
                            round++;
                            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine($"[~~~~~~Round {round} Start~~~~~~]");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"What will you do\n1.Attack\n2.Recover stamina\nYou have {stamina} stamina left");
                            Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                            battlec = Console.ReadLine();
                            battle = int.TryParse(battlec, out int b);
                            if (battle == false || battlec.Length == 0 || b <= 0 || b > 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please choose 1 or 2");
                                battle = true;
                            }
                            else if (battlec == "2")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("You rest and recover 15 stamina");
                                stamina += 15;
                                Thread.Sleep(200);
                                int wdmg = wolfad[Random.Shared.Next(0, 2)].Damage();
                                health -= wdmg;
                                Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine($"The Wolfs use {wolfad[Random.Shared.Next(0, 2)].name} and deal {wdmg} dmg");
                                Thread.Sleep(200);
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"You have {health} hp remaining");
                                Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[Press enter to start next round]");
                                Console.ReadLine();
                                Console.Clear();
                                battle = false;
                                bstart = true;
                            }
                            else if (battlec == "1")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"What ability will you use\n1.{myAbilities[0].name}\n2.{myAbilities[1].name}\n3.{myAbilities[2].name}\n4.Cancel attack");
                                string attack1 = "";
                                bool one = true;
                                while (one == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                                    attack1 = Console.ReadLine();
                                    one = int.TryParse(attack1, out int a1);
                                    if (one == false || battlec.Length == 0 || a1 <= 0 || a1 > 4)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please choose 1, 2, 3 or 4");
                                        one = true;
                                    }
                                    else
                                    {
                                        one = false;
                                        if (a1 - 1 == 3)
                                        {
                                            Console.Clear();
                                            battle = false;
                                            bstart = true;
                                        }
                                        else if (stamina - myAbilities[a1 - 1].stamina < 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Not enough mana");
                                            one = true;
                                        }
                                        else if (stamina - myAbilities[a1 - 1].stamina >= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"You use {myAbilities[a1 - 1].name}");
                                            Thread.Sleep(200);
                                            stamina -= myAbilities[a1 - 1].stamina;
                                            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"{stamina} Stamina Left");
                                            Thread.Sleep(200);
                                            int dmg = myAbilities[a1 - 1].Damage();
                                            wolfh -= dmg;
                                            Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine($"You deal {dmg} damage");
                                            int wdmg = wolfad[Random.Shared.Next(0, 2)].Damage();
                                            health -= wdmg;
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine($"The {er3} Wolfs have {wolfh} hp remaining");
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine($"The Wolfs use {wolfad[Random.Shared.Next(0, 2)].name} and deal {wdmg} dmg");
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"You have {health} hp remaining");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[Press enter to start next round]");
                                            Console.ReadLine();
                                            Console.Clear();
                                            battle = false;
                                            bstart = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (class1 == "mage")
                    {
                        string battlec = "";
                        bool battle = true;
                        while (battle == true)
                        {
                            round++;
                            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine($"[~~~~~~Round {round} Start~~~~~~]");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"What will you do\n1.Attack\n2.Recover mana\nYou have {mana} mana left");
                            Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                            battlec = Console.ReadLine();
                            battle = int.TryParse(battlec, out int b);
                            if (battle == false || battlec.Length == 0 || b <= 0 || b > 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please choose 1 or 2");
                                battle = true;
                            }
                            else if (battlec == "2")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("You recover 15 mana");
                                mana += 15;
                                Thread.Sleep(200);
                                int wdmg = wolfad[Random.Shared.Next(0, 2)].Damage();
                                health -= wdmg;
                                Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine($"The Wolfs use {wolfad[Random.Shared.Next(0, 2)].name} and deal {wdmg} dmg");
                                Thread.Sleep(200);
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"You have {health} hp remaining");
                                Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[Press enter to start next round]");
                                Console.ReadLine();
                                Console.Clear();
                                battle = false;
                                bstart = true;
                            }
                            else if (battlec == "1")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"What ability will you use\n1.{myAbilities[0].name}\n2.{myAbilities[1].name}\n3.{myAbilities[2].name}\n4.Cancel attack");
                                bool one = true;
                                while (one == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                                    string attack1 = Console.ReadLine();
                                    one = int.TryParse(attack1, out int a1);
                                    if (one == false || battlec.Length == 0 || a1 <= 0 || a1 > 4)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please choose 1, 2, 3 or 4");
                                        one = true;
                                    }

                                    else
                                    {
                                        one = false;
                                        if (a1 - 1 == 3)
                                        {
                                            Console.Clear();
                                            battle = false;
                                            bstart = true;
                                        }
                                        else if (mana - myAbilities[a1 - 1].mana < 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Not enough mana");
                                            one = true;
                                        }
                                        else if (mana - myAbilities[a1 - 1].mana >= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"You use {myAbilities[a1 - 1].name}");
                                            Thread.Sleep(200);
                                            mana -= myAbilities[a1 - 1].mana;
                                            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"{mana} Mana Left");
                                            Thread.Sleep(200);
                                            int dmg = myAbilities[a1 - 1].Damage();
                                            wolfh -= dmg;
                                            Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine($"You deal {dmg} damage");
                                            int wdmg = wolfad[Random.Shared.Next(0, 2)].Damage();
                                            health -= wdmg;
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine($"The {er3} Wolfs have {wolfh} hp remaining");
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine($"The Wolfs use {wolfad[Random.Shared.Next(0, 2)].name} and deal {wdmg} dmg");
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"You have {health} hp remaining");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[Press enter to start next round]");
                                            Console.ReadLine();
                                            Console.Clear();
                                            battle = false;
                                            bstart = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        // Quest 2
        else if (qC == 2)
        {
            quest = false;
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"You run out of town and walk into the mountains.\nYou encounter {er2} Goblins\n[Press enter to start battle]");
            Console.ReadLine();
            Console.Clear();
            bool bstart = true;
            while (bstart == true)
            {
                bstart = false;
                if (health <= 0)
                {
                    //    Message for when you die
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("""
         
                    ___  _  ____   _   _     ____   _  _____ ____ 
                    \  \// /  _ \ / \ / \   /  _ \ / \/  __//  _ \
                     \  /  | / \| | | | |   | | \ || ||  \  | | \ |
                     / /   | \_/| | \_/ |   | |_/ || ||  /_ | |_/ |
                    /_/    \____/  \____/   \____/ \_/\____\\____/
                                         
                 """);
                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Will you play again?[Yes/no]");
                    String playagain = Console.ReadLine().ToLower();
                    if (playagain == "yes")
                    {
                        everything();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Thank you for playing");
                        Console.ReadLine();
                    }
                }
                // Message when you win
                else if (gobh <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("""
                    ___  _  ____   _   _    _    _  _  _    _ 
                    \  \// /  _ \ / \ / \  / \  / |/ \/ \  / |
                     \  /  | / \| | | | |  | |  | || || |\ | |
                     / /   | \_/| | \_/ |  | |/\| || || | \| |
                    /_/    \____/  \____/  \_/  \_|\_/\_/  \_|
                                     
                 """);
                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Will you play again?[Yes/no]");
                    String playagain = Console.ReadLine().ToLower();
                    if (playagain == "yes")
                    {
                        everything();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Thank you for playing");
                        Console.ReadLine();
                    }
                }
                else if (health > 0 && gobh > 0)
                {
                    if (class1 == "swordsman" || class1 == "swordman")
                    {
                        string battlec = "";
                        bool battle = true;
                        while (battle == true)
                        {
                            round++;
                            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine($"[~~~~~~Round {round} Start~~~~~~]");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"What will you do\n1.Attack\n2.Recover stamina\nYou have {stamina} stamina left");
                            Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                            battlec = Console.ReadLine();
                            battle = int.TryParse(battlec, out int b);
                            if (battle == false || battlec.Length == 0 || b <= 0 || b > 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please choose 1 or 2");
                                battle = true;
                            }
                            else if (battlec == "2")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("You rest and recover 15 stamina");
                                stamina += 15;
                                Thread.Sleep(200);
                                int gdmg = goblinad[Random.Shared.Next(0, 2)].Damage();
                                health -= gdmg;
                                Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine($"The goblins use {goblinad[Random.Shared.Next(0, 2)].name} and deal {gdmg} dmg");
                                Thread.Sleep(200);
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"You have {health} hp remaining");
                                Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[Press enter to start next round]");
                                Console.ReadLine();
                                Console.Clear();
                                battle = false;
                                bstart = true;
                            }
                            else if (battlec == "1")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"What ability will you use\n1.{myAbilities[0].name}\n2.{myAbilities[1].name}\n3.{myAbilities[2].name}\n4.Cancel attack");
                                string attack1 = "";
                                bool one = true;
                                while (one == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                                    attack1 = Console.ReadLine();
                                    one = int.TryParse(attack1, out int a1);
                                    if (one == false || battlec.Length == 0 || a1 <= 0 || a1 > 4)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please choose 1, 2, 3 or 4");
                                        one = true;
                                    }

                                    else
                                    {
                                        one = false;
                                        if (a1 - 1 == 3)
                                        {
                                            Console.Clear();
                                            battle = false;
                                            bstart = true;
                                        }
                                        else if (stamina - myAbilities[a1 - 1].stamina < 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Not enough stamina");
                                            one = true;
                                        }
                                        else if (stamina - myAbilities[a1 - 1].stamina >= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"You use {myAbilities[a1 - 1].name}");
                                            Thread.Sleep(200);
                                            stamina -= myAbilities[a1 - 1].stamina;
                                            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"{stamina} Stamina Left");
                                            Thread.Sleep(200);
                                            int dmg = myAbilities[a1 - 1].Damage();
                                            gobh -= dmg;
                                            Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine($"You deal {dmg} damage");
                                            int gdmg = goblinad[Random.Shared.Next(0, 2)].Damage();
                                            health -= gdmg;
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine($"The {er2} Goblis have {gobh} hp remaining");
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine($"The goblins use {goblinad[Random.Shared.Next(0, 2)].name} and deal {gdmg} dmg");
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"You have {health} hp remaining");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[Press enter to start next round]");
                                            Console.ReadLine();
                                            Console.Clear();
                                            battle = false;
                                            bstart = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (class1 == "mage")
                    {
                        string battlec = "";
                        bool battle = true;
                        while (battle == true)
                        {
                            round++;
                            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine($"[~~~~~~Round {round} Start~~~~~~]");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"What will you do\n1.Attack\n2.Recover mana\nYou have {mana} mana left");
                            Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                            battlec = Console.ReadLine();
                            battle = int.TryParse(battlec, out int b);
                            if (battle == false || battlec.Length == 0 || b <= 0 || b > 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please choose 1 or 2");
                                battle = true;
                            }
                            else if (battlec == "2")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("You recover 15 mana");
                                mana += 15;
                                Thread.Sleep(200);
                                int gdmg = goblinad[Random.Shared.Next(0, 2)].Damage();
                                health -= gdmg;
                                Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine($"The Goblins  use {goblinad[Random.Shared.Next(0, 2)].name} and deal {gdmg} dmg");
                                Thread.Sleep(200);
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"You have {health} hp remaining");
                                Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[Press enter to start next round]");
                                Console.ReadLine();
                                Console.Clear();
                                battle = false;
                                bstart = true;
                            }
                            else if (battlec == "1")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"What ability will you use\n1.{myAbilities[0].name}\n2.{myAbilities[1].name}\n3.{myAbilities[2].name}\n4.Cancel attack");
                                string attack1 = "";
                                bool one = true;
                                while (one == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                                    attack1 = Console.ReadLine();
                                    one = int.TryParse(attack1, out int a1);
                                    if (one == false || battlec.Length == 0 || a1 <= 0 || a1 > 4)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please choose 1, 2, 3 or 4");
                                        one = true;
                                    }

                                    else
                                    {
                                        one = false;
                                        if (a1 - 1 == 3)
                                        {
                                            Console.Clear();
                                            battle = false;
                                            bstart = true;
                                        }
                                        else if (mana - myAbilities[a1 - 1].mana < 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Not enough mana");
                                            one = true;
                                        }
                                        else if (mana - myAbilities[a1 - 1].mana >= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"You use {myAbilities[a1 - 1].name}");
                                            Thread.Sleep(200);
                                            mana -= myAbilities[a1 - 1].mana;
                                            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"{mana} Mana Left");
                                            Thread.Sleep(200);
                                            int dmg = myAbilities[a1 - 1].Damage();
                                            gobh -= dmg;
                                            Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine($"You deal {dmg} damage");
                                            int gdmg = goblinad[Random.Shared.Next(0, 2)].Damage();
                                            health -= gdmg;
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine($"The {er2} Goblins have {gobh} hp remaining");
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine($"The Goblins use {goblinad[Random.Shared.Next(0, 2)].name} and deal {gdmg} dmg");
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"You have {health} hp remaining");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[Press enter to start next round]");
                                            Console.ReadLine();
                                            Console.Clear();
                                            battle = false;
                                            bstart = true;
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
        // Quest 1 
        else if (qC == 1)
        {
            quest = false;

            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"You run out of town and walk into the forest.\nYou encounter {er1} Bandits\n[Press enter to start battle]");
            Console.ReadLine();
            Console.Clear();
            bool bstart = true;
            while (bstart == true)
            {
                bstart = false;
                if (health <= 0)
                {
                    //    Message for when you die
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("""
         
                    ___  _ ____  _       ____  _  _____ ____ 
                    \  \///  _ \/ \ /\  /  _ \/ \/  __//  _ \
                     \  / | / \|| | ||  | | \|| ||  \  | | \|
                     / /  | \_/|| \_/|  | |_/|| ||  /_ | |_/|
                    /_/   \____/\____/  \____/\_/\____\\____/
                                         
                 """);
                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Will you play again?[Yes/no]");
                    String playagain = Console.ReadLine().ToLower();
                    if (playagain == "yes")
                    {
                        everything();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Thank you for playing");
                        Console.ReadLine();
                    }
                }
                // Message when you win
                else if (bandh <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("""
                    ___  _ ____  _   _    _    _  _  _    _ 
                    \  \///  _ \/ \ / \  / \  / |/ \/ \  / |
                     \  / | / \|| | | |  | |  | || || |\ | |
                     / /  | \_/|| \_/ |  | |/\| || || | \| |
                    /_/    \____/\____/  \_/  \_|\_/\_/  \_|
                                     
                 """);
                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Will you play again?[Yes/no]");
                    String playagain = Console.ReadLine().ToLower();
                    if (playagain == "yes")
                    {
                        everything();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Thank you for playing");
                        Console.ReadLine();
                    }
                }
                else if (health > 0 && bandh > 0)
                {
                    if (class1 == "swordsman" || class1 == "swordman")
                    {
                        string battlec = "";
                        bool battle = true;
                        while (battle == true)
                        {
                            round++;
                            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine($"[~~~~~~Round {round} Start~~~~~~]");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"What will you do\n1.Attack\n2.Recover stamina\nYou have {stamina} stamina left");
                            Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                            battlec = Console.ReadLine();
                            battle = int.TryParse(battlec, out int b);
                            if (battle == false || battlec.Length == 0 || b <= 0 || b > 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please choose 1 or 2");
                                battle = true;
                            }
                            else if (battlec == "2")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("You rest and recover 15 stamina");
                                stamina += 15;
                                Thread.Sleep(200);
                                int bdmg = banditad[Random.Shared.Next(0, 2)].Damage();
                                health -= bdmg;
                                Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine($"The bandits use {banditad[Random.Shared.Next(0, 2)].name} and deal {bdmg} dmg");
                                Thread.Sleep(200);
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"You have {health} hp remaining");
                                Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[Press enter to start next round]");
                                Console.ReadLine();
                                Console.Clear();
                                battle = false;
                                bstart = true;
                            }
                            else if (battlec == "1")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"What ability will you use\n1.{myAbilities[0].name}\n2.{myAbilities[1].name}\n3.{myAbilities[2].name}\n4.Cancel attack");
                                string attack1 = "";
                                bool one = true;
                                while (one == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                                    attack1 = Console.ReadLine();
                                    one = int.TryParse(attack1, out int a1);
                                    if (one == false || battlec.Length == 0 || a1 <= 0 || a1 > 4)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please choose 1, 2, 3 or 4");
                                        one = true;
                                    }

                                    else
                                    {
                                        one = false;
                                        if (a1 - 1 == 3)
                                        {

                                            Console.Clear();
                                            battle = false;
                                            bstart = true;
                                        }
                                        else if (stamina - myAbilities[a1 - 1].stamina < 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Not enough mana");
                                            one = true;
                                        }
                                        else if (stamina - myAbilities[a1 - 1].stamina >= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"You use {myAbilities[a1 - 1].name}");
                                            Thread.Sleep(200);
                                            stamina -= myAbilities[a1 - 1].stamina;
                                            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"{stamina} Stamina Left");
                                            Thread.Sleep(200);
                                            int dmg = myAbilities[a1 - 1].Damage();
                                            bandh -= dmg;
                                            Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine($"You deal {dmg} damage");
                                            int bdmg = banditad[Random.Shared.Next(0, 2)].Damage();
                                            health -= bdmg;
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine($"The {er1} Bandits have {bandh} hp remaining");
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine($"The bandits use {banditad[Random.Shared.Next(0, 2)].name} and deal {bdmg} dmg");
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"You have {health} hp remaining");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[Press enter to start next round]");
                                            Console.ReadLine();
                                            Console.Clear();
                                            battle = false;
                                            bstart = true;
                                        }
                                    }

                                }
                            }
                        }
                    }
                    if (class1 == "mage")
                    {
                        string battlec = "";
                        bool battle = true;
                        while (battle == true)
                        {
                            round++;
                            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine($"[~~~~~~Round {round} Start~~~~~~]");
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"What will you do\n1.Attack\n2.Recover mana\nYou have {mana} mana left");
                            Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                            battlec = Console.ReadLine();
                            battle = int.TryParse(battlec, out int b);
                            if (battle == false || battlec.Length == 0 || b <= 0 || b > 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please choose 1 or 2");
                                battle = true;
                            }
                            else if (battlec == "2")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("You recover 15 mana");
                                mana += 15;
                                Thread.Sleep(200);
                                int bdmg = banditad[Random.Shared.Next(0, 2)].Damage();
                                health -= bdmg;
                                Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine($"The bandits use {banditad[Random.Shared.Next(0, 2)].name} and deal {bdmg} dmg");
                                Thread.Sleep(200);
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"You have {health} hp remaining");
                                Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[Press enter to start next round]");
                                Console.ReadLine();
                                Console.Clear();
                                battle = false;
                                bstart = true;
                            }
                            else if (battlec == "1")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"What ability will you use\n1.{myAbilities[0].name}\n2.{myAbilities[1].name}\n3.{myAbilities[2].name}\n4.Cancel attack");
                                string attack1 = "";
                                bool one = true;
                                while (one == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.White; Console.Write($"{name}: ");
                                    attack1 = Console.ReadLine();
                                    one = int.TryParse(attack1, out int a1);
                                    if (one == false || battlec.Length == 0 || a1 <= 0 || a1 > 4)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please choose 1, 2, 3 or 4");
                                        one = true;
                                    }

                                    else
                                    {
                                        one = false;
                                        if (a1 - 1 == 3)
                                        {
                                            one = false;
                                            Console.Clear();
                                            battle = false;
                                            bstart = true;
                                        }
                                        else if (mana - myAbilities[a1 - 1].mana < 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Not enough mana");
                                            one = true;
                                        }
                                        else if (mana - myAbilities[a1 - 1].mana >= 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"You use {myAbilities[a1 - 1].name}");
                                            Thread.Sleep(200);
                                            mana -= myAbilities[a1 - 1].mana;
                                            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"{mana} Mana Left");
                                            Thread.Sleep(200);
                                            int dmg = myAbilities[a1 - 1].Damage();
                                            bandh -= dmg;
                                            Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine($"You deal {dmg} damage");
                                            int bdmg = banditad[Random.Shared.Next(0, 2)].Damage();
                                            health -= bdmg;
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine($"The {er1} Bandits have {bandh} hp remaining");
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine($"The bandits use {banditad[Random.Shared.Next(0, 2)].name} and deal {bdmg} dmg");
                                            Thread.Sleep(200);
                                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"You have {health} hp remaining");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[Press enter to start next round]");
                                            Console.ReadLine();
                                            Console.Clear();
                                            battle = false;
                                            bstart = true;
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }

    }
}


class Ability
{
    public string name;
    public int minDmg;
    public int maxDmg;
    public int mana;
    public int stamina;
    public int Damage()
    {
        return Random.Shared.Next(minDmg, maxDmg);
    }
}
