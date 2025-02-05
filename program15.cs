using System;
class program
{
    static void Main()
    {
        int n = 0, b = 4, a = 5;
        Console.WriteLine(a + b * n);
        n += 1;
        Console.WriteLine(b + a * n);
        n += 1;
        Console.WriteLine(a + b * n);
        n += 1;
        Console.WriteLine(b + a * n);
        Console.ReadKey();

    }

}