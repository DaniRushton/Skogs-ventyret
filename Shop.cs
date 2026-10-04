class Shop
{
    private List<Weapon> inventory;

    public Shop()
    {
        inventory = new List<Weapon>
        {
            new Dagger(),
            new Sword(),
            new Greatsword()
        };
    }
    public void ShowShop(Player player)
    {
        bool shopping = true;
        while (shopping)
        {
            Console.WriteLine($"---------- SHOP -----------");
            Console.WriteLine($"--------- Gold:{player.Gold} ----------");
            for (int i = 0; i < inventory.Count; i++)
            {
                Weapon weapon = inventory[i];
                Console.WriteLine($"{i+1}) {weapon.WeaponName} - +{weapon.AttackBonus} Attack - {weapon.Price} gold.");
            }
            Console.WriteLine("0) Leave Shop");

            string choice = Console.ReadLine();

            if (choice == "0")
            {
                shopping = false;
            }
            else if (int.TryParse(choice, out int index) && index >= 1 && index <= inventory.Count)
            {
                Weapon chosenWeapon = inventory[index - 1];

                if (player.Gold >= chosenWeapon.Price)
                {
                    player.SpendGold(chosenWeapon.Price);
                    player.EquipWeapon(chosenWeapon);
                    Console.WriteLine($"You bought {chosenWeapon.WeaponName}.");
                }

                else
                {
                    Console.WriteLine("You're too poor.");

                }

            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }   
        }
    }
}