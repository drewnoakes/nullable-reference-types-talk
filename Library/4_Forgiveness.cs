#nullable enable

class StringThing
{
    string WhicheverIsNotNullOtherwiseEmpty(string? s1, string? s2)
    {
        if (s1 != null || s2 != null)
        {
            return s1 ?? s2; // CS8603 Possible null reference return
        }

        return "";
    }
}
