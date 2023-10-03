using GrundernaOOP.Geometry;

namespace GrundernaOOP.Locales.ru;

public static class Russian
{
    public static readonly Dictionary<string, string> General = new()
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
    
    public static readonly Dictionary<Triangle.TypeOfTriangle, string> TriangleTypes = new()
    {
        { Triangle.TypeOfTriangle.Equilateral, "Равносторонний" },
        { Triangle.TypeOfTriangle.Isosceles, "Равнобедренный" },
        { Triangle.TypeOfTriangle.Scalene, "Разносторонний" }
    };
}