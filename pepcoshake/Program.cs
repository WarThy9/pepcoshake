Dictionary<string, int> staty = new Dictionary<string, int>();
staty.Add("str", 10);
staty.Add("dex", 10);
staty.Add("int", 10);
string[] stats = { "str", "dex", "int" };
Console.WriteLine("zadej jmeno hrdiny");
string? jmeno = Console.ReadLine();
Console.Clear();

bool zivot = true;
int unava = 0;

while (zivot == true)
{
    
    Random statsr = new Random();
    int statsr1 = statsr.Next(0, 3);
    Console.WriteLine($"jsi unavený na {unava}%");
    Console.WriteLine("chcete jit na quest nebo se vyspat?(q/v)");
    string? rozhodnuti = Console.ReadLine();
    if (rozhodnuti == "q" || rozhodnuti == "Q")
    {
        int cas = 10;
         
        Console.WriteLine($"vydáváš se plnit úkol na {stats[statsr1]}, vrat se za {cas}");
        Console.WriteLine("...");
        Thread.Sleep(cas * 1000);

        Random sance = new Random();
        int sance1 = sance.Next(0, 101);
        if(sance1 < unava)
        {
            zivot = false;
            Console.WriteLine("Usnul jsi v boji a zemřel");
        }
        else 
        {
            int lvl = 1;
            lvl = lvl + 1;
            Console.WriteLine($"{jmeno} se z výpravy vrátil celý");
            Console.WriteLine("- - - - - - - - - - - ");
            Console.WriteLine($"{jmeno} má lvl. {lvl} a vlastnosti:");
            staty =
            Console.WriteLine();


            unava = unava + 10;
            cas = cas + 10;

        }
        
        

    }
}


