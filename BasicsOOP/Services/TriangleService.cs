using BasicsOOP.Models;

namespace BasicsOOP.Services;

public static class TriangleService
{ 
    public static void PrintTriangleArray(Triangle[] triangles)
    {
        for (var i = 0; i < triangles.Length; i++)
        {
            Console.WriteLine($"Triangle #{i+1}:");
            PrintProperties(triangles[i]);
        }
    }

    private static void PrintProperties(Triangle triangle)
    {
        Console.WriteLine($"Side A: {Math.Round(triangle.SideA, 2)}, " +
                          $"Side B: {Math.Round(triangle.SideB, 2)}, " +
                          $"Side C: {Math.Round(triangle.SideC, 2)}.");
        
        Console.WriteLine($"Area: {Math.Round(triangle.Area, 2)}");
        Console.WriteLine($"Type: {triangle.GetTriangleType()}\n");
    }
}