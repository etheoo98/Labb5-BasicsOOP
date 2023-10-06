using GrundernaOOP.Models;

namespace GrundernaOOP.Locales.Sv;

public static class Swedish
{
    public static readonly Dictionary<string, string> Headers = new()
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

    public static readonly Dictionary<TypeOfTriangle, string> TriangleTypes = new()
    {
        { TypeOfTriangle.Equilateral, "Liksidig" },
        { TypeOfTriangle.Isosceles, "Likbent" },
        { TypeOfTriangle.Scalene, "Oliksidig" }
    };
}