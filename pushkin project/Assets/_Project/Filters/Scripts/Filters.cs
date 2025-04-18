using System;
using System.Collections.Generic;

[Serializable]
public struct Filters
{
    public int MaxDateTime;
    public int MinDateTime;
    public List<Author> Authors;
}
