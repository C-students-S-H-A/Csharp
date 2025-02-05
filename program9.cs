using System;
class program
{
    static void Main()
    {
        int X, Y, Z, result;
        Console.Write("Enter X: ");
        X=int.Parse(Console.ReadLine());
        Console.Write("Enter Y: ");
        Y=int.Parse(Console.ReadLine());
        Console.Write("Enter Z: ");
        Z=int.Parse(Console.ReadLine());
        result = (X * X * X) + ((10 * Y) / Z);
        Console.ReadKey();

    }

}