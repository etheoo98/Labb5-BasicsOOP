using GrundernaOOP.Locales;
using GrundernaOOP.Models;

namespace GrundernaOOP.Services;

public static class CircleService
{
    public static void PrintCircleArray(Circle[] circles)
    {
        for (var i = 0; i < circles.Length; i++)
        {
            Console.WriteLine($"{Lang.Headers["Circle"]} #{i+1}:");
            PrintProperties(circles[i]);
        }
    }

    private static void PrintProperties(Circle circle)
    {
        Console.WriteLine($"{Lang.Headers["Radius"]}: {circle.Radius}");
        Console.WriteLine($"{Lang.Headers["Area"]}: {Math.Round(circle.GetArea(), 2)}");
        Console.WriteLine($"{Lang.Headers["Circumference"]}: {Math.Round(circle.GetCircumference(), 2)}");
        Console.WriteLine($"{Lang.Headers["SphereArea"]}: {Math.Round(circle.GetSphereArea(), 2)}");
        Console.WriteLine($"{Lang.Headers["SphereVolume"]}: {Math.Round(circle.GetSphereVolume(), 2)}\n");
    }
}