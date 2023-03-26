using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm
{
    internal class PrimeNumbers
    {
        public void PrintPrime()
        {
            Console.WriteLine("Enter lower limit");
            int lower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Higher Limit");
            int upper = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for(int i=lower; i<=upper; i++)
            {
                for(int j = 2;j<=i/2;j++)
                {
                    if(i%j == 0)
                    {
                        flag = 1;
                        break;
                    }
                    flag = 0;
                }
                if(flag ==0 && i != 0 && i !=1)
                Console.WriteLine(i);
            }
        }
    }
}
