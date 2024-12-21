public class Driver
{
    private string surname, name, patronymic;
    private string numberDL;

    public string Surname{get { return surname; }set { surname = value; } }
    public string Name { get { return name; } set { name = value; } }
    public string Patronymic { get {  return patronymic; } set {  patronymic = value; } }
    public string NumberDL {  get { return numberDL; } set {
            if (value.Length != 6)
            {
                Console.WriteLine("Номер водительского удостоверения должен быть шестизначным!");
            }
            else if (value[0] == '0') 
            { Console.WriteLine("Номер водительского удостоверения не должен начинаться с 0!");
            }
            else { numberDL = value; } } }

    public Driver(string a, string b, string c, string d)
    {
        surname = a;
        name = b;
        patronymic = c;
        this.NumberDL = d;
    }

    public void driver_info()
    {
        Console.WriteLine($"Фамилия: {this.Surname} Имя: {this.Name} Отчество: {this.Patronymic} Номер ВУ: {this.NumberDL}");
    }
}

