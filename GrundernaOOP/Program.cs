/*
 * Author: Theodor Hägg (.NET23)
 * Website: https://github.com/etheoo98/Labb3-GrundernaOOP
 * Date: October 3, 2023
 */

using GrundernaOOP.Geometry;
using GrundernaOOP.Locales;

namespace GrundernaOOP;

internal static class Program
{
    public static void Main()
    {
        Lang.SetLocale();

        Circle[] circles = { new(5), new(6) };
        Triangle[] triangles = { new(5, 5, 4), new(12, 5) };

        PrintCircleArray(circles);
        PrintTriangleArray(triangles);
    }

    private static void PrintCircleArray(Circle[] circles)
    {
        var currentItem = 1;
        
        foreach (var circle in circles)
        {
            Console.WriteLine($"{Lang.General["Circle"]} #{currentItem}:");
            circle.PrintProperties();
            
            Console.WriteLine();
            currentItem++;
        }
    }

    private static void PrintTriangleArray(Triangle[] triangles)
    {
        var currentItem = 1;
        
        foreach (var triangle in triangles)
        {
            Console.WriteLine($"{Lang.General["Triangle"]} #{currentItem}:");
            triangle.PrintProperties();
            
            Console.WriteLine();
            currentItem++;
        }
    }
}