using System;
class program
{
    static void Main()
    {
        int mony, ten1000, fifty1000, hezari;
        Console.Write("Enyer mony: ");
        mony=int.Parse(Console.ReadLine());
        fifty1000 = mony / 50000;
        mony = mony % 50000;
        ten1000 = mony / 10000;
        hezari = mony / 1000;
        Console.WriteLine("number of 50000= " + fifty1000);
        Console.WriteLine("number of 10000= " + ten1000);
        Console.WriteLine("number of 1000= "+hezari);
        Console.ReadKey();

    }

}