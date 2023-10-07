namespace GrundernaOOP.Models;

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
                    "Attempted to assign non-positive value(s) to Sides. All values must be greater than 0.");
        }
    }

    public double SideA => _sides[0];
    public double SideB => _sides[1];
    public double SideC => _sides[2];
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

    // Method for calculating the unknown side's value.
    private static double GetSideC(double sideA, double sideB)
    {
        // Simplified Pythagorean theorem: c = √[a² + b²]
        return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
    }

    // Methods for heavier calculations
    public (double AngleA, double AngleB, double AngleC) GetAngles()
    {
        /*
         * Calculate the angles using the law of cosines.
         *
         * Since the length of every side is known, it is possible
         * to use the law of cosines to calculate every angle.
         */

        // a = arccos[(b² + c² - a²) / (2bc)]
        var angleA = Math.Acos((Math.Pow(SideB, 2) + Math.Pow(SideC, 2) - Math.Pow(SideA, 2)) /
                               (2 * SideB * SideC));

        // b = arccos[(a² + c² - b²) / (2ac)]
        var angleB = Math.Acos((Math.Pow(SideA, 2) + Math.Pow(SideC, 2) - Math.Pow(SideB, 2)) /
                               (2 * SideA * SideC));

        // c = arccos[(a² + b² - c²) / (2ab)]
        var angleC = Math.Acos((Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - Math.Pow(SideC, 2)) /
                               (2 * SideA * SideB));

        // Convert angles from radians to degrees.
        angleA = angleA * 180 / Math.PI;
        angleB = angleB * 180 / Math.PI;
        angleC = angleC * 180 / Math.PI;

        return (angleA, angleB, angleC);
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
            return TypeOfTriangle.Equilateral;

        // If two sides are equal.
        if (Math.Abs(SideA - SideB) < epsilon || Math.Abs(SideB - SideC) < epsilon ||
            Math.Abs(SideA - SideC) < epsilon)
            return TypeOfTriangle.Isosceles;

        // The type must be scalene since no side is equal.
        return TypeOfTriangle.Scalene;
    }
}