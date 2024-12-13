  public class Functions
{
    public void Add_Driver_Base(Company company)
    {
        string a = null, b = null, c = null, d = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("Введите фамилию водителя: ");
            a = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(b))
        {
            Console.Write("Введите имя водителя: ");
            b = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(c))
        {
            Console.Write("Введите отчество водителя: ");
            c = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(d))
        {
            Console.Write("Введите номер водительского удостоверения: ");
            d = Console.ReadLine();
        }

        Driver driver = new Driver(a, b, c, d);
        company.Add_Driver(driver);

        if (company.Search_Driver(driver)) { Console.WriteLine("Успешно!!!"); }
        else{Console.WriteLine("Неудачно");}
    }

    public void Add_Bus(Park_Bus park_bus)
    {
        string a = null, b = null, c = null;
        int d = 0;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("Введите название: ");
            a = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(b))
        {
            Console.Write("Введите количество мест для сидений: ");
            b = Console.ReadLine();
            d = int.Parse(b);
        }
        while (string.IsNullOrWhiteSpace(c))
        {
            Console.Write("Введите номер автобуса: ");
            c = Console.ReadLine();
        }

        Bus bus = new Bus(a,d,c);
        park_bus.Add_Bus(bus);

    }
    
} 