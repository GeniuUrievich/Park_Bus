public abstract class Park
{
    private string adress;
    public string Adress {  get { return adress; } set {  adress = value; } }

    public abstract void Add_Bus(Bus bus);
    public abstract void Remove_Bus(Bus bus);

}

public class Park_Bus : Park
{
    private List<Bus> buses = new List<Bus>();

    public override void Add_Bus(Bus bus)
    {
        buses.Add(bus);
    }
    public override void Remove_Bus(Bus bus) 
    { 
        buses.Remove(bus);
    }

    public void len()
    {
        Console.WriteLine(buses.Count);
    }
}

public class Route_Bus : Park
{
    private List<Bus> buses = new List<Bus>();

    public override void Add_Bus(Bus bus)
    {
        buses.Add(bus);
    }
    public override void Remove_Bus(Bus bus)
    {
        buses.Remove(bus);
    }

    public void len()
    {
        Console.WriteLine(buses.Count);
    }
}