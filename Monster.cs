
class Monster
{
    private string monstername;
    private int hp;
    private int attack;
    private int xp;
    private int defense;

    public string MonsterName { get; private set; }
    public int Hp { get; private set; }
    public int Attack { get; private set; }
    public int Xp { get; private set; }
    public int Defense { get; private set; }

    public Monster(string monsterName, int monsterHp, int monsterAttack, int monsterXp, int monsterDefense)
    {
        monstername = monsterName;
        hp = monsterHp;
        attack = monsterAttack;
        xp = monsterXp;
        defense = monsterDefense;
    }

    public bool TakeDamage(int damage)
    {
        hp -= damage;
        if (hp < 0)
        {
            hp = 0;
        }
        return hp == 0;
    }

    public void AttackPlayer(Player player)
    {
        Console.WriteLine($"{monstername} attacks {player.name} for {attack} damage!");
        player.TakeDamage(attack);
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