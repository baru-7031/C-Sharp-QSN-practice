using System;

class seven
{
    static void Main(String[] args)
    {
        Console.Write("Enter range to see 7 divitions : ");
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            if((i % 7) == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}