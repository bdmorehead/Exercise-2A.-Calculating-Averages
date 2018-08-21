using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2A___Calculating_Averages
{
    class Program
    {
        static void Main(string[] args)
        //Create a console application that will accept ten numbers between 0 
        //and 100, and report their sum.
        // Phase 1
        // CWL Ask the user for their numbers
        // CRL User inputs data (int)
        // Add the intergers together



        {
            Console.WriteLine("Write 10 numbers to calculate the sum:");

            Console.Write("1st number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2nd number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("You have {0} so far. What's next! ", (n1 + n2));
            int sum1 = n1 + n2;

            Console.Write("3rd number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Current amount: {0}", (sum1 + n3));
            int sum2 = sum1 + n3;

            Console.Write("4th number: ");
            int n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Current amount: {0}", (sum2 + n4));
            int sum3 = sum2 + n4;

            Console.Write("5th number: ");
            int n5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Current amount: {0}", (sum3 + n5));
            int sum4 = sum3 + n5;

            Console.Write("6th number: ");
            int n6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your over halfway, current amount {0}", (sum4 + n6));
            Console.WriteLine("Lets keep going");
            int sum5 = sum4 + n6;

            Console.Write("7th number: ");
            int n7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Current amount: {0}", (sum5 + n7));
            int sum6 = sum5 + n7;

            Console.Write("8th number: ");
            int n8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Current amount: {0}", (sum6 + n8));
            int sum7 = sum6 + n8;

            Console.Write("9th number: ");
            int n9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Current amount: {0}", (sum7 + n9));
            int sum8 = sum7 + n9;

            Console.Write("10th number: ");
            int n10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final amount: {0}", (sum8 + n10));
            
        }
    }
}
