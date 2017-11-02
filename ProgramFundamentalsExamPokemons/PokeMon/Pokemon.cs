using System;

class Pokemon
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        double originalValueHalf = n / 2;
        int count = 0;
        int intN = (int)n;

        while (true)
        {
            if (n == originalValueHalf && n > y && y > 0)
            {
                intN /= y;
                n = intN;
            }

            if (n < m)
            {
                break;
            }

            intN -= (int)m;

            n -= m;
            count++;
        }

        Console.WriteLine(n);
        Console.WriteLine(count);
    }
}