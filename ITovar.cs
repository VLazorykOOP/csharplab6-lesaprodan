using System;

// Інтерфейс для товарів
public interface ITovar
{
    void DisplayInfo(); // Метод для виведення інформації про товар
    bool IsMatch(string type); // Метод для визначення відповідності типу товару
}

// Клас Іграшка, який реалізує інтерфейс ITovar
public class Toy : ITovar
{
    // Поля класу Іграшка
    public string Name { get; set; }
    public double Price { get; set; }
    public string Manufacturer { get; set; }
    public string Material { get; set; }
    public int Age { get; set; }

    // Конструктор класу Іграшка
    public Toy(string name, double price, string manufacturer, string material, int age)
    {
        Name = name;
        Price = price;
        Manufacturer = manufacturer;
        Material = material;
        Age = age;
    }

    // Реалізація методів інтерфейсу ITovar
    public void DisplayInfo()
    {
        Console.WriteLine($"Іграшка: {Name}");
        Console.WriteLine($"Ціна: {Price} грн");
        Console.WriteLine($"Виробник: {Manufacturer}");
        Console.WriteLine($"Матеріал: {Material}");
        Console.WriteLine($"Вік, на який розрахована: {Age}+");
        Console.WriteLine();
    }

    public bool IsMatch(string type)
    {
        return type == "Іграшка";
    }
}

// Клас Книга, який реалізує інтерфейс ITovar
public class Book : ITovar
{
    // Поля класу Книга
    public string Name { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public string Publisher { get; set; }
    public int Age { get; set; }

    // Конструктор класу Книга
    public Book(string name, string author, double price, string publisher, int age)
    {
        Name = name;
        Author = author;
        Price = price;
        Publisher = publisher;
        Age = age;
    }

    // Реалізація методів інтерфейсу ITovar
    public void DisplayInfo()
    {
        Console.WriteLine($"Книга: {Name}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Ціна: {Price} грн");
        Console.WriteLine($"Видавництво: {Publisher}");
        Console.WriteLine($"Вік, на який розрахована: {Age}+");
        Console.WriteLine();
    }

    public bool IsMatch(string type)
    {
        return type == "Книга";
    }
}

// Клас СпортІнвентар, який реалізує інтерфейс ITovar
public class SportsEquipment : ITovar
{
    // Поля класу СпортІнвентар
    public string Name { get; set; }
    public double Price { get; set; }
    public string Manufacturer { get; set; }
    public int Age { get; set; }

    // Конструктор класу СпортІнвентар
    public SportsEquipment(string name, double price, string manufacturer, int age)
    {
        Name = name;
        Price = price;
        Manufacturer = manufacturer;
        Age = age;
    }

    // Реалізація методів інтерфейсу ITovar
    public void DisplayInfo()
    {
        Console.WriteLine($"Спортінвентар: {Name}");
        Console.WriteLine($"Ціна: {Price} грн");
        Console.WriteLine($"Виробник: {Manufacturer}");
        Console.WriteLine($"Вік, на який розрахований: {Age}+");
        Console.WriteLine();
    }

    public bool IsMatch(string type)
    {
        return type == "СпортІнвентар";
    }
}

// Основний клас програми
class Program
{
    static void Main(string[] args)
    {
        // Створення бази (масиву) товарів
        ITovar[] goods = new ITovar[]
        {
            new Toy("Лего", 300, "LEGO Group", "Пластик", 6),
            new Book("Гаррі Поттер і філософський камінь", "Дж. К. Роулінг", 250, "Блумсбері", 10),
            new SportsEquipment("Футбольний м'яч", 150, "Nike", 12),
            new Toy("Барбі", 200, "Mattel", "Пластик", 3),
            new Book("Майстер і Маргарита", "Михайло Булгаков", 180, "Молодь", 16),
            new SportsEquipment("Бігові кросівки", 500, "Adidas", 18)
        };

        // Виведення повної інформації про товари з бази
        Console.WriteLine("Повна інформація про товари:");
        foreach (var item in goods)
        {
            item.DisplayInfo();
        }

        // Пошук товарів певного типу (наприклад, Іграшка)
        string searchType = "Іграшка";
        Console.WriteLine($"Пошук товарів типу: {searchType}");
        foreach (var item in goods)
        {
            if (item.IsMatch(searchType))
            {
                item.DisplayInfo();
            }
        }
    }
}
