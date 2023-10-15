/*
 * Author: Theodor Hägg (.NET23)
 * Website: https://github.com/etheoo98/Labb5-BasicsOOP
 * Date: October 6, 2023
 */

using BasicsOOP.Models;
using BasicsOOP.Services;

namespace BasicsOOP;

internal static class Program
{
    public static void Main()
    {
        // Create an array of Circle objects.
        Circle[] circles =
        {
            new(5),
            new(6)
        };
        
        CircleService.PrintCircleArray(circles);
        
        // Create an array of Triangle objects.
        Triangle[] triangles =
        {
            new(3, 5, 4),
            new(5,5)
        };
        
        TriangleService.PrintTriangleArray(triangles);
    }
}