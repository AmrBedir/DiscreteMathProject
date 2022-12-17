using System;
public class Project1
{
    public static void Main()
    {
        int num, i, ctr, Number1, Number2;

        Console.Write("\n");
        Console.Write("Prime Numbers in a range from N1 to N2:\n");
        Console.Write("---------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Enter N1: ");
        Number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter N2: ");
        Number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nPrime Numbers between {0} and {1} are: \n", Number1, Number2);

        for (num = Number1; num <= Number2; num++)
        {
            ctr = 0;

            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    ctr++;
                    break;
                }
            }

            if (ctr == 0 && num != 1)
                Console.Write("{0} ", num);
        }
        Console.Write("\n");
    }
}