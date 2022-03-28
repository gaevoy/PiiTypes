using System;

namespace PiiTypes.Tests;

public class User
{
    public Guid Id { get; set; }
    public PiiString? Name { get; set; }
    public PiiString? Email { get; set; }
    public PiiString? Location { get; set; }
}
