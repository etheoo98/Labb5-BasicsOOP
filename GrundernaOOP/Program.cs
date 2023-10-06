/*
 * Author: Theodor Hägg (.NET23)
 * Website: https://github.com/etheoo98/Labb5-GrundernaOOP
 * Date: October 6, 2023
 */

using GrundernaOOP.Factories;
using GrundernaOOP.Locales;
using GrundernaOOP.Models;
using GrundernaOOP.Services;

namespace GrundernaOOP;

internal static class Program
{
    public static void Main()
    {
        // Set application language.
        Lang.SetLocale();

        // Create an array of Circle objects.
        Circle[] circles =
        {
            CircleFactory.Create(5),
            CircleFactory.Create(6)
        };

        // Create an array of Triangle objects.
        Triangle[] triangles =
        {
            TriangleFactory.Create(new[] { 3, 5, 4 }),
            TriangleFactory.Create(new[] { 5, 5 })
        };

        CircleService.PrintCircleArray(circles);
        TriangleService.PrintTriangleArray(triangles);
    }
}