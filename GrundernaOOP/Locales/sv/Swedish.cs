using GrundernaOOP.Geometry;

namespace GrundernaOOP.Locales.sv;

public static class Swedish
{
    public static readonly Dictionary<string, string> General = new()
    {
        { "Circle", "Cirkel" },
        { "Radius", "Radie" },
        { "Area", "Area" },
        { "Circumference", "Omkrets" },
        { "TriangleType", "Triangeltyp" },
        { "SphereArea", "Sfär area" },
        { "SphereVolume", "Sfär volym" },
        { "Triangle", "Triangel" },
        { "SideA", "Sida A" },
        { "SideB", "Sida B" },
        { "SideC", "Sida C" },
        { "AngleA", "Vinkel A" },
        { "AngleB", "Vinkel B" },
        { "AngleC", "Vinkel C" }
    };
    
    public static readonly Dictionary<Triangle.TypeOfTriangle, string> TriangleTypes = new()
    {
        { Triangle.TypeOfTriangle.Equilateral, "Liksidig" },
        { Triangle.TypeOfTriangle.Isosceles, "Likbent" },
        { Triangle.TypeOfTriangle.Scalene, "Oliksidig" }
    };
}