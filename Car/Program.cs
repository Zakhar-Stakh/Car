using System;

class Car
{
    // Поля 
    public string Name { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }
    public const string CompanyName = "AutoCorp";

    // Конструктор
    public Car()
    {
        Name = "Unknown";
        Color = "Unknown";
        Price = 0.0;
    }

    // Конструктор з параметрами
    public Car(string name, string color, double price)
    {
        Name = name;
        Color = color;
        Price = price;
    }

    // Метод для введення даних про автомобіль
    public void Input()
    {
        Console.Write("Введіть назву автомобіля: ");
        Name = Console.ReadLine();

        Console.Write("Введіть колір автомобіля: ");
        Color = Console.ReadLine();

        Console.Write("Введіть ціну автомобіля: ");
        Price = double.Parse(Console.ReadLine());
    }

    // Метод для виведення даних про автомобіль на консоль
    public void Print()
    {
        Console.WriteLine($"Назва: {Name}, Колір: {Color}, Ціна: {Price}, Компанія: {CompanyName}");
    }

    // Метод для зміни ціни на х%
    public void ChangePrice(double x)
    {
        Price -= Price * x / 100;
    }

    // Метод для зміни кольору автомобіля з кольором white
    public void ChangeColorIfWhite(string newColor)
    {
        if (Color.ToLower() == "white")
        {
            Color = newColor;
        }
    }

    // Метод, який повертає рядок з інформацією про авто
    public string PrintInfo()
    {
        return $"Назва: {Name}, Колір: {Color}, Ціна: {Price}, Компанія: {CompanyName}";
    }
}

class Program
{
    static void Main()
    {
        // Створення масиву для зберігання трьох об'єктів Car
        Car[] cars = new Car[3];

        // Введення даних про 3 авто
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine($"Введіть дані для автомобіля {i + 1}:");
            cars[i] = new Car();
            cars[i].Input();
        }

        // Зменшення ціни на 10% і виведення даних про авто
        Console.WriteLine("\nДані про автомобілі після зменшення ціни на 10%:");
        foreach (Car car in cars)
        {
            car.ChangePrice(10);
            car.Print();
        }

        // Введення нового кольору для перефарбування білих авто
        Console.Write("\nВведіть новий колір для автомобілів з кольором 'white': ");
        string newColor = Console.ReadLine();

        // Зміна кольору і виведення інформації про авто
        Console.WriteLine("\nДані про автомобілі після зміни кольору:");
        foreach (Car car in cars)
        {
            car.ChangeColorIfWhite(newColor);
            Console.WriteLine(car.PrintInfo());
        }
    }
}