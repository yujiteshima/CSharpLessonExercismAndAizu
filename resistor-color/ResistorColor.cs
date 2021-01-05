using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int idx = 0;
        while (true)
        {
            if (color == Colors()[idx])
            {
                break;
            }
            idx++;
        }
        return idx;
    }


    public static string[] Colors()
    {
        string[] colorsList = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        return colorsList;
    }
}