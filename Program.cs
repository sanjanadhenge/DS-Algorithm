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
                Console.WriteLine("Select option \n 1.Binary Search \n 2.Insertion Sort \n 3.Bubble Sort \n 4.Merge Sort \n 5.Anagram \n 6.Prime numbers \n 7.Prime Number check \n 8.Exit");
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
                        PrimeNumbers primeNumbers = new PrimeNumbers();
                        primeNumbers.PrintPrime();
                        break;
                    case 7:
                        PrimeNumberCheck primeNumberCheck = new PrimeNumberCheck(); 
                        primeNumberCheck.GetPrime();
                        break;
                    case 8:
                        bool flag1 = true;
                        while (flag1)
                        {
                            Console.WriteLine("Select option \n 1.Binary Search \n 2.Insertion Sort \n 3.Bubble Sort \n 4.Merge Sort \n 5.Exit");
                            int option1 = Convert.ToInt32(Console.ReadLine());
                            switch (option1)
                            {
                                case 1:
                                    BinarySearchGeneric<string> binarySearchGeneric1 = new BinarySearchGeneric<string>();
                                    binarySearchGeneric1.ReadFile(@"C:\Users\SOURABH\Desktop\Day 3\DS-Algorithm\TextFile1.txt");
                                    break;
                                case 2:
                                    InsertionSortGeneric<string> insertionSortGeneric = new InsertionSortGeneric<string>();
                                    insertionSortGeneric.ReadFile(@"C:\Users\SOURABH\Desktop\Day 3\DS-Algorithm\TextFile1.txt");
                                    break;
                                case 3:
                                    BubbleSortGeneric<int> bubbleSortGeneric = new BubbleSortGeneric<int>();
                                    bubbleSortGeneric.ReadFile(@"C:\Users\SOURABH\Desktop\Day 3\DS-Algorithm\TextFile2.txt");
                                    break;
                                case 4:
                                    MergesortGeneric<int> mergesortGeneric = new MergesortGeneric<int>();
                                    mergesortGeneric.ReadFile(@"C:\Users\SOURABH\Desktop\Day 3\DS-Algorithm\TextFile2.txt");
                                    break;
                                case 5:
                                    flag1 = false;
                                    break;
                            }
                        }
                        break;
                    case 9:
                        CustomizeMessage customizeMessage = new CustomizeMessage();
                        customizeMessage.Customize();
                        break;
                    case 10:
                        LinkedListOperation linkedListOperation = new LinkedListOperation();    
                        linkedListOperation.ReadFile(@"C:\Users\SOURABH\Desktop\Day 3\DS-Algorithm\TextFile1.txt");
                        break;
                    case 11:
                        OrderedList orderedList = new OrderedList();
                        orderedList.ReadFile(@"C:\Users\SOURABH\Desktop\Day 3\DS-Algorithm\TextFile1.txt");
                        break;
                    case 12:
                        flag = false;
                        break;
                    
                }
            }
           
            
        }
    }

}
