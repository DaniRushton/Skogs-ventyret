
Console.WriteLine("What's your name?");
string playerName = Console.ReadLine();
Player player = new Player(playerName);

int day = 1;
bool playing = true;

List<string> defeatedMonsters = new List<string>(); // List that stores defeated monsters

while (playing)
{
    Console.WriteLine($"---------------Day {day}---------------");
    Console.WriteLine("----- What do you want to do? -----");
    Console.WriteLine("1) Go into the forest");
    Console.WriteLine("2) Rest");
    Console.WriteLine("3) Go into the arena");


    string playingChoice = Console.ReadLine();

    if (playingChoice == "1") // Go into forest --> battle
    {
        MonsterSpawner spawner = new MonsterSpawner();
        Monster monster = spawner.SpawnRandomMonster();
        Console.WriteLine($"{playerName} encounters one {monster.MonsterName}");

        // Run battle - true if player won or ran, false if player died
        bool playerSurvived = BattleSystem.RunBattle(player, monster, playerName);

        if (playerSurvived)
        {
            defeatedMonsters.Add(monster.MonsterName);
        }

        if (player.Hp <= 0) // When player dies, shows stats
        {
            Console.WriteLine("-------- Game Over --------");
            Console.WriteLine($"Days survived: {day}");
            Console.WriteLine($"Level reached: {player.Level}"); // kolla namn
            Console.WriteLine($"Total XP:      {player.Xp}");  //kolla namn
            Console.WriteLine();
            Console.WriteLine("----- Defeated Monsters -----");
            foreach (string defeatedMonster in defeatedMonsters) // Shows defeated monsters
            {
                Console.WriteLine(defeatedMonster);
            }
            playing = false;
        }
        else
        {
            day++; // Player survived, one day elapsed
        }


    }
    else if (playingChoice == "2") // Rest
    {
        Console.WriteLine($"{playerName} rests and restores Hp");
        player.Heal(); // kolla namn
        day++;
    }

    // TODO: Arena ej implementerad ännu 
    else if (playingChoice == "3") //Arena  
    {
        Console.WriteLine($"{playerName} walks into the arena"); 
    }
}