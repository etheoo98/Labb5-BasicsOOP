using BasicsOOP.Models;

namespace BasicsOOP.Locales.Ru;

public static class Russian
{
    public static readonly Dictionary<string, string> Headers = new()
    {
        { "Circle", "Круг" },
        { "Area", "Площадь" },
        { "Radius", "Радиус" },
        { "Circumference", "Длина окружности" },
        { "TriangleType", "Тип треугольника" },
        { "SphereArea", "Площадь сферы" },
        { "SphereVolume", "Объём сферы" },
        { "Triangle", "Треугольник" },
        { "SideA", "Сторона А" },
        { "SideB", "Сторона Б" },
        { "SideC", "Сторона В" },
        { "AngleA", "Угол А" },
        { "AngleB", "Угол Б" },
        { "AngleC", "Угол В" }
    };

    public static readonly Dictionary<TypeOfTriangle, string> TriangleTypes = new()
    {
        { TypeOfTriangle.Equilateral, "Равносторонний" },
        { TypeOfTriangle.Isosceles, "Равнобедренный" },
        { TypeOfTriangle.Scalene, "Разносторонний" }
    };
}