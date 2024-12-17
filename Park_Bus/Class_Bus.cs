public class Bus
{
    private string bus_name;
    private int number_of_seats;
    private string bus_number;
    public Driver? drivers { get; set; }
    //public Company company { get; set; }
    public string Bus_Name { get { return bus_name; } }
    public int Number_of_Seats { get { return number_of_seats; } }
    public string Bus_Number { get { return bus_number; } }
    public Bus(string name, int nos, string bn)
    {
        bus_name = name;
        number_of_seats = nos;
        bus_number = bn;
    }

    public void assign_a_driver(Driver driver, Company company)
    {
        if (company.Search_Driver(driver))
        {
            drivers = driver;
        }
        else { Console.WriteLine("Такого водителя нет в базе!"); }
    }

    public void remove_the_driver(Driver driver)
    {
        drivers = null;
    }

    public void info_bus()
    {
        if (drivers != null)
        {
            Console.WriteLine($"Автобус: {this.Bus_Name}, количество мест для сидения: {this.Number_of_Seats}, водитель: {this.drivers.Surname} {this.drivers.Name}");
        }
        else
        {
            Console.WriteLine($"Автобус: {this.Bus_Name}, количество мест для сидения: {this.Number_of_Seats}, водитель: не назначен");
        }
    }
}