```cs
using System;

public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.
    public static string Speak(string name = null) => string.Format("One for {0}, one for me.", name ?? "you");
}
```

```cs
using System;

public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.
    public static string Speak(string name = "you") => $"One for {name}, one for me.";
}
```

```cs
using System;

public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.
    public static string Speak(string name = "you") => $"One for {name ?? "you"}, one for me.";
}
```

```cs
using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        // Alternate comparison statement: if ( !(year % 4 == 0) || ((year % 100 == 0) && !(year % 400 == 0)) )
        if ( (year % 4 != 0) || ((year % 100 == 0) && (year % 400 != 0)) )
        {
            return false;
        }
        return true;
    }
}
```

```cs
using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }
}
```

```cs
public static class Leap
{
    public static bool IsLeapYear(int year) => year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
}
```

```cs
using System;

public static class Leap
{
    public static bool IsLeapYear(int year) => 
        (year % 400 == 0)
            || ((year % 100 != 0) && (year % 4 == 0));
}
```