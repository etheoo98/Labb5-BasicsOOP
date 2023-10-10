/*
 * Author: Theodor Hägg (.NET23)
 * Website: https://github.com/etheoo98/Labb5-BasicsOOP
 * Date: October 6, 2023
 */

using BasicsOOP.Locales;
using BasicsOOP.Services;

namespace BasicsOOP;

internal static class Program
{
    public static void Main()
    {
        // Set application language.
        Lang.SetLocale();
        
        // A demonstration of the program.
        CircleService.Sample();
        TriangleService.Sample();
    }
}