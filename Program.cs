using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_N
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int N = (int)nums[0];
            int number = (int)nums[1];
            int remainder;

            string result = null;
            if (N >= 2 && N <= 10)
            {
                while (number > 0)
                {
                    remainder = N % number;
                    N /= number;
                    result = remainder.ToString() + result;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
            

       
        }
    }
}
