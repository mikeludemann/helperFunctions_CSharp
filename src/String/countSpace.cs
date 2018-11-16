using System;
public class counter
{
    public static int SpaceCount(string str)
    {
        int counter = 0;
        string valid;

        for (int i = 0; i < str.Length; i++)
        {
            valid = str.Substring(i, 1);

            if (valid == " ")
            {
                counter++;
            }
        }
        return counter;
    }
}
