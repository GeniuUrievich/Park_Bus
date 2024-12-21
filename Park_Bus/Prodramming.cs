Admin admin = new Admin();
Company company = new Company();
Route_Bus route_bus = new Route_Bus();
Park_Bus park_Bus = new Park_Bus();
program();

void program()
{
    Console.WriteLine("����� �������� � ������� ���������� ���������� ������!");
    while (true)
    {
        Console.Clear();
        Console.WriteLine("�������� ��������:");
        Console.WriteLine("1 �������� �������� � ����");
        Console.WriteLine("2 �������� ������� � ����");
        Console.WriteLine("3 ��������� �������� �� �������");
        Console.WriteLine("4 ��������� ������� �� �������");
        Console.WriteLine("5 ��������� ������� � ����");
        Console.WriteLine("6 ����� �������� � ��������");
        Console.WriteLine("7 �������� ���������� �� ��������� �� �������");
        Console.WriteLine("8 �������� ���������� �� ��������� �� ��������");
        Console.WriteLine("9 �������� ���������� �� ��������");
        Console.WriteLine("10 ������� ��������");
        Console.WriteLine("11 �������� ������ ���������");
        Console.WriteLine("12 ������� �������");
        Console.WriteLine("13 �������� ������ ��������");
        Console.WriteLine("14 �������� ������ ��������");
        string a = null;
        while (string.IsNullOrWhiteSpace(a))
        {
            Console.Write("�������� ��������: ");
            a = Console.ReadLine();
        }
        switch (a)
        {
            case "1":
                Console.Clear();
                admin.Add_Driver_Base(company);
                Console.Write("������� Enter ����� ����������");
                Console.ReadLine();
                break;
            case "2":
                Console.Clear();
                admin.Add_Bus(park_Bus); 
                Console.Write("������� Enter ����� ����������");
                Console.ReadLine();
                break;
            case "3":
                Console.Clear();
                admin.Assign_a_driver_admin(company, park_Bus);
                Console.Write("������� Enter ����� ����������");
                Console.ReadLine();
                break;
            case "4":
                Console.Clear();
                admin.send_to_the_route(park_Bus,route_bus);
                Console.Write("������� Enter ����� ����������");
                Console.ReadLine();
                break;
            case "5":
                Console.Clear();
                admin.return_to_the_park(park_Bus,route_bus);
                Console.Write("������� Enter ����� ����������");
                Console.ReadLine();
                break;
            case "6":
                Console.Clear();
                admin.remove_the_driver_bus(company, park_Bus);
                Console.Write("������� Enter ����� ����������");
                Console.ReadLine();
                break;
            case "9":
                Console.Clear();
                admin.info_Bus(park_Bus,route_bus);
                Console.Write("������� Enter ����� ����������");
                Console.ReadLine();
                break;
            case "10":
                Console.Clear();
                admin.dissmis_driver(company);
                Console.Write("������� Enter ����� ����������");
                Console.ReadLine();
                break;
            case "7":
                Console.Clear();
                admin.info_bus_in_park(park_Bus);
                Console.Write("������� Enter ����� ����������");
                Console.ReadLine();
                break;
            case "8":
                Console.Clear();
                admin.info_bus_in_route(route_bus);
                Console.Write("������� Enter ����� ����������");
                Console.ReadLine();
                break;
            case "11":
                Console.Clear();
                admin.info_driver(company);
                Console.Write("������� Enter ����� ����������");
                Console.ReadLine();
                break;
            case "12":
                Console.Clear();
                admin.remove_bus_in_company(park_Bus);
                Console.Write("������� Enter ����� ����������");
                Console.ReadLine();
                break;
            case "13":
                Console.Clear();
                admin.change_info_driver(company);
                Console.Write("������� Enter ����� ����������");
                Console.ReadLine();
                break;
            case "14":
                Console.Clear();
                admin.change_info_bus(park_Bus);
                Console.Write("������� Enter ����� ����������");
                Console.ReadLine();
                break;
        }
    }
}