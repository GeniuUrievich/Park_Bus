public class Admin
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
        else { Console.WriteLine("Неудачно"); }
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

        Bus bus = new Bus(a, d, c);
        park_bus.Add_Bus(bus);

        if (park_bus.Search_Bus(bus)) { Console.WriteLine("Успешно!"); }
        else { Console.WriteLine("Неуспешно!"); }

    }

    public void Assign_a_driver_admin(Company company, Park_Bus park_bus)
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
            Console.Write("Введите номер автобуса: ");
            d = Console.ReadLine();
        }

        Driver driver = company.ret_driver(a, b, c);
        Bus bus = park_bus.ret_bus(d);
        if (driver == null && bus == null) { Console.WriteLine("Водителя нет в базе. Автобуса нет в базе"); }
        else if (driver == null && bus != null) { Console.WriteLine("Водителя нет в базе."); }
        else if (driver != null && bus == null) { Console.WriteLine("Автобуса нет в базе."); }
        else { bus.assign_a_driver(driver, company);
            if (bus.drivers != null) { Console.WriteLine("Успешно"); }
        }

    }

    public void send_to_the_route(Park_Bus park_bus, Route_Bus route_bus)
    {
        string a = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("Введите номер автобуса: ");
            a = Console.ReadLine();
        }
        Bus bus = park_bus.ret_bus(a);
        if (bus == null) { Console.WriteLine("Автобуса нет в базе"); }
        else
        {
            route_bus.Add_Bus(bus);
            park_bus.Remove_Bus(bus);
            if (route_bus.Search_Bus(bus) && park_bus.Search_Bus(bus) == false)
            {
                Console.WriteLine("Успешно!");
            }
        }
    }

    public void return_to_the_park(Park_Bus park_bus, Route_Bus route_bus)
    {
        string a = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("Введите номер автобуса: ");
            a = Console.ReadLine();
        }
        Bus bus = route_bus.ret_bus(a);
        if (bus == null) { Console.WriteLine("Автобуса нет в базе"); }
        else
        {
            route_bus.Remove_Bus(bus);
            park_bus.Add_Bus(bus);

            if (route_bus.Search_Bus(bus) == false && park_bus.Search_Bus(bus))
            {
                Console.WriteLine("Успешно!");
            }
        }
    }

    public void remove_the_driver_bus(Company company, Park_Bus park_bus)
    {
        string a = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("Введите номер автобуса: ");
            a = Console.ReadLine();
        }
        Bus bus = park_bus.ret_bus(a);
        if (bus == null) { Console.WriteLine("Автобуса нет в базе"); }
        else
        {
            bus.drivers = null;
            if (bus.drivers?.Surname == null)
            {
                Console.WriteLine("Успешно");
            }
        }
    }

    public void info_Bus(Park_Bus park_bus, Route_Bus route_bus)
    {
        string a = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("Введите номер автобуса: ");
            a = Console.ReadLine();
        }
        Bus bus;
        if (park_bus.ret_bus(a) == null)
        {
            bus = route_bus.ret_bus(a);
            if (bus == null) { Console.WriteLine("Автобуса нет в базе"); }
            else
            {
                bus.info_bus();
                Console.WriteLine($"Автобус с номером {a} находится на маршруте.");
            }
        }
        else {
            bus = park_bus.ret_bus(a);
            if (bus == null) { Console.WriteLine("Автобуса нет в базе"); }
            else
            {
                bus.info_bus();
                Console.WriteLine($"Автобус с номером {a} находится в парке на стоянке.");
            }
        }


    }

    public void dissmis_driver(Company company)
    {
        string a = null, b = null, c = null;
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

        Driver driver = company.ret_driver(a, b, c);
        if (driver == null) { Console.WriteLine("Такого водителся нет в базе"); }
        else { company.Remove_Driver(driver); }
    }

    public void remove_bus_in_company(Park_Bus park_bus) {
        string a = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("Введите номер автобуса: ");
            a = Console.ReadLine();
        }
        Bus bus = park_bus.ret_bus(a);
        if (bus == null) { Console.WriteLine("Автобуса нет в базе"); }
        else
        {
            park_bus.Remove_Bus(bus);
        }
    }

    public void info_bus_in_park(Park_Bus park_bus)
    {
        if (park_bus.Get_Bus().Count == 0) { Console.WriteLine("Автобусов в парке нет!"); }
        else
        {
            { Console.WriteLine("На данный момент в парке находятся автобусы:");
                foreach (var bus in park_bus.Get_Bus())
                {
                    if (bus.drivers == null) { Console.WriteLine($"Автобус с номером {bus.Bus_Number}, водитель не назначен"); }
                    else { Console.WriteLine($"Автобус с номером {bus.Bus_Number}, водитель: {bus.drivers.Surname} {bus.drivers.Name} {bus.drivers.Patronymic}"); }
                }
            }
        }
    }

    public void info_bus_in_route(Route_Bus route_bus)
    {
        if (route_bus.Get_Bus().Count == 0) { Console.WriteLine("Автобусов на маршруте нет!"); }
        else
        {
            foreach (var bus in route_bus.Get_Bus())
            {
                Console.WriteLine($"Автобус с номером {bus.Bus_Number}, водитель: {bus.drivers.Surname} {bus.drivers.Name} {bus.drivers.Patronymic}");
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

        Driver driver = company.ret_driver(a,b,c);
        if (driver == null) { Console.WriteLine("Такого водителя в базе нет"); }
        else 
        {
            while (string.IsNullOrEmpty(d))
            {
                Console.Write("Введите поле, которое хотите изменить: ");
                d = Console.ReadLine();
            }

            switch (d)
            {
                case "Фамилия":
                    string e = null;
                    while (string.IsNullOrWhiteSpace(e)) { Console.Write("Введите новое значение: "); e = Console.ReadLine(); }
                    driver.Surname = e; break;
                case "Имя":
                    string g = null;
                    while (string.IsNullOrWhiteSpace(g)) { Console.Write("Введите новое значение: "); g = Console.ReadLine(); }
                    driver.Name = g; break;
                case "Отчество":
                    string h = null;
                    while (string.IsNullOrWhiteSpace(h)) { Console.Write("Введите новое значение: "); h = Console.ReadLine(); }
                    driver.Patronymic = h; break;
                case "Номер ВУ":
                    string q = null;
                    while (string.IsNullOrWhiteSpace(q)) { Console.Write("Введите новое значение: "); q = Console.ReadLine(); }
                    driver.NumberDL = q; break;
            }
            Console.WriteLine("Успешно!");
        }
    }

    public void change_info_bus(Park_Bus park_bus)
    {
        string a = null, d = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("Введите номер автобуса: ");
            a = Console.ReadLine();
        }

        Bus bus = park_bus.ret_bus(a);
        if (bus == null) { Console.WriteLine("Автобуса нет на стоянке"); }
        else
        {
            while (string.IsNullOrEmpty(d))
            {
                Console.Write("Введите поле, которое хотите изменить: ");
                d = Console.ReadLine();
            }

            switch (d)
            {
                case "Название":
                    string e = null;
                    while (string.IsNullOrWhiteSpace(e)) { Console.Write("Введите новое значение: "); e = Console.ReadLine(); }
                    bus.Bus_Name = e; break;
                case "Количество сидений":
                    string g = null;
                    while (string.IsNullOrWhiteSpace(g)) { Console.Write("Введите новое значение: "); g = Console.ReadLine(); }
                    bus.Number_of_Seats = int.Parse(g); break;
                case "Номер автобуса":
                    string h = null;
                    while (string.IsNullOrWhiteSpace(h)) { Console.Write("Введите новое значение: "); h = Console.ReadLine(); }
                    bus.Bus_Number = h; break;
                
            }
            Console.WriteLine("Успешно!");
        }
    }
}

