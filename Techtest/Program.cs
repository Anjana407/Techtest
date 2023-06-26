using System;
using System.Collections.Generic;
using Techtest.Helper;
using Techtest;


class Program
{
    
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
