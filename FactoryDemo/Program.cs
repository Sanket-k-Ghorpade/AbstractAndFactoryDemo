// Product Interface
public interface ICar
{
    void Drive();
}

// Concrete Products
public class Sedan : ICar
{
    public void Drive()
    {
        Console.WriteLine("Driving a Sedan");
    }
}

public class SUV : ICar
{
    public void Drive()
    {
        Console.WriteLine("Driving an SUV");
    }
}

// Factory
public class CarFactory
{
    public static ICar CreateCar(string type)
    {
        switch (type)
        {
            case "sedan": return new Sedan();
            case "suv": return new SUV();
            default: throw new ArgumentException("Invalid car type");
        }
    }
}

// Client Code
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Which type of car are you looking for: sedan or suv");
        string choice = Console.ReadLine().ToLower();

        ICar car = CarFactory.CreateCar(choice);
        car.Drive();
    }
}