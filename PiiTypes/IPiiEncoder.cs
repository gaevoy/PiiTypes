namespace PiiTypes;

public interface IPiiEncoder
{
    string ToSystemString(PiiString piiString);
    PiiString ToPiiString(string str);
}
