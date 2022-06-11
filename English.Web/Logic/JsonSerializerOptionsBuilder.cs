using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace English.Web.Logic;

public class JsonSerializerOptionsBuilder
{
    public JsonSerializerOptions BuildOptions() => new()
    {
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
    };
}
