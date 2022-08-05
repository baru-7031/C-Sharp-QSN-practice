using System;

class divides
{
    static void Main(String[] args)
    {
        Console.Write("Enter Range to find 3 divition and 5 divition : ");

        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <=n; i++)
        {
            if((i % 3) == 0)
            {
                Console.Write(i + " ");
            }
            else if((i % 5) == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}