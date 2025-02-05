using System;
class program
{
    static void Main()
    {
        int X, Z, result;
        Console.Write("Enter X: ");
        X=int.Parse(Console.ReadLine());
        Console.Write("Enter Z: ");
        Z=int.Parse(Console.ReadLine());
        result = (8 + (X * X)) - (Z * 2);
        Console.WriteLine(result);
        Console.ReadKey();

    }

}