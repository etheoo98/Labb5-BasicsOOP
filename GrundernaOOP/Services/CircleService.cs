using GrundernaOOP.Locales;
using GrundernaOOP.Models;

namespace GrundernaOOP.Services;

public static class CircleService
{
    public static void PrintCircleArray(Circle[] circles)
    {
        var currentItem = 1;

        foreach (var circle in circles)
        {
            Console.WriteLine($"{Lang.Headers["Circle"]} #{currentItem}:");
            PrintProperties(circle);

            currentItem++;
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