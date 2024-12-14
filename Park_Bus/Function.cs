  public class Admin
{
    public void Add_Driver_Base(Company company)
    {
        string a = null, b = null, c = null, d = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("������� ������� ��������: ");
            a = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(b))
        {
            Console.Write("������� ��� ��������: ");
            b = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(c))
        {
            Console.Write("������� �������� ��������: ");
            c = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(d))
        {
            Console.Write("������� ����� ������������� �������������: ");
            d = Console.ReadLine();
        }

        Driver driver = new Driver(a, b, c, d);
        company.Add_Driver(driver);

        if (company.Search_Driver(driver)) { Console.WriteLine("�������!!!"); }
        else{Console.WriteLine("��������");}
    }

    public void Add_Bus(Park_Bus park_bus)
    {
        string a = null, b = null, c = null;
        int d = 0;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("������� ��������: ");
            a = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(b))
        {
            Console.Write("������� ���������� ���� ��� �������: ");
            b = Console.ReadLine();
            d = int.Parse(b);
        }
        while (string.IsNullOrWhiteSpace(c))
        {
            Console.Write("������� ����� ��������: ");
            c = Console.ReadLine();
        }

        Bus bus = new Bus(a,d,c);
        park_bus.Add_Bus(bus);
        
        if (park_bus.Search_Bus(bus)) { Console.WriteLine("�������!"); }
        else { Console.WriteLine("���������!"); }

    }
    
    public void Assign_a_driver_admin(Company company, Park_Bus park_bus)
    {
        string a = null, b = null, c = null, d = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("������� ������� ��������: ");
            a = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(b))
        {
            Console.Write("������� ��� ��������: ");
            b = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(c))
        {
            Console.Write("������� �������� ��������: ");
            c = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(d))
        {
            Console.Write("������� ����� ��������: ");
            d = Console.ReadLine();
        }
        
        Driver driver = company.ret_driver(a, b, c);
        Bus bus = park_bus.ret_bus(d);
        bus.assign_a_driver(driver, company);
        if (bus.drivers != null) { Console.WriteLine("�������"); }
        
    }

   public void send_to_the_route(Park_Bus park_bus, Route_Bus route_bus)
    {
        string a = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("������� ����� ��������: ");
            a = Console.ReadLine();
        }
        Bus bus = park_bus.ret_bus(a);
        route_bus.Add_Bus(bus);
        park_bus.Remove_Bus(bus);

        if (route_bus.Search_Bus(bus) && park_bus.Search_Bus(bus) == false)
        {
            Console.WriteLine("�������!");
        }
    }

   public void return_to_the_park(Park_Bus park_bus, Route_Bus route_bus)
    {
        string a = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("������� ����� ��������: ");
            a = Console.ReadLine();
        }
        Bus bus = route_bus.ret_bus(a);
        route_bus.Remove_Bus(bus);
        park_bus.Add_Bus(bus);

        if (route_bus.Search_Bus(bus)==false && park_bus.Search_Bus(bus))
        {
            Console.WriteLine("�������!");
        }
    }

   public void remove_the_driver(Company company, Park_Bus park_bus)
    {
        string a = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("������� ����� ��������: ");
            a = Console.ReadLine();
        }
        Bus bus = park_bus.ret_bus(a);
        bus.drivers = null;

        if (bus.drivers?.Surname == null)
        {
            Console.WriteLine("�������");
        }
    }
}
