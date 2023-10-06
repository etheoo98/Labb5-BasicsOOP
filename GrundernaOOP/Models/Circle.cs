namespace GrundernaOOP.Models;

public class Circle
{
    private double _radius;

    public double Radius
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

    public Circle(double radius) // Constructor
    {
        Radius = radius;
    }
    
    public double GetArea() => Math.PI * Math.Pow(Radius, 2); // A = πr²
    public double GetCircumference() => 2 * Math.PI * Radius; // C = 2πr
    public double GetSphereArea() => 4 * Math.PI * Math.Pow(Radius, 2); // A = 4πr² 
    public double GetSphereVolume() => (4.0/3.0) * Math.PI * Math.Pow(Radius, 3); // V = (4/3)πr³
}