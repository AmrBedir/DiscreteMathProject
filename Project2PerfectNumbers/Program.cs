using System;
public class Project2
{
    public static void Main()
    {
        int n, i, sum;
        int Number1, Number2;

        Console.Write("\n\n");
        Console.Write("Perfect Numbers in a range from N1 to N2:\n");
        Console.Write("------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Enter N1: ");
        Number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter N2: ");
        Number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nPerfect Numbers between the given range are: \n");
        for (n = Number1; n <= Number2; n++)
        {
            i = 1;
            sum = 0;
            while (i < n)
            {
                if (n % i == 0)
                    sum = sum + i;
                i++;
            }
            if (sum == n)
                Console.Write("{0} ", n);
        }
        Console.Write("\n");
    }
}