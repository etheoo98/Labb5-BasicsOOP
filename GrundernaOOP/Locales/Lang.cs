using System.Globalization;
using System.Text;
using GrundernaOOP.Locales.En;
using GrundernaOOP.Locales.Ru;
using GrundernaOOP.Locales.Sv;
using GrundernaOOP.Models;

namespace GrundernaOOP.Locales;

public static class Lang
{
    public static Dictionary<string, string> Headers { get; private set; } = null!;
    public static Dictionary<TypeOfTriangle, string> TriangleTypes { get; private set; } = null!;

    public static void SetLocale()
    {
        // Store current language ISO code.
        var iso = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
        
        switch (iso)
        {
            case "sv":
                Headers = Swedish.Headers;
                TriangleTypes = Swedish.TriangleTypes;
                break;
            case "ru":
                Console.OutputEncoding = Encoding.UTF8;
                Headers = Russian.Headers;
                TriangleTypes = Russian.TriangleTypes;
                break;
            default:
                Headers = English.Headers;
                TriangleTypes = English.TriangleTypes;
                break;
        }
    }
}