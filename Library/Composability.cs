#nullable enable

using System;
using System.Collections.Generic;

class Composability
{
    void M()
    {
        List<string>   list1;
        List<string>?  list2;
        List<string?>  list3;
        List<string?>? list4;

        Func<string, string?> func;
    }
}
