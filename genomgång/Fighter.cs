public class Fighter
{
    public string Name;
    public int agility = 10;
    public int strength = 10;

    public Weapon weapon;
    public int Attack()
    {
        return weapon.Attack();
    }


}
