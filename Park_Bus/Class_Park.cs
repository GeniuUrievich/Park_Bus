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
    public bool Search_Bus(Bus bus)
    {
        if (bus == null) { Console.WriteLine("Такого автобуса нет!"); }
        return buses.Contains(bus);
    }

    public Bus ret_bus(string num)
    {
        return buses.FirstOrDefault(d => d.Bus_Number == num);
    }
}

public class Route_Bus : Park
{
    private List<Bus> buses = new List<Bus>();

    public override void Add_Bus(Bus bus)
    {
        if (bus.drivers == null) { Console.WriteLine("У автобуса должен быть водитель"); }
        buses.Add(bus);
    }
    public override void Remove_Bus(Bus bus)
    {
        buses.Remove(bus);
    }
    public bool Search_Bus(Bus bus)
    {
        if (bus == null) { Console.WriteLine("Такого автобуса нет!"); }
        return buses.Contains(bus);
    }
    public Bus ret_bus(string num)
    {
        return buses.FirstOrDefault(d => d.Bus_Number == num);
    }
}