using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm
{
    internal class MergeSort
    {
        public void ReadFile(string filepath)
        {
            string readData = File.ReadAllText(filepath);
            string[] words = readData.Split(" ");
            int[] arr = new int[words.Length];
            int count = 0;
            foreach (var data in words)
            {
                arr[count] = Convert.ToInt32(data);
                count++;
                Console.WriteLine(data);
            }
            int start = 0;
            int end = words.Length;
            Merge_Sort(arr, start, end-1);
            Console.WriteLine("After Sorting ------------------>");
            Display(arr, start, end);
            
        }
        public void Merge_Sort(int[] arr,int start,int end)
        {
            if(start<end)
            {
                int m= start+(end-start)/2;
                Merge_Sort(arr,start,m);
                Merge_Sort(arr, m + 1, end);
                Merge(arr, start, end, m);
            }
        }
        public void Merge(int[] arr, int start, int end,int mid)
        {
            int i, j, k;
            int n1 = mid-start+1;
            int n2 = end-mid;
            int [] a = new int[n1];
            int[] b= new int[n2];
           
            for( i=0; i<n1; i++)
            {
                a[i] = arr[start+i];
               
            }
            for ( j = 0; j <n2; j++)
            {
                b[j] = arr[mid+1+j];
                
            }
            i = 0;
            j = 0;
            k = start;
            
            while(i<n1 && j<n2)
            {
                if (a[i] <= b[j])
                {
                    arr[k] = a[i];
                    i++;
                }
                else
                {
                    arr[k] = b[j];
                    j++;
                }
                k++;
            }
            while(i<n1)
            {
                arr[k] = a[i];
                i++;
                k++;
            }
            while(j<n2)
            {
                arr[k]= b[j];
                j++; 
                k++;
            }

        }
        public void Display(int[] arr, int start, int end)
        {
            for(int i=start; i<end; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
