using BasicsOOP.Models;

namespace BasicsOOP.Services;

public static class CircleService
{ 
    public static void PrintCircleArray(Circle[] circles)
    {
        for (var i = 0; i < circles.Length; i++)
        {
            Console.WriteLine($"Circle #{i+1}:");
            PrintProperties(circles[i]);
        }
    }

    private static void PrintProperties(Circle circle)
    {
        Console.WriteLine($"Radius: {circle.Radius}");
        Console.WriteLine($"Area: {Math.Round(circle.Area, 2)}");
        Console.WriteLine($"Circumference: {Math.Round(circle.Circumference, 2)}");
        Console.WriteLine($"Sphere area: {Math.Round(circle.SphereArea, 2)}");
        Console.WriteLine($"Sphere volume: {Math.Round(circle.SphereVolume, 2)}\n");
    }
}