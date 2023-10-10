using BasicsOOP.Models;

namespace BasicsOOP.Locales.En;

public static class English
{
    public static readonly Dictionary<string, string> Headers = new()
    {
        { "Circle", "Circle" },
        { "Radius", "Radius" },
        { "Area", "Area" },
        { "Circumference", "Circumference" },
        { "TriangleType", "Triangle type" },
        { "SphereArea", "Sphere area" },
        { "SphereVolume", "Sphere volume" },
        { "Triangle", "Triangle" },
        { "SideA", "Side A" },
        { "SideB", "Side B" },
        { "SideC", "Side C" },
        { "AngleA", "Angle A" },
        { "AngleB", "Angle B" },
        { "AngleC", "Angle C" }
    };

    public static readonly Dictionary<TypeOfTriangle, string> TriangleTypes = new()
    {
        { TypeOfTriangle.Equilateral, "Equilateral" },
        { TypeOfTriangle.Isosceles, "Isosceles" },
        { TypeOfTriangle.Scalene, "Scalene" }
    };
}