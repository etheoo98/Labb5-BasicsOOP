namespace BasicsOOP.Models;

// Enums
public enum TypeOfTriangle
{
    Equilateral,
    Isosceles,
    Scalene
}

public class Triangle
{
    // Class fields
    private double[] _sides = new double[3];

    // Class properties
    public double[] Sides
    {
        get => _sides;
        set
        {
            if (value[0] > 0 && value[1] > 0 && value[2] > 0)
                _sides = value;
            else
                throw new Exception(
                    "Attempted to assign non-positive value to _sides (value must be greater than 0).");
        }
    }

    public double SideA => Sides[0];
    public double SideB => Sides[1];
    public double SideC => Sides[2];
    public double Area
    {
        get
        {
            // Heron's formula: A = √[s(s - a)(s - b)(s - c)]
            var semiperimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));
        }
    }

    // Overloaded constructors
    public Triangle(double sideA, double sideB)
    {
        var sideC = GetSideC(sideA, sideB);
        Sides = new[] { sideA, sideB, sideC };
    }

    public Triangle(double sideA, double sideB, double sideC)
    {
        Sides = new[] { sideA, sideB, sideC };
    }
    
    private double GetSideC(double sideA, double sideB)
    {
        // Pythagoras theorem: c = √[a² + b²]
        return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
    }
    
    public TypeOfTriangle GetTriangleType()
    {
        // 1 * 10 to the power of -12 (0.000000000001).
        const double epsilon = 1E-12;

        /*
         * An epsilon comparison is used rather than "==" due to possible loss of fraction caused
         * by how the values are stored in memory.
         */

        // If all sides are equal.
        if (Math.Abs(SideA - SideB) < epsilon && Math.Abs(SideB - SideC) < epsilon)
        {
            return TypeOfTriangle.Equilateral;
        }

        // If two sides are equal.
        if (Math.Abs(SideA - SideB) < epsilon || Math.Abs(SideB - SideC) < epsilon ||
            Math.Abs(SideA - SideC) < epsilon)
        {
            return TypeOfTriangle.Isosceles;
        }

        // The type must be scalene since no side is equal.
        return TypeOfTriangle.Scalene;
    }
}