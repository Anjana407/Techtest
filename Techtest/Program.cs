using System;
using System.Collections.Generic;
using Techtest.Helper;
using Techtest;


class Program
{
    // Function that returns true if x < y
    // according to the new alphabetical order
    private static int Compare(string x, string y)
    {
        var str1 = x.ToCharArray();
        var str2 = y.ToCharArray();
        Array.Sort(str1);
        Array.Sort(str2);
        int minSize = Math.Min(str1.Length, str2.Length);
        for (int i = 0; i < minSize; i++)
        {
            if (str1[i] == str2[i])
                continue;
            else if (str1[i] > str2[i])
                return 1;
            else
                return -1;
        }
        return 0;
    }

    // Driver code
    static void Main(string[] args)
    {

        // Challenge 1- Sort it out
        var Comparer = new CustomComparer();
        List<string> v = new List<string> { "dog", "snake", "donkey" };
        v.Sort((x, y) => Comparer.Compare(x, y));
        // Print the strings after sorting
        foreach (var x in v)
            Console.Write(x + " ");



        //Challenge 2 – Bob’s New Business: Rent a Car!
        RentalCar car = new RentalCar();
        Console.WriteLine("Enter a start Date");
        var startDate = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Enter number of rental days");
        int noOfDays = Convert.ToInt32(Console.ReadLine());
        var totalPrice = car.TotalPrice(startDate, noOfDays);
        Console.WriteLine($"Total price for the duration is {totalPrice}$");
        Console.ReadLine();

    }
}