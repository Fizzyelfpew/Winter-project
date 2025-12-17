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
    
// Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[~~~~Welcome to the world of Rodirion~~~~]");
// Thread.Sleep(1000);
// Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Rodirion is a land recovering from the great cataclysm 100 years ago where the demon realm invaded");
// Thread.Sleep(1200);
// Console.WriteLine("Wreckage and chaos spread throughout the lands as demons took over a big part of the continent.");
// Thread.Sleep(1200);
// Console.WriteLine("Humanity started recovering and the age of Renewal began, more adventurers trained and wanted to head into the new world");
// Thread.Sleep(1200);
// Console.WriteLine("Now its time for you adventurer to join the battle and go out into the world.");
// Thread.Sleep(1000);
// Console.WriteLine("\n[Press enter to start game]");
// Console.ReadLine();
// Console.Clear();
// Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[Welcome to the start of your adventure]");
// Thread.Sleep(200);

// // Choose class.
Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Now choose your class\nWill you take the roll of Mage or Swordsman\nMage\n[140 Hp, 120 mana, 100 gold] \nSwordsman\n[140 hp, 90 stamina, 100 gold]?"); Console.ForegroundColor = ConsoleColor.White;

// Stats för mage
int health = 140;
int mana = 120;
// Stats för swordsman
int stamina = 90;
int i = 0;
int o = 0;
int p = 0;
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
Console.WriteLine($"No you have chosen a {class1} now what is your name adventurer\n[Choose a name between 1-10 letters] "); Console.ForegroundColor = ConsoleColor.White;
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
Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Clerk: Of course one second");
Thread.Sleep(200);
Console.ForegroundColor = ConsoleColor.White; Console.WriteLine($"{name}: I would also like to see the available skills");
Thread.Sleep(200);

// Mage abilities here.
List<string> mageability = ["Fireball[8-22 dmg 10 mana]", "Lightning bolt[14-28dmg 20 mana]", "Vine whip[9-12 dmg 5 mana]", "Heal pulse[20-30 hp 50 mana]", "Stone quake[25-30dmg 40 mana]", "Water gun[10-15 dmg 10 mana]", "Light beam[20-25 dmg 35 mana]"];

Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Clerk: Of course one second here is the list.");
if (class1 == "mage")
{
    Thread.Sleep(700);
    Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine($"List of avilable {class1} abilities");
    Thread.Sleep(700);
    for (int ma = 0; ma < mageability.Count; ma++)
    {
        Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(mageability[ma]);
        Thread.Sleep(200);
    }
}
// Swordsman abilities here.
List<string> swordability = ["Quick slash[6-10dmg 5 stamina]", "Heavy strike[15-22dmg 15 stamina]", "Wind cutter[10-16dmg 10 stamina]", "Crecent slash[18-24dmg 20 stamina]", "Heal[20-30 hp 50 stamina]", "Earthsplitter[25-32dmg 35 stamina]", "Shadow thrust[22-26dmg 20 stamina]"];
if (class1 == "swordsman" || class1 == "swordman")
{
    Thread.Sleep(500);
    Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine($"List of avilable {class1} abilities");
    Thread.Sleep(200);
    for (int sa = 0; sa < swordability.Count; sa++)
    {
        Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(swordability[sa]);
        Thread.Sleep(500);
    }
}

Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[Press enter to register and get abilities]");
Console.ReadLine();
Console.Clear();

// Register to guild and get abilities

Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"Clerk: You have now registerd with the {class1} guild.\nNow you will get your abilities.");
Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Your first ability is");
if (class1 == "mage")
{
    List<int> choices = [];
    for (int n = 0; n < mageability.Count; n++)
    {
        choices.Add(n);
    }

     i = choices[Random.Shared.Next(choices.Count)];
    choices.Remove(i);

     o = choices[Random.Shared.Next(choices.Count)];
    choices.Remove(o);

     p = choices[Random.Shared.Next(choices.Count)];
    choices.Remove(p);



    Thread.Sleep(500);
    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(mageability[i]);
    Thread.Sleep(500);
    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Your Second ability is");
    Thread.Sleep(500);
    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(mageability[o]);
    Thread.Sleep(500);
    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Your Last ability is");
    Thread.Sleep(500);
    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(mageability[p]);

}
if (class1 == "swordsman" || class1 == "swordman")
{
    List<int> choices = [];
    for (int n = 0; n < swordability.Count; n++)
    {
        choices.Add(n);
    }

     i = choices[Random.Shared.Next(choices.Count)];
    choices.Remove(i);

     o = choices[Random.Shared.Next(choices.Count)];
    choices.Remove(o);

     p = choices[Random.Shared.Next(choices.Count)];
    choices.Remove(p);

    Thread.Sleep(800);
    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(swordability[i]);
    Thread.Sleep(500);
    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Your Second ability is");
    Thread.Sleep(800);
    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(swordability[o]);
    Thread.Sleep(500);
    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Your Last ability is");
    Thread.Sleep(800);
    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(swordability[p]);
}
Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Clerk: These are the 3 abilities you get for now.\nNow would you have 2 options.\n1.Shop\n2.Quest");

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
    choice = false;
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
        buyagain = false;
        List<string> shopitem = ["1. Mana necklace[+10 mana/stamina, 55 gold]", "2. Dark robe[15 mana/stamina, 10hp, 80 gold]", "3. Health ring[+ 5 health, 30 gold]", "4. Celestial grieves[ +30 hp 90 gold]", "5. Leave shop"];

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
            else if(pu == 5)
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
int r1 = Random.Shared.Next(30, 100);
int r2 = Random.Shared.Next(30, 100);
int r3 = Random.Shared.Next(30, 100);
int er1 = Random.Shared.Next(2, 4);
int er2 = Random.Shared.Next(2, 4);
int er3 = Random.Shared.Next(2, 4);
int round = 1;
int bandh = 90 * er1;
int gobh = 110 * er2;
int wolfh = 100 *er3;
int bandmg = Random.Shared.Next(4,6) * er1;
int gobdmg = Random.Shared.Next(5,7) * er2;
int wolfdmg = Random.Shared.Next(4, 7) * er3;

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

string questchoice = "";
bool quest = true;
while (quest == true)
{
    quest = false;
    Console.ForegroundColor=ConsoleColor.White;Console.Write($"{name}: ");
    questchoice = Console.ReadLine();
    quest = int.TryParse(questchoice, out int qC);

    if(quest == false || qC <= 0 || qC > 3)
    {
        Console.ForegroundColor = ConsoleColor.Red;Console.WriteLine("Please choose quest 1,2 or 3");Console.ForegroundColor=ConsoleColor.White;
        quest = true;
    }
    else if(qC == 1)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"You run out of town and walk into the forest.\nYou encounter {er1} Bandits\n[Press enter to start battle]");
        Console.ReadLine();
        Console.Clear();
        while(health >= 0 && bandh >= 0)
        {
        Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine($"[~~~~~~Round {round} Start~~~~~~]");
        if(class1 == "mage")
        {
             Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"What will you do\n1.Attack\n2.Recover mana");  
             string battlec = "";
             bool battle = true;
             while(battle == true)
                {
                
                    Console.ForegroundColor=ConsoleColor.White;Console.Write($"{name}: ");
                    battlec = Console.ReadLine();
                    battle = int.TryParse(battlec, out int b);
                    if(battle == false || battlec.Length == 0 || b <= 0 || b > 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please choose 1, 2 or 3");
                        battle = true;
                    }
                    else if (battlec == "1" && mana >= 5)
                    {

                        Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine($"What ability will you use\n1.{mageability[i]}\n2.{mageability[o]}\n3.{mageability[p]}\n4.Cancel attack");
                        string attack1 = "";
                        bool one = true;
                        while(one == true)
                            {
                                attack1 = Console.ReadLine(); 
                                one = int.TryParse(attack1, out int a1);
                                if(one == false || battlec.Length == 0 || a1 <= 0 || a1 > 4)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please choose 1, 2, 3 or 4");
                                    one = true;
                                }
                                else if (a1 == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"You use {mageability[i]}");
                                    bandh -= 0;
                                    Console.WriteLine($"{bandh}");
                                }
                                else if(a1 == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"You use {mageability[o]}");
                                    bandh -= 0;
                                    Console.WriteLine($"{bandh}");
                                }
                                else if(a1 == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"You use {mageability[p]}");
                                }
                            }
                        round += 1;
                    }
                }
            }
            
            
        }
    }
}

// Dictionary<string, int> swdmg = new()
// {
//     ["Quick slash"] = Random.Shared.Next(6,10),
//     ["Heavy strike"] = Random.Shared.Next(15,22),
//     ["Wind cutter"] = Random.Shared.Next(10,16),
//     ["Crescent slash"] = Random.Shared.Next(18,24),
//     ["Heal"] = Random.Shared.Next(20,30),
//     ["Earthsplitter"] = Random.Shared.Next(25, 32),
//     ["Shadow thrust"] = Random.Shared.Next(22, 26)

// };

 Dictionary<string, int> mindmg = new()
 {
    ["Fireball"] = 8,
    ["Lightningbolt"] = 14,
     ["Vine whip"] = 9,
    ["Heal pulse"] = 20,
    ["Stone quake"] = 25,
    ["Water gun"] = 10,
    ["Light beam"] = 20,
};
Dictionary<string, int> maxdmg = new()
{
    ["Fireball"] = 22,
    ["Lightningbolt"] = 28,
    ["Vine whip"] = 12,
    ["Heal pulse"] = 30,
    ["Stone quake"] = 30,
    ["Water gun"] = 15,
    ["Light beam"] = 25,
};


// Message for when you die
        // Console.ForegroundColor = ConsoleColor.Red;Console.WriteLine("""
        //          _            _   _             
        //         | |          | | | |    
        //       __| | ___  __ _| |_| |__  
        //      / _` |/ _ \/ _` | __| '_ \ 
        //     | (_| |  __/ (_| | |_| | | |
        //      \__,_|\___|\__,_|\__|_| |_|
        
        //  """);



Console.ReadLine();
}
