public class Player
{

    private string _name;
    private int _hp;
    private int _maxhp;
    private int _attack;
    private int _defense;
    private int _level;
    private int _xp;
    private int _daysSurvived;

    public string Name
    {
        get { return _name; }
    }
    public int Hp
    {
        get { return _hp; }
    }

    public int MaxHP
    {
        get { return _maxhp; }
    }

    public int Attack
    {
        get { return _attack; }
    }

    public int Defense
    {
        get { return _defense; }

    }

    public int Level
    {
        get { return _level; }
    }

    public int Xp
    {
        get { return _xp; }
    }

    public int DaysSurvived
    {
        get { return _daysSurvived; }
    }

    public Player(string name, int maxhp, int attack, int defense)
    {
        _name = name;
        _maxhp = maxhp;
        _hp = maxhp;
        _attack = attack;
        _defense = defense;
        _level = 1;
        _xp = 0;
        _daysSurvived = 0;
    }

    public bool TakeDamage(int damage)
    {
        _hp -= damage;
        if (_hp <= 0)
        {
            _hp = 0;
            return true;
        }

        return false;
    }
    public void Heal()
    {
        _hp = _maxhp;
        _daysSurvived++;
    }

    public void GainXp(int amount)
    {
        _xp += amount;
        if (_xp >= 50)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        _level++;
        _maxhp += 20;
        _attack += 5;
        _hp = _maxhp;
        _xp = 0;
    }
}