class Human
{
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    public int Health { get; set; }
    
    
    public Human(string name, int str=3, int intel=3, int dex=3, int hp=100)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = hp;
    }
    
    public virtual int Attack(Human target)
    {
        int dmg = Strength * 5;
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }
}
