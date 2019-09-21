#nullable enable

class Warnings
{
    object nonInitializedField; // CS8618 non-nullable field not initialised

    void AssignNullLiteral()
    {
        string s = null;        // CS8600 converting null literal to non-null type

        object? o = null;
        object o2 = o;          // CS8600 converting possible null value to non-null type
    }

    void ReceiveNull(string? s)
    {
        ReceiveNonNull(s);      // CS8604 possible 

        s.ToUpper();            // CS8602 dereference of possibly null value

        if (s != null)
        {
            ReceiveNonNull(s);

            s.ToUpper();
        }
    }

    void ReceiveNonNull(string s)
    {
    }
}
