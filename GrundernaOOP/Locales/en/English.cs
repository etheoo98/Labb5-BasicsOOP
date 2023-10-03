using GrundernaOOP.Geometry;

namespace GrundernaOOP.Locales.en;

public static class English
{
    public static readonly Dictionary<string, string> General = new()
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
    
    public static readonly Dictionary<Triangle.TypeOfTriangle, string> TriangleTypes = new()
    {
        { Triangle.TypeOfTriangle.Equilateral, "Equilateral" },
        { Triangle.TypeOfTriangle.Isosceles, "Isosceles" },
        { Triangle.TypeOfTriangle.Scalene, "Scalene" }
    };
}