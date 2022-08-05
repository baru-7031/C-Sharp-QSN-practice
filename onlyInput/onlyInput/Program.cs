using System;

class inputs
{
    static void Main(String[] args)
    {
        int f1 = int.Parse(Console.ReadLine());
        float f2 = float.Parse(Console.ReadLine());
        Console.WriteLine(f1.GetType());
        Console.WriteLine(f2.GetType());

        Console.WriteLine(f1);
        Console.WriteLine(f2);

        Console.WriteLine(f1 + f2);
    }
}