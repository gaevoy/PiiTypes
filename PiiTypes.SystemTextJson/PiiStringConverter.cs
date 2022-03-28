using System.Text.Json;
using System.Text.Json.Serialization;

namespace PiiTypes.SystemTextJson;

public class PiiStringConverter : JsonConverter<PiiString>
{
    private readonly IPiiEncoder _encoder;

    public PiiStringConverter(IPiiEncoder encoder)
        => _encoder = encoder;

    public override PiiString? Read(ref Utf8JsonReader reader, Type _, JsonSerializerOptions __)
    {
        var str = reader.GetString();
        return str switch
        {
            null => null,
            _ => _encoder.ToPiiString(str)
        };
    }

    public override void Write(Utf8JsonWriter writer, PiiString value, JsonSerializerOptions _)
        => writer.WriteStringValue(_encoder.ToSystemString(value));
}
