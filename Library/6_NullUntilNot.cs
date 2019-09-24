#nullable enable

using System;

class NullUntilNot
{
    private string? _id;

    public string? Id
    {
        get => _id;
        set => _id = value ?? throw new ArgumentNullException(nameof(value));
    }

    void Example()
    {
        Id = "";
        Id = null;
    }
}
