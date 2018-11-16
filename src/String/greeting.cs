using System;
class greeting
{
    public static void greeting(string name)
    {
        if (name == "" || name == null)
        {
            Console.WriteLine("Welcome Stranger");
        }
        else
        {
            Console.WriteLine("Welcome " + name);
        }
    }
    
}
