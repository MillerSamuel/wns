class Ninja:Human
{
    public Ninja(string name, int str=3, int intel=3, int dex=175, int hp=100):base(name,str,intel,dex,hp)
    {}

    public override int Attack(Human target)
    {
        Random rand=new Random();
        int dmg = Dexterity * 5;
        if(rand.Next(1,6)==1){
            dmg +=10;
        }
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }

    public int Steal(Human target)
    {
        target.Health-=5;
        Health+=5;
        Console.WriteLine($"{Name} Stole 5 Health From {target.Name}!");
        return target.Health;
    }
}