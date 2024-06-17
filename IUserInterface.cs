using System;

// Інтерфейси
public interface IUserInterface
{
    void Display();
}

public interface IDotNetInterface
{
    void DotNetSpecificMethod();
}

// Абстрактний базовий клас
public abstract class TestBase : IUserInterface, IDotNetInterface
{
    // Загальні властивості
    public string Name { get; set; }
    public int Duration { get; set; }
    public string Subject { get; set; }

    // Конструктор
    protected TestBase(string name, int duration, string subject)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Duration = duration;
        Subject = subject ?? throw new ArgumentNullException(nameof(subject));
    }

    // Абстрактний метод, який потрібно реалізувати в похідних класах
    public abstract void Display();

    // Метод інтерфейсу IDotNetInterface
    public void DotNetSpecificMethod()
    {
        Console.WriteLine("Специфічна функціональність .NET.");
    }
}

// Похідні класи
public class Exam : TestBase
{
    public int TotalMarks { get; set; }

    public Exam(string name, int duration, string subject, int totalMarks)
        : base(name, duration, subject)
    {
        TotalMarks = totalMarks;
    }

    public override void Display()
    {
        Console.WriteLine($"Назва: {Name}");
        Console.WriteLine($"Тривалість: {Duration} хвилин");
        Console.WriteLine($"Предмет: {Subject}");
        Console.WriteLine($"Загальна кількість балів: {TotalMarks}");
    }
}

public class FinalExam : Exam
{
    public bool IsMandatory { get; set; }

    public FinalExam(string name, int duration, string subject, int totalMarks, bool isMandatory)
        : base(name, duration, subject, totalMarks)
    {
        IsMandatory = isMandatory;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Обов'язковий: {IsMandatory}");
    }
}

public class Trial : TestBase
{
    public string Type { get; set; }

    public Trial(string name, int duration, string subject, string type)
        : base(name, duration, subject)
    {
        Type = type;
    }

    public override void Display()
    {
        Console.WriteLine($"Назва: {Name}");
        Console.WriteLine($"Тривалість: {Duration} хвилин");
        Console.WriteLine($"Предмет: {Subject}");
        Console.WriteLine($"Тип випробування: {Type}");
    }
}

// Основна програма
class Program
{
    static void Main(string[] args)
    {
        TestBase regularTest = new Trial("Математичний тест", 60, "Математика", "Тест");
        Exam midtermExam = new Exam("Проміжний іспит", 90, "Фізика", 100);
        FinalExam graduationExam = new FinalExam("Випускний іспит", 120, "Хімія", 150, true);
        Trial labTrial = new Trial("Лабораторне випробування", 45, "Хімія", "Лабораторне");

        Console.WriteLine("\nІнформація про тест TestBase:");
        regularTest.Display();

        Console.WriteLine("\nІнформація про іспит Exam:");
        midtermExam.Display();

        Console.WriteLine("\nІнформація про випускний іспит FinalExam:");
        graduationExam.Display();

        Console.WriteLine("\nІнформація про випробування Trial:");
        labTrial.Display();
    }
}
