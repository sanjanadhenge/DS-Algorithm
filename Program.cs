using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm
{
    internal class program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select option \n 1.Binary Search \n 2.Insertion Sort \n 3.Bubble Sort \n 4.Merge Sort \n 5.Anagram \n 6.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        BinarySearch binarySearch = new BinarySearch();
                        binarySearch.ReadFile(@"C:\Users\SOURABH\Desktop\Day 3\DS-Algorithm\TextFile1.txt");
                        break;
                    case 2:
                        InsertionSort insertionSort = new InsertionSort();
                        insertionSort.ReadFile(@"C:\Users\SOURABH\Desktop\Day 3\DS-Algorithm\TextFile1.txt");
                        break;
                    case 3:
                        BubbleSort bubbleSort = new BubbleSort();
                        bubbleSort.ReadFile(@"C:\Users\SOURABH\Desktop\Day 3\DS-Algorithm\TextFile2.txt");
                        break;
                    case 4:
                        MergeSort mergeSort = new MergeSort();
                        mergeSort.ReadFile(@"C:\Users\SOURABH\Desktop\Day 3\DS-Algorithm\TextFile2.txt");
                        break;
                    case 5:
                        Anagram anagram = new Anagram();
                        anagram.CheckAnagram();
                        break;
                    case 6:
                        flag = false;
                        break;
                    
                }
            }
           
            
        }
    }

}
