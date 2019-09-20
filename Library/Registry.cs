using System.Collections.Generic;

public sealed class Registry
{
    private readonly Dictionary<string, string> _valueByKey = new Dictionary<string, string>();

    public void Add(string key, string value)
    {
        _valueByKey.Add(key, value);
    }

    public string Find(string key)
    {
        if (_valueByKey.TryGetValue(key, out string value))
        {
            return value;
        }

        return null;
    }
}
