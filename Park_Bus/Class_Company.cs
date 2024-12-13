public class Company
{
    List<Driver> drivers = new List<Driver>();

   public void Add_Driver(Driver driver)
    { drivers.Add(driver); }

    public void Remove_Driver(Driver driver) { drivers.Remove(driver); }
    public bool Search_Driver(Driver driver)
    {
        if (driver == null) { Console.WriteLine("Такого водителя нет!"); }
        return drivers.Contains(driver);
    }

    public Driver ret_driver(string sur,string name, string p)
    {
        return drivers.FirstOrDefault(d => d.Surname == sur && d.Name == name && d.Patronymic == p);
    }

    public void len()
    {
        Console.WriteLine(drivers.Count);
    }
}