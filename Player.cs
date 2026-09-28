

//TEMP LÖSNING - tas bort sen
class Player
{
    public string name = "Hjälte";
    public int playerDefense = 3;
    public int playerAttack = 3;

    public bool TakeDamage(int damage)
    {
        Console.WriteLine($"Player took {damage} damage!");
        return false;
    }
}