public class Axe : Weapon
{
    public Axe()
    {
        Name = "Axe";

        Damage = 12;
    }

    public override int Attack()
    {
        Console.WriteLine("Chaaarge!!");
        return 2 + Random.Shared.Next(Damage);
    }
    public void Grind()
    {
        Damage ++;
    }
}
