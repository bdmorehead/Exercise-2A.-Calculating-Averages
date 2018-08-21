using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2A___Calculating_Averages
{
    class Sum
    {
        public Sum()
        {
            numbers = new List<int>();
        }
    
        public void addNumber(int number)
        {
            numbers.Add(number);
        }
        List<int> numbers;
    }
}
