using GrundernaOOP.Locales;

namespace GrundernaOOP.Geometry;

public class Circle
{

    private int _radius;
    public int Radius
    {
        get => _radius;
        set
        {
            if (value > 0)
                _radius = value;
            else
                throw new Exception($"Attempted to assign \"{value}\" to Radius. Value must be greater than 0.");
        }
    }
    
    public Circle(int radius) // Constructor
    {
        Radius = radius;
    }

    public double GetArea() => Math.PI * Math.Pow(Radius, 2); // A = πr²
    public double GetCircumference() => 2 * Math.PI * Radius; // C = 2πr
    public double GetSphereVolume() => (4.0/3.0) * Math.PI * Math.Pow(Radius, 3); // V = (4/3)πr³
    public double GetSphereArea() => 4 * Math.PI * Math.Pow(Radius, 2); // A = 4πr² 

    public void PrintProperties()
    {
        Console.WriteLine($"{Lang.General["Radius"]}: {Radius}");
        Console.WriteLine($"{Lang.General["Area"]}: {Math.Round(GetArea(), 2)}");
        Console.WriteLine($"{Lang.General["Circumference"]}: {Math.Round(GetCircumference(), 2)}");
        Console.WriteLine($"{Lang.General["SphereArea"]}: {Math.Round(GetSphereArea(), 2)}");
        Console.WriteLine($"{Lang.General["SphereVolume"]}: {Math.Round(GetSphereVolume(), 2)}");
    }
}