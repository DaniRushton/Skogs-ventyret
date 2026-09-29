
Console.WriteLine("What's your name?");
string playerName = Console.ReadLine();
Player player = new Player(playerName);

int day = 1;
bool playing = true;

List<string> defeatedMonsters = new List<string>();

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

        bool battleOver = false;

        while (!battleOver)
        {
            Console.WriteLine($"----- {playerName}: {player.Hp} Hp | {monster.MonsterName}: {monster.Hp} Hp -----");

            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Defend");
            Console.WriteLine("3) Run");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Player attacks Monster
                int damageToMonster = player.Attack - monster.Defense;
                if (damageToMonster < 1)
                {
                    damageToMonster = 1;
                }
                Console.WriteLine($"{playerName} attacks {monster.MonsterName} dealing {damageToMonster} damage.");
                bool monsterDied = monster.TakeDamage(damageToMonster);


                if (monsterDied)
                {
                    Console.WriteLine($"{playerName} defeated {monster.MonsterName}");
                    player.GainXP(monster.Xp);
                    defeatedMonsters.Add(monster.MonsterName);
                    battleOver = true;
                }


                else
                {
                    bool playerDied = monster.AttackPlayer(player);
                    if (playerDied)
                    {
                        Console.WriteLine($"{playerName} was defeated.");
                        battleOver = true;
                    }
                }

            }
            else if (choice == "2")
            {
                // Defend against Monster, take half damage
                int damageTaken = monster.Attack / 2;
                Console.WriteLine($"{playerName} defended themselves and took {damageTaken} damage.");

                bool playerDied = player.TakeDamage(damageTaken); // Player might die when defending
                if (playerDied)
                {
                    Console.WriteLine($"{playerName} was defeated.");
                    battleOver = true;
                }

            }
            else if (choice == "3")
            {
                // Run from battle, take random damage
                Random random = new Random();
                int damageTaken = random.Next(1, monster.Attack + 1);

                Console.WriteLine($"{playerName} runs from the battle and take {damageTaken} damage.");

                bool playerDied = player.TakeDamage(damageTaken); // Player might die when running
                if (playerDied)
                {
                    Console.WriteLine($"{playerName} was defeated.");
                }
                battleOver = true;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again");
                continue;
            }

        }
        if (player.Hp <= 0)
        {
            Console.WriteLine("----- Game Over -----");
            Console.WriteLine($"Days survived: {day}");
            Console.WriteLine($"Level reached: {player.Level}");
            Console.WriteLine($"Total XP:      {player.Xp}"); 
            Console.WriteLine();
            Console.WriteLine("----- Defeated Monsters -----");
            foreach (string defeatedMonster in defeatedMonsters)
            {
                Console.WriteLine(defeatedMonster);
            }
            playing = false;
        }
        else
        {
            day++; // One day elapsed 
        }


    }
    else if (playingChoice == "2") // Rest
    {
        Console.WriteLine($"{playerName} rests and restores Hp");
        player.Heal();
        day++;
    }


    else if (playingChoice == "3") //Arena
    {
        Console.WriteLine($"{playerName} walks into the arena"); // ej implementerad !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    }
}