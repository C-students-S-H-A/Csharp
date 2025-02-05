using System;
class program
{
    static void Main()
    {
        double firstprice, finalprice, discont;
        Console.Write("Enter first price: ");
        firstprice =double.Parse(Console.ReadLine());
        Console.Write("Enter final price: ");
        discont = double.Parse(Console.ReadLine());
        finalprice = firstprice * (100 - discont) / 100;
        Console.WriteLine("final price: "+finalprice);
        Console.ReadKey();

    }

}