using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm
{
    internal class Anagram2DArray
    {
        public void GetPrime()
        {
            Console.WriteLine("Enter lower limit");
            int lower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Higher Limit");
            int upper = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[300];
            int flag = 0;
            int k = 0;
            for (int i = lower; i <= upper; i++)
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
            CheckAnagram(arr, k);


        }
        public void CheckAnagram(int[] arr, int k)
        {
            int[,] A = new int[250, 250];
            int x = 0;
            int flag = 0;
            for (int i = 0; i < k; i++)
            {

                for (int j = i + 1; j < k; j++)
                {
                    string name1 = arr[i].ToString();
                    string name2 = arr[j].ToString();
                    char[] result1 = name1.ToCharArray();
                    Array.Sort(result1);
                    char[] result2 = name2.ToCharArray();
                    Array.Sort(result2);
                    name1 = new String(result1);
                    name2 = new String(result2);
                    if (name1.Equals(name2))
                    {
                        flag = 1;
                        x++;
                    }
                    if(flag == 1)
                    {
                        A[i, j] = arr[j];
                        
                    }
                    

                }
            }
            Display(A, x);

        }
        public void Display(int[,] primeGroups, int x)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(primeGroups[i,j] + " ");
                }
               
            }
        }
    }
}
