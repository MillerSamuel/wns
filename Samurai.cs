class Samurai:Human
{
    public Samurai(string name, int str=3, int intel=3, int dex=3, int hp=200):base(name,str,intel,dex,hp)
    {}

    public override int Attack(Human target)
    {
        int dmg = Strength * 5;
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        if(target.Health<50){
            target.Health=0;
            Console.WriteLine($"{Name} executed {target.Name}!");
        }
        return target.Health;
    }

    public int Meditate()
    {
        Health=200;
        Console.WriteLine($"{Name} Meditated back to full health!");
        return Health;
    }
}