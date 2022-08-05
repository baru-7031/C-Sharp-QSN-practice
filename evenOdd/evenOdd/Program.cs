using System;

class even
{
    static void Main(String[] args)
    {
        int a = 401;

        if((a & 1) == 0)
        {
            Console.WriteLine(a+" is a even number");
        }
        else
        {
            Console.WriteLine(a + " is a Odd Number");
        }
    }
}