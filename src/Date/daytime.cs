using System;
class daytime
{
    public static void daytime()
    {
        var date = DateTime.Now;
        var hour = date.Hour + 1;

        Console.WriteLine(hour);
        if (hour < 12)
        {
            Console.WriteLine("Good morning");
        }
        else if (hour > 12 && hour < 18)
        {
            Console.WriteLine("Good day");
        }
        else
        {
            Console.WriteLine("Good evening");
        }
    }

}
