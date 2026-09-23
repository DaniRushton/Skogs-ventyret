
class Monster
{
    private string monstername;
    private int hp;
    private int attack;
    private int xp;
    private int defense;

    public string MonsterName => monstername;
    public int Hp => hp;
    public int Attack => attack;
    public int Xp => xp;
    public int Defense => defense;

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
        Console.WriteLine($"{monstername} attacks {playername} for {damage} damage!");
        spelare.TakeDamage(attack);
    }
}
