// Spel ide, Spelaren är en äventyrare som ska ge sig in i den ny världen och bli starkare så de kan skydda det som de bryr sig om
// Spelet börjar med att vi får veta lite om äventyraren och historian bakom denna värld man ger sig in i och staden, Elysium.
// Spelet börjar

// Del 1.

// Splearen får välja mellan mage och swordsman.
// Spelaren får välja namn på sin karaktär 
// Spelaren går till sin class guild house och ska få sina abilities och skills.
// Slumpar mellan en lista på abilities beroende på den klass man väljer.
// Går till quest boarden som finns i guild houses och får 3 options.
// Quest 1: Pick 5 Rose lilies in the fields of Elysium.
// Quest 2: Defeat 3 wolves, found in the Shadowfen forsest.
// Quest 3: Find the treasure in the cave of radiance.
// Spelaren väljer vilken quest de vill ha och får se infon om vilka rewards man får av questen.
// Man blir teleporterad till questen.

// Start

using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("[~~~~Welcome to the world of Rodirion~~~~]");
Thread.Sleep(1500);
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

// Choose class.
Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Now choose your class\nWill you take the roll of Mage or Swordsman\nMage\n[140 Hitpoints 120 mana] \nSwordsman\n[180 hp 90 stamina]?"); Console.ForegroundColor = ConsoleColor.White;

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
    namesucces = int.TryParse(name, out int n);

    if (namesucces == true)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("[ERROR]Please type a name between 1-10 letters"); Console.ForegroundColor = ConsoleColor.White;
    }
    if (name.Length > 10)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("[ERROR]Please type a name between 1-10 letters"); Console.ForegroundColor = ConsoleColor.White;
        namesucces = true;
    }
    else if (name.Length >= 1 && name.Length <= 10)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"Welcome {name} to the world of Rodirion\nYour adventure begins here");
    }
}
Thread.Sleep(1000);
Console.WriteLine($"Press enter to go to the {class1} Guild");
Console.ReadLine();
Console.Clear();
// Go to respective class guild.
Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"You enter the {class1} guild and you start to walk towards the counter.");
Thread.Sleep(1500);
Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine($"Clerk: Welcome adventurer to the {class1} guild");
Thread.Sleep(2000);
Console.ForegroundColor = ConsoleColor.White; Console.WriteLine($"{name}: Hello i would like to register and get my abilities");
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Clerk: Of course one second");
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.White; Console.WriteLine($"{name}: I would also like to see the available skills");
Thread.Sleep(1200);

// Mage abilities here.
List<string> mageability = ["Fireball[8-22 dmg 10 mana]", "Lightning bolt[14-28dmg 20 mana]", "Vine whip[9-12 dmg 5 mana]", "Ice lance[2-5 lance * 4-6dmg 5 mana]", "Stone quake[25-30dmg 40 mana]", "Water gun[10-15 dmg 10 mana]", "Light beam[20-25 dmg 35 mana]"];
Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Clerk: Of course one second here is the list.");
if (class1 == "mage")
{
    Thread.Sleep(2000);
    Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine($"List of avilable {class1} abilities");
    Thread.Sleep(1000);
    for (int ma = 0; ma < mageability.Count; ma++)
    {
        Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(mageability[ma]);
        Thread.Sleep(500);
    }
}
// Swordsman abilities here.
List<string> swordability = ["Quick slash[6-10dmg 5 stamina]", "Heavy strike[15-22dmg 15 stamina]", "Wind cutter[10-16dmg 10 stamina]", "Crecent slash[18-24dmg 20 stamina]", "Blade flurry[2-5 hits * 4-6 dmg]", "Eathsplitter[25-32dmg 35 stamina]", "Shadow thrust[22-26dmg 20 stamina]"];
if (class1 == "swordsman" || class1 == "swordman")
{
    Thread.Sleep(2000);
    Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine($"List of avilable {class1} abilities");
    Thread.Sleep(1000);
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
    int i = Random.Shared.Next(mageability.Count);
    int o = Random.Shared.Next(mageability.Count);
    int p = Random.Shared.Next(mageability.Count);
   
    while(i == o || o == p || p == i)
    {
    i = Random.Shared.Next(mageability.Count);
    o = Random.Shared.Next(mageability.Count);
    p = Random.Shared.Next(mageability.Count);
    }
    Thread.Sleep(800);
    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(mageability[i]); 
    Thread.Sleep(500);
    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Your Second ability is");
    Thread.Sleep(800);
    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(mageability[o]);
    Thread.Sleep(500);
    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("Your Last ability is");
    Thread.Sleep(800);
    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(mageability[p]);

        
}
if (class1 == "swordsman" || class1 == "swordman")
{
    int i = Random.Shared.Next(swordability.Count);
    int o = Random.Shared.Next(swordability.Count);
    int p = Random.Shared.Next(swordability.Count);
   
    while(i == o || o == p || p == i)
    {
    i = Random.Shared.Next(swordability.Count);
    o = Random.Shared.Next(swordability.Count);
    p = Random.Shared.Next(swordability.Count);
    }
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














Console.ReadLine();
