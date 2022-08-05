using System;

class priime
{
    static void Main(String[] args)
    {
        ineligible:

        Console.Write("Enter Any Number to check prime or not : ");
        int n = int.Parse(Console.ReadLine());

        int i = 2;
        while(i<n)
        {
            if((n%i) == 0)
            {
                break;
            }

            i++;
        }

        if(n == i)
        {
            Console.WriteLine(n + " is a Prime number");
        }
        else
        {
            Console.WriteLine(n + " is a Not Prime Number \nTry Again");
            goto ineligible;
        }

    }
}

