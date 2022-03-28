using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PiiTypes.EFCore3;

public class PiiStringConverter : ValueConverter<PiiString, string>
{
    public PiiStringConverter(IPiiEncoder encoder) : base(
        v => encoder.ToSystemString(v),
        v => encoder.ToPiiString(v))
    {
    }
}
