using System;
class Subscriber
{
    public string Name;
    public string PhoneNumber;
    public string Address;
    public string Email;
    public DateTime SubscriptionStartDate;
    public bool IsActive;
    public int Age;
    public double GetYearsWithNetwork()
    {
        return (DateTime.Now - SubscriptionStartDate).TotalDays / 365;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть iм'я абонента: ");
        string name = Console.ReadLine();
        Console.Write("Введiть номер телефону: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Введiть адресу: ");
        string address = Console.ReadLine();
        Console.Write("Введiть електронну пошту: ");
        string email = Console.ReadLine();
        Console.Write("Введiть дату пiдключення (у форматi yyyy-mm-dd): ");
        DateTime subscriptionStartDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Абонент активний? (y-так, n-нi): ");
        bool isActive = Console.ReadKey().Key == ConsoleKey.Y;
        Console.WriteLine();
        Console.Write("Введiть вiк абонента: ");
        int age = int.Parse(Console.ReadLine());
        Subscriber subscriber = new Subscriber();
        subscriber.Name = name;
        subscriber.PhoneNumber = phoneNumber;
        subscriber.Address = address;
        subscriber.Email = email;
        subscriber.SubscriptionStartDate = subscriptionStartDate;
        subscriber.IsActive = isActive;
        subscriber.Age = age;
        double yearsWithNetwork = subscriber.GetYearsWithNetwork();
        Console.WriteLine();
        Console.WriteLine("Iнформацiя про абонента:");
        Console.WriteLine($"Iм'я: {subscriber.Name}");
        Console.WriteLine($"Номер телефону: {subscriber.PhoneNumber}");
        Console.WriteLine($"Адреса: {subscriber.Address}");
        Console.WriteLine($"Електронна пошта: {subscriber.Email}");
        Console.WriteLine($"Дата пiдключення: {subscriber.SubscriptionStartDate.ToShortDateString()}");
        Console.WriteLine($"Статус: {(subscriber.IsActive ? "Активний" : "Неактивний")}");
        Console.WriteLine($"Стаж в мережi: {yearsWithNetwork:F1} рокiв");
        Console.WriteLine($"Вiк: {subscriber.Age} рокiв");
        Console.ReadKey();
    }
}