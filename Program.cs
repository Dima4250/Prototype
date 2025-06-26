// Базовый интерфейс прототипа
public interface IPrototype
{
    IPrototype Clone();
}

// Конкретный класс для клонирования
public class ConcretePrototype : IPrototype
{
    public int Id { get; set; }
    public string Name { get; set; }

    public IPrototype Clone()
    {
        // Поверхностное копирование
        return (IPrototype)this.MemberwiseClone();
    }
}

// Использование
class Program
{
    static void Main()
    {
        var original = new ConcretePrototype { Id = 1, Name = "Оригинал" }; // экземпляр класса
        var clone = (ConcretePrototype)original.Clone();

        clone.Name = "Клон";
        Console.WriteLine($"Оригинал: {original.Name}"); // Оригинал и его имя
        Console.WriteLine($"Клон: {clone.Name}");       // Клон и его имя
    }
}
