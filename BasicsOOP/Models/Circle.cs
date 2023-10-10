namespace BasicsOOP.Models;

public class Circle
{
    // Class fields
    private double _radius;

    // Class properties
    public double Radius
    {
        get => _radius;
        set
        {
            if (value > 0)
                _radius = value;
            else
                throw new Exception(
                    "Attempted to assign non-positive value to _radius (value must be greater than 0).");
        }
    }
    
    public double Area => Math.PI * Math.Pow(Radius, 2); // A = πr²
    public double Circumference => 2 * Math.PI * Radius; // C = 2πr
    public double SphereArea => 4 * Math.PI * Math.Pow(Radius, 2); // A = 4πr² 
    public double SphereVolume => 4.0/3.0 * Math.PI * Math.Pow(Radius, 3); // V = (4/3)πr³
    
    // Constructor
    public Circle(double radius)
    {
        Radius = radius;
    }
}