using System;
using System.Diagnostics;
using System.Text;

public class Test
{
    public static void Main()
    {



        //Program 1


        Console.WriteLine("Hello, Please enter the maximum number you need to add");

        string? maxnum;

        Console.WriteLine("Please enter a maximum number:");
        maxnum = Console.ReadLine();


        int MAX;

        while (!int.TryParse(maxnum, out MAX))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
            maxnum = Console.ReadLine();
        }

        Console.WriteLine($"The maximum number is: {MAX}");




        //Method 1 the time complexity is O(n)
        int sum = 0;
        for (int iterator = 1; iterator <= MAX; iterator++)
        {
            sum = sum + iterator;
        }

        //Method 2 using this equation is O(3) which is constant so it is app. O(1) 
        int seriesSum = MAX * (MAX + 1) / 2;

        Console.WriteLine($"The sum of numbers from 1 to {MAX} = {sum}");
        Console.WriteLine($"The sum of numbers from 1 to {MAX} = {seriesSum} using series form");






        //-----------------------------------------------------------



        //Program 2

        Console.WriteLine("Hello, Please enter the maximum number you need to write");

        string? maximumNumberFromUser;
        maximumNumberFromUser = Console.ReadLine();

        int maximumNumber;
        maximumNumber = Convert.ToInt32(maximumNumberFromUser);


        //Method 1 
        /*
         * String Concatenation: 
        𝑂(𝑛^2)

        -->Inefficient due to repeated copying of strings.
        -->Poor performance for large values of maximumNumber.
         */

        string numbers = string.Empty;

        for (int i = 1; i <= maximumNumber; i++)
        {
            if (i == maximumNumber) numbers = $"{numbers}{i}";
            else numbers = $"{numbers}{i},";
        }

        Console.WriteLine(numbers);


        //Method 2

        /*
         * StringBuilder: 
        𝑂(𝑛)

        -->Efficient due to reduced copying.
        -->Suitable for large values of maximumNumber.
         */

        StringBuilder numbersNewApproach = new();

        for (int i = 1; i <= maximumNumber; i++)
        {
            if (i == maximumNumber) numbersNewApproach.Append($"{i}");
            else numbersNewApproach.Append($"{i},");
        }



        Console.WriteLine(numbersNewApproach);

    }
}