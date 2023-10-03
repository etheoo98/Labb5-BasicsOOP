using System.Text;
using GrundernaOOP.Geometry;
using GrundernaOOP.Locales.en;
using GrundernaOOP.Locales.ru;
using GrundernaOOP.Locales.sv;

namespace GrundernaOOP.Locales;

public static class Lang
{
    public static Dictionary<string, string> General { get; private set; } = null!;
    public static Dictionary<Triangle.TypeOfTriangle, string> TriangleTypes { get; private set; } = null!;

    public static void SetLocale()
    {
        // Store current language ISO code.
        var iso = System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
        
        switch (iso)
        {
            case "sv":
                General = Swedish.General;
                TriangleTypes = Swedish.TriangleTypes;
                break;
            case "ru":
                Console.OutputEncoding = Encoding.UTF8;
                General = Russian.General;
                TriangleTypes = Russian.TriangleTypes;
                break;
            default: // English is chosen if no case covers the user's language.
                General = English.General;
                TriangleTypes = English.TriangleTypes;
                break;
        }
    }
}