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

Console.ForegroundColor=ConsoleColor.DarkYellow;Console.WriteLine("[~~~~Welcome to the world of Rodirion~~~~]");
Thread.Sleep(1500);
Console.ForegroundColor=ConsoleColor.White;Console.WriteLine("Rodirion is a land recovering from the great cataclysm 100 years ago where the demon realm invaded");
Thread.Sleep(4000);
Console.WriteLine("Wreckage and chaos spread throughout the lands as demons took over a big part of the continent.");
Thread.Sleep(4000);
Console.WriteLine("Humanity started recovering and the age of Renewal began, more adventurers trained and wanted to head into the new world");
Thread.Sleep(4000);
Console.WriteLine("Now its time for you adventurer to join the battle and go out into the world.");
Thread.Sleep(1000);
Console.WriteLine("\n[Press enter to start game]");
Console.ReadLine();
Console.Clear();
Console.ForegroundColor=ConsoleColor.DarkYellow;Console.WriteLine("[Welcome to the start of your adventure]");
Thread.Sleep(200);
Console.ForegroundColor=ConsoleColor.DarkGreen;Console.WriteLine("Now choose your class\nWill you take the roll of Mage or Swordsman?");Console.ForegroundColor=ConsoleColor.White;

string class1 = "";

bool classchoice = true;
while (classchoice == true)
{
class1 = Console.ReadLine().ToLower();
classchoice = false;
if(class1 !="mage" && class1 !="swordsman")
{
Console.ForegroundColor=ConsoleColor.DarkRed;Console.WriteLine("[ERROR]Please choose one of the mentioned classes.");Console.ForegroundColor=ConsoleColor.White;
classchoice = true;
}
else if(class1 =="mage")
{
Console.ForegroundColor=ConsoleColor.DarkYellow;Console.WriteLine("Ah i see we have a magic wielder present, a mage is a mighty choice for a adventurer like you");
}
else if(class1 == "swordsman" || class1 == "swordman")
{
    Console.ForegroundColor=ConsoleColor.DarkYellow;Console.WriteLine("Ah a might swordsman we got here, a mighty warrior like you will do great deeds.");
}
}
Thread.Sleep(1000);
Console.WriteLine($"No you have chosen a {class1} now what is your name adventurer\n[Choose a name between 1-8 letters] ");Console.ForegroundColor=ConsoleColor.White;
bool namesucces = true;
string name = "";

while(namesucces == true)
{
    name = Console.ReadLine();
    namesucces = int.TryParse(name, out int n);
    
    if(namesucces == true)
    {
        Console.ForegroundColor=ConsoleColor.DarkRed;Console.WriteLine("[ERROR]Please type a name between 1-8 letters");Console.ForegroundColor=ConsoleColor.White;
    }
    if(name.Length > 8)
    {
        Console.ForegroundColor=ConsoleColor.DarkRed;Console.WriteLine("[ERROR]Please type a name between 1-8 letters");Console.ForegroundColor=ConsoleColor.White;
        namesucces = true;
    }
    else if (name.Length >=1 && name.Length <= 8)
    {
    Console.ForegroundColor=ConsoleColor.DarkYellow;Console.WriteLine($"Welcome {name} to the world of Rodirion\nYour adventure begins here");
    }
}
Thread.Sleep(1000);
Console.WriteLine($"Press enter to go to the {class1} Guild");
Console.ReadLine();
Console.Clear();
Console.ForegroundColor=ConsoleColor.DarkYellow;Console.WriteLine($"You enter the {class1} guild and you start to walk towards the counter.");
Thread.Sleep(2000);
Console.ForegroundColor=ConsoleColor.DarkYellow;Console.WriteLine($"Clerk: Welcome adventurer to the {class1} guild");
Thread.Sleep(3000);
Console.ForegroundColor=ConsoleColor.White;Console.WriteLine($"{name}:Hello i would like to register and get my abilities");
Thread.Sleep(2000);
Console.ForegroundColor=ConsoleColor.DarkYellow;Console.WriteLine("Of course one second");




























Console.ReadLine();
