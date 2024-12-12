public class Company
{
    List<Driver> drivers = new List<Driver>();

   public void Add_Driver(Driver driver)
    { drivers.Add(driver); }

    public void Remove_Driver(Driver driver) { drivers.Remove(driver); }
    public void Search_Driver(Driver driver)
    {
        if (driver == null) { Console.WriteLine("Такого водителя нет!"); }
        Console.WriteLine(drivers.Contains(driver));
    }
}