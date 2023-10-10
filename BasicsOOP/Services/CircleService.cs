using BasicsOOP.Locales;
using BasicsOOP.Models;

namespace BasicsOOP.Services;

public static class CircleService
{
    public static void Sample()
    {
        // Create an array of Circle objects.
        Circle[] circles =
        {
            new(5),
            new(6)
        };
        
        PrintCircleArray(circles);
    }
    
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
        Console.WriteLine($"{Lang.Headers["Area"]}: {Math.Round(circle.Area, 2)}");
        Console.WriteLine($"{Lang.Headers["Circumference"]}: {Math.Round(circle.Circumference, 2)}");
        Console.WriteLine($"{Lang.Headers["SphereArea"]}: {Math.Round(circle.SphereArea, 2)}");
        Console.WriteLine($"{Lang.Headers["SphereVolume"]}: {Math.Round(circle.SphereVolume, 2)}\n");
    }
}