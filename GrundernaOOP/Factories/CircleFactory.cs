using GrundernaOOP.Models;

namespace GrundernaOOP.Factories;

public static class CircleFactory
{
    public static Circle Create(double radius)
    {
        return new Circle(radius);
    }
}