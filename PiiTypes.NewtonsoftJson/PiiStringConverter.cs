using Newtonsoft.Json;

// https://stackoverflow.com/a/52528455
#pragma warning disable CS8765

namespace PiiTypes.NewtonsoftJson;

public class PiiStringConverter : JsonConverter<PiiString>
{
    private readonly IPiiEncoder _encoder;

    public PiiStringConverter(IPiiEncoder encoder)
        => _encoder = encoder;

    public override PiiString? ReadJson(JsonReader reader, Type _, PiiString? __, bool ___, JsonSerializer ____)
        => reader.Value is string valueAsString
            ? _encoder.ToPiiString(valueAsString)
            : null;

    public override void WriteJson(JsonWriter writer, PiiString value, JsonSerializer _)
        => writer.WriteValue(_encoder.ToSystemString(value));
}
