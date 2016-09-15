using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemFourMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] example = { 20, 10, 5, 2 };
            Console.WriteLine("The sum of the example array is {0}", Sum(example));
        }
        //entering int array and returning int
        static int Sum(params int[] numbers)
        {
            int answer = 0;
            for(int i=0;i<=numbers.Length-1;i++)

            {
                answer += numbers[i];
            }
            return answer; 

        }
    }
}
