using System;
class program
{
    static void Main()
    {
        double firstprice, off, finalprice;
        Console.Write("Enter THe Price: ");
        firstprice =double.Parse(Console.ReadLine());
        Console.Write("Enter The off: ");
        off = double.Parse(Console.ReadLine());
        finalprice = double.Parse(Console.ReadLine());
        Console.WriteLine("Ehe final price is= "+finalprice);
        Console.ReadKey();

    }

}