using System;
class program
{
    static void Main()
    {
        double d1, d2, d3, d4, d5, d6, avg;
        Console.Write("Enter your First Mark")
            d1=double.Parse(Console.ReadLine());
        Console.Write("Enter your Second Mark")
            d2 = double.Parse(Console.ReadLine());
        Console.Write("Enter your Third Mark")
            d3 = double.Parse(Console.ReadLine());
        Console.Write("Enter your Fourth Mark")
            d4 = double.Parse(Console.ReadLine());
        Console.Write("Enter your Fifth Mark")
            d5 = double.Parse(Console.ReadLine());
        Console.Write("Enter your Sixth Mark")
            d6 = double.Parse(Console.ReadLine());
        avg = (d1 + d2 + d3 + d4 + d5 + d6) / 6;
        Console.Write("The students Average is= " + avg);
        Console.ReadKey();

    }

}