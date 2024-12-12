public class Driver
{
    private string surname, name, patronymic;
    private string numberDL;
   // private string id_driver;

    public string Surname{get { return surname; }set { surname = value; } }
    public string Name { get { return name; } set { name = value; } }
    public string Patronymic { get {  return patronymic; } set {  patronymic = value; } }
    public string NumberDL {  get { return numberDL; } set { if (value.Length == 6 && int.TryParse(value, out int num) && value[0] != '0') { numberDL = value; } else { Console.WriteLine("Номер водительского удостоверения должен быть шестизначным! и не должен начинаться с нуля"); } } }
   // public string IdDriver { get { return id_driver; } set { id_driver = value; } }

    public Driver(string a, string b, string c, string d)
    {
        surname = a;
        name = b;
        patronymic = c;
        numberDL = d;
    }
}

