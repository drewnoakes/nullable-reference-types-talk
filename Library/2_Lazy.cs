class Lazy
{
    private string _value;

    public string Value
    {
        get
        {
            if (_value == null)
            {
                _value = Factory();
            }

            return _value;
        }
    }

    private static string Factory()
    {
        return "Expensive value";
    }
}
