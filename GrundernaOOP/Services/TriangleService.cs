using GrundernaOOP.Locales;
using GrundernaOOP.Models;

namespace GrundernaOOP.Services;

public static class TriangleService
{
    public static void PrintTriangleArray(Triangle[] triangles)
    {
        var currentItem = 1;

        foreach (var triangle in triangles)
        {
            Console.WriteLine($"{Lang.Headers["Triangle"]} #{currentItem}:");
            PrintProperties(triangle);

            currentItem++;
        }
    }

    private static void PrintProperties(Triangle triangle)
    {
        Console.WriteLine($"{Lang.Headers["SideA"]}: {Math.Round(triangle.SideA, 2)}, " +
                          $"{Lang.Headers["SideB"]}: {Math.Round(triangle.SideB, 2)}, " +
                          $"{Lang.Headers["SideC"]}: {Math.Round(triangle.SideC, 2)}.");

        Console.WriteLine($"{Lang.Headers["TriangleType"]}: {Lang.TriangleTypes[triangle.GetTriangleType()]}");
        Console.WriteLine($"{Lang.Headers["Area"]}: {Math.Round(triangle.GetArea(), 2)}");

        var angles = triangle.GetAngles();
        Console.WriteLine($"{Lang.Headers["AngleA"]}: {Math.Round(angles.AngleA, 2)}\u00b0, " +
                          $"{Lang.Headers["AngleB"]}: {Math.Round(angles.AngleB, 2)}\u00b0, " +
                          $"{Lang.Headers["AngleC"]}: {Math.Round(angles.AngleC, 2)}\u00b0.\n");
    }
}