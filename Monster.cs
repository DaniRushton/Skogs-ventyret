
class Monster
{
    public string MonsterName { get; private set; }
    public int Hp { get; private set; }
    public int Attack { get; private set; }
    public int Xp { get; private set; }
    public int Defense { get; private set; }

    public Monster(string monsterName, int monsterHp, int monsterAttack, int monsterXp, int monsterDefense)
    {
        MonsterName = monsterName;
        Hp = monsterHp; 
        Attack = monsterAttack;
        Xp = monsterXp;
        Defense = monsterDefense;
    }

    public bool TakeDamage(int damage)
    {
        Hp -= damage;
        if (Hp < 0)
        {
            Hp = 0; // negative health is 0 health
        }
        return Hp == 0;
    }

    public void AttackPlayer(Player player)
    {
        Console.WriteLine($"{MonsterName} attacks {player.name} for {Attack} damage!");
        player.TakeDamage(Attack);
    }
}

//types of monsters
class Goblin : Monster
{
    public Goblin() : base("Goblin", 20, 5, 10, 3) //name, hp, atk, xp, def
    {

    }

}

class Orc : Monster
{
    public Orc() : base("Orc", 40, 10, 30, 10)
    {

    }
}

class Ogre : Monster
{
    public Ogre() : base("Ogre", 60, 25, 45, 20)
    {

    }
}