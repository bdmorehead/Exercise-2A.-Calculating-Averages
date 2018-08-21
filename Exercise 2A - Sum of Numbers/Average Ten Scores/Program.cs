using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Ten_Scores
{
    class Program
    // Create a console application that will accept
    // ten test scores between 0 and 100, average them, 
    // and report a letter grade for the average based
    // on the usual scale. For example, a teacher will
    // input ten test scores and see the average numerical 
    // grade and the letter grade.
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter test grade: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Please enter test grade: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int sum1 = n1 + n2;

            Console.Write("Please enter test grade: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
          
            Console.Write("Please enter test grade: ");
            int n4 = Convert.ToInt32(Console.ReadLine());
            int sum2 = n3 + n4;

            Console.Write("Please enter test grade: ");
            int n5 = Convert.ToInt32(Console.ReadLine());
          
            Console.Write("Please enter test grade: ");
            int n6 = Convert.ToInt32(Console.ReadLine());
            int sum3 = n5 + n6; 

            Console.Write("Please enter test grade: ");
            int n7 = Convert.ToInt32(Console.ReadLine());
          
            Console.Write("Please enter test grade: ");
            int n8 = Convert.ToInt32(Console.ReadLine());
            int sum4 = n7 + n8;

            Console.Write("Please enter test grade: ");
            int n9 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Please enter test grade: ");
            int n10 = Convert.ToInt32(Console.ReadLine());
            int sum5 = n9 + n10;
            int total = (sum1 + sum2 + sum3 + sum4 + sum5);
            int finaltotal = (total) / 10;

            Console.WriteLine("Average: {0}", (finaltotal));


            if (finaltotal >= 90)
            {
                Console.WriteLine("Grade is A");
            }
            else if ((finaltotal >= 80) && (finaltotal < 90))
            {
                Console.WriteLine("Grade is B");
            }
            else if ((finaltotal >= 70) && (finaltotal < 80))
            {
                Console.WriteLine("Grade is C");
            }
            else if ((finaltotal >= 60) && (finaltotal < 70))
            {
                Console.WriteLine("Grade is |D");
            }
            else if (finaltotal < 60)
            {
                Console.WriteLine("Grade is F");
            }
        }

    }

}
