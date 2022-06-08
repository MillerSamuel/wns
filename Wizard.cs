class Wizard:Human
{
    public Wizard(string name, int str=3, int intel=25, int dex=3, int hp=50):base(name,str,intel,dex,hp)
    {}

    public override int Attack(Human target)
    {
        int dmg = Intelligence * 5;
        target.Health -= dmg;
        Health+=dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        Console.WriteLine($"{Name} Healed for {dmg}");
        return target.Health;
    }

    public int Heal(Human target)
    {
        int amt=Intelligence*10;
        target.Health+=amt;
        Console.WriteLine($"{Name} Healed {target.Name} for {amt} Health!");
        return target.Health;
    }
}