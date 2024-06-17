using System;

// Приклад класу TestBase з необхідними властивостями і конструкторами
public abstract class TestBase
{
    public string Name { get; set; }
    public int Duration { get; set; }
    public string Subject { get; set; }

    // Конструктор з трьома аргументами
    protected TestBase(string name, int duration, string subject)
    {
        Name = name;
        Duration = duration;
        Subject = subject;
    }
}

// Приклад класу, який успадковує TestBase і використовує його властивості та конструктор
public class Exam : TestBase
{
    public int TotalMarks { get; set; }

    public Exam(string name, int duration, string subject, int totalMarks)
        : base(name, duration, subject)
    {
        TotalMarks = totalMarks;
    }

    public void Display()
    {
        Console.WriteLine($"Назва: {Name}");
        Console.WriteLine($"Тривалість: {Duration} хвилин");
        Console.WriteLine($"Предмет: {Subject}");
        Console.WriteLine($"Загальна кількість балів: {TotalMarks}");
    }
}

// Основна програма для демонстрації використання класу Exam
class Program
{
    static void Main(string[] args)
    {
        Exam midtermExam = new Exam("Проміжний іспит", 90, "Фізика", 100);
        midtermExam.Display();
    }
}
