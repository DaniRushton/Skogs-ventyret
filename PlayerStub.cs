// TEMPORÄR STUB - ta bort när riktiga Player-klassen finns
class Player
{
    public string Name { get; private set; }
    public int Hp { get; private set; }
    public int MaxHp { get; private set; }
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int Level { get; private set; }
    public int Xp { get; private set; }
    public int DaysSurvived { get; private set; }

    public Player(string name)
    {
        Name = name;
        Hp = 30;
        MaxHp = 30;
        Attack = 25;
        Defense = 3;
        Level = 1;
        Xp = 0;
        DaysSurvived = 0;
    }

    public bool TakeDamage(int damage)
    {
        Hp -= damage;

        if (Hp < 0)
        {
            Hp = 0;
        }

        return Hp == 0;
    }

    public void Heal()
    {
        Hp = MaxHp;
    }

    public void GainXP(int amount)
    {
        Xp += amount;

        if (Xp >= Level * 100)
        {
            LevelUp();
        }
    }

    public void LevelUp()
    {
        Level++;
        MaxHp += 10;
        Attack += 2;
        Hp = MaxHp;
    }
}