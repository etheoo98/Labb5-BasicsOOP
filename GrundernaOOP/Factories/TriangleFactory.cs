using GrundernaOOP.Models;

namespace GrundernaOOP.Factories;

public static class TriangleFactory
{
    public static Triangle Create(int[] sides)
    {
        return sides.Length == 2
            ? new Triangle(sides[0], sides[1])
            : new Triangle(sides[0], sides[1], sides[2]);
    }
}