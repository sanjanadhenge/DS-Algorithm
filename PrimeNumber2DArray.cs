using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm
{
    internal class PrimeNumber2DArray
    {
        public void ScanPrime()
        {
            int[,] primeGroups = new int[250,250];
            int x = 0;
            for (int i = 0; i < 10; i++)
            {
                int start = 0;
                int end = 100;
                int[] R= new int[100];
                
                for (int j = 0; j < 100; j++)
                {

                    R = findPrimeNumbers(start,end);
                    primeGroups[i,j] = R[j];
                   
                 
                }
                start = end + 1;
                end = end + 100;
                x++;

            }
            Display(primeGroups,x);
        }
        public void Display(int[,] primeGroups,int x)
        {
            for(int i = 0;i < x;i++)
            {
                for( int j = 0;j < x;j++)
                {
                    Console.Write(primeGroups[i,j] +" ");    
                }
                Console.WriteLine("\n");
            }
        }
        
        public static int[] findPrimeNumbers(int start, int end)
        {
            


            int[] arr = new int[300];
            int flag = 0;
            int k = 0;
            for (int i = start; i <= end; i++)
            {
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                    flag = 0;
                }
                if (flag == 0 && i != 0 && i != 1)
                {
                    arr[k] = i;
                    k++;
                       
                }

            }

           return arr;
        }

    }
}

