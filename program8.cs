using System;
class program
{
    static void Main()
    {
        string first, second;
        Console.Write("Enter First Number: ");
        first =int.Parse(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        second =int.Parse(Console.ReadLine());
        Console.WriteLine(first + "+" + second + "=" + (first + second));
        Console.WriteLine(first + "-" + second + "=" + (first - second));
        Console.WriteLine(first + "*" + second + "=" + (first * second));
        Console.WriteLine(first + "/" + second + "=" + (first / second));
        Console.ReadKey();

    }

}