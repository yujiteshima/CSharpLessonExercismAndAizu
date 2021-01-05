```cs
using System;

public static class ResistorColor
{
    public static int ColorCode(string color) => Array.IndexOf(Colors(), color);

    public static string[] Colors() => new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
}
```

```cs
using System;

public static class ResistorColor
{
    private static string[] colors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    public static int ColorCode(string color) => Array.IndexOf(colors, color);
    public static string[] Colors() => colors;
}
```

```cs
using System;
using System.Linq;

public static class ResistorColor
{
    public static int ColorCode(string color) => Array.IndexOf(Colors(), color);

    public static string[] Colors() => new[]
        {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
}
```

