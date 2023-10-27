public class Weapon
{
    public string Name;
    public int Damage;

    public virtual int Attack()
    {
        Console.WriteLine($"Attacking with a {Name}");
        return Random.Shared.Next(Damage);
    }
}
