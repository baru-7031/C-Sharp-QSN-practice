using System;

class inputEO
{
    static void Main(String[] args)
    {
        Console.Write("Enter any number to check even or odd : ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        if((a & 1) == 0)
        {
            Console.WriteLine("Even Number " + a);
        }
        else
        {
            Console.WriteLine("Odd Number " + a);  
        }
    }
}