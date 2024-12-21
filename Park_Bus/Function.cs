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
        else { Console.WriteLine("��������"); }
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

        Bus bus = new Bus(a, d, c);
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
        if (driver == null && bus == null) { Console.WriteLine("�������� ��� � ����. �������� ��� � ����"); }
        else if (driver == null && bus != null) { Console.WriteLine("�������� ��� � ����."); }
        else if (driver != null && bus == null) { Console.WriteLine("�������� ��� � ����."); }
        else { bus.assign_a_driver(driver, company);
            if (bus.drivers != null) { Console.WriteLine("�������"); }
        }

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
        if (bus == null) { Console.WriteLine("�������� ��� � ����"); }
        else
        {
            route_bus.Add_Bus(bus);
            park_bus.Remove_Bus(bus);
            if (route_bus.Search_Bus(bus) && park_bus.Search_Bus(bus) == false)
            {
                Console.WriteLine("�������!");
            }
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
        if (bus == null) { Console.WriteLine("�������� ��� � ����"); }
        else
        {
            route_bus.Remove_Bus(bus);
            park_bus.Add_Bus(bus);

            if (route_bus.Search_Bus(bus) == false && park_bus.Search_Bus(bus))
            {
                Console.WriteLine("�������!");
            }
        }
    }

    public void remove_the_driver_bus(Company company, Park_Bus park_bus)
    {
        string a = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("������� ����� ��������: ");
            a = Console.ReadLine();
        }
        Bus bus = park_bus.ret_bus(a);
        if (bus == null) { Console.WriteLine("�������� ��� � ����"); }
        else
        {
            bus.drivers = null;
            if (bus.drivers?.Surname == null)
            {
                Console.WriteLine("�������");
            }
        }
    }

    public void info_Bus(Park_Bus park_bus, Route_Bus route_bus)
    {
        string a = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("������� ����� ��������: ");
            a = Console.ReadLine();
        }
        Bus bus;
        if (park_bus.ret_bus(a) == null)
        {
            bus = route_bus.ret_bus(a);
            if (bus == null) { Console.WriteLine("�������� ��� � ����"); }
            else
            {
                bus.info_bus();
                Console.WriteLine($"������� � ������� {a} ��������� �� ��������.");
            }
        }
        else {
            bus = park_bus.ret_bus(a);
            if (bus == null) { Console.WriteLine("�������� ��� � ����"); }
            else
            {
                bus.info_bus();
                Console.WriteLine($"������� � ������� {a} ��������� � ����� �� �������.");
            }
        }


    }

    public void dissmis_driver(Company company)
    {
        string a = null, b = null, c = null;
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

        Driver driver = company.ret_driver(a, b, c);
        if (driver == null) { Console.WriteLine("������ ��������� ��� � ����"); }
        else { company.Remove_Driver(driver); }
    }

    public void remove_bus_in_company(Park_Bus park_bus) {
        string a = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("������� ����� ��������: ");
            a = Console.ReadLine();
        }
        Bus bus = park_bus.ret_bus(a);
        if (bus == null) { Console.WriteLine("�������� ��� � ����"); }
        else
        {
            park_bus.Remove_Bus(bus);
        }
    }

    public void info_bus_in_park(Park_Bus park_bus)
    {
        if (park_bus.Get_Bus().Count == 0) { Console.WriteLine("��������� � ����� ���!"); }
        else
        {
            { Console.WriteLine("�� ������ ������ � ����� ��������� ��������:");
                foreach (var bus in park_bus.Get_Bus())
                {
                    if (bus.drivers == null) { Console.WriteLine($"������� � ������� {bus.Bus_Number}, �������� �� ��������"); }
                    else { Console.WriteLine($"������� � ������� {bus.Bus_Number}, ��������: {bus.drivers.Surname} {bus.drivers.Name} {bus.drivers.Patronymic}"); }
                }
            }
        }
    }

    public void info_bus_in_route(Route_Bus route_bus)
    {
        if (route_bus.Get_Bus().Count == 0) { Console.WriteLine("��������� �� �������� ���!"); }
        else
        {
            foreach (var bus in route_bus.Get_Bus())
            {
                Console.WriteLine($"������� � ������� {bus.Bus_Number}, ��������: {bus.drivers.Surname} {bus.drivers.Name} {bus.drivers.Patronymic}");
            }
        }
    }
    
    public void info_driver(Company company)
    {
        foreach(var driver in company.get_driver())
        {
            driver.driver_info();
        }
    }

    public void change_info_driver(Company company)
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

        Driver driver = company.ret_driver(a,b,c);
        if (driver == null) { Console.WriteLine("������ �������� � ���� ���"); }
        else 
        {
            while (string.IsNullOrEmpty(d))
            {
                Console.Write("������� ����, ������� ������ ��������: ");
                d = Console.ReadLine();
            }

            switch (d)
            {
                case "�������":
                    string e = null;
                    while (string.IsNullOrWhiteSpace(e)) { Console.Write("������� ����� ��������: "); e = Console.ReadLine(); }
                    driver.Surname = e; break;
                case "���":
                    string g = null;
                    while (string.IsNullOrWhiteSpace(g)) { Console.Write("������� ����� ��������: "); g = Console.ReadLine(); }
                    driver.Name = g; break;
                case "��������":
                    string h = null;
                    while (string.IsNullOrWhiteSpace(h)) { Console.Write("������� ����� ��������: "); h = Console.ReadLine(); }
                    driver.Patronymic = h; break;
                case "����� ��":
                    string q = null;
                    while (string.IsNullOrWhiteSpace(q)) { Console.Write("������� ����� ��������: "); q = Console.ReadLine(); }
                    driver.NumberDL = q; break;
            }
            Console.WriteLine("�������!");
        }
    }

    public void change_info_bus(Park_Bus park_bus)
    {
        string a = null, d = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("������� ����� ��������: ");
            a = Console.ReadLine();
        }

        Bus bus = park_bus.ret_bus(a);
        if (bus == null) { Console.WriteLine("�������� ��� �� �������"); }
        else
        {
            while (string.IsNullOrEmpty(d))
            {
                Console.Write("������� ����, ������� ������ ��������: ");
                d = Console.ReadLine();
            }

            switch (d)
            {
                case "��������":
                    string e = null;
                    while (string.IsNullOrWhiteSpace(e)) { Console.Write("������� ����� ��������: "); e = Console.ReadLine(); }
                    bus.Bus_Name = e; break;
                case "���������� �������":
                    string g = null;
                    while (string.IsNullOrWhiteSpace(g)) { Console.Write("������� ����� ��������: "); g = Console.ReadLine(); }
                    bus.Number_of_Seats = int.Parse(g); break;
                case "����� ��������":
                    string h = null;
                    while (string.IsNullOrWhiteSpace(h)) { Console.Write("������� ����� ��������: "); h = Console.ReadLine(); }
                    bus.Bus_Number = h; break;
                
            }
            Console.WriteLine("�������!");
        }
    }
}

