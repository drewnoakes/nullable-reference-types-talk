#nullable enable

using System.Collections.Generic;

class Registry<T>
{
    private readonly Dictionary<string, T> _valueByKey = new Dictionary<string, T>();

    public T Get(string key)
    {
        _valueByKey.TryGetValue(key, out T value);
        return value;
    }

    static void Example()
    {
        int i = new Registry<int>().Get("i");
        
        string s1 = new Registry<string?>().Get("s");

        string s2 = new Registry<string>().Get("s");
    }
}
