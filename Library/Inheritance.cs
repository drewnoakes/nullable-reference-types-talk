#nullable enable

interface IBase
{
    string? M(string s);
}

class Impl : IBase
{
    public string M(string? s) => "Impl.M";
}
