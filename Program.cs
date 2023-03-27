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
                Console.WriteLine("Select option \n 1.Binary Search \n 2.Insertion Sort \n 3.Bubble Sort \n 4.Merge Sort \n 5.Anagram \n 6.Prime numbers \n 7.Prime Number check \n 8.Algorithms using sorting \n 9.CustomizeMessage \n 10.linkedList Operation \n 11. Ordered List \n 12.BalancedParentheses \n 13.Bank Cash Operation \n 14.Palindrome Checker \n 15.Hash Function \n 16.Prime number with 2D Array \n 17.Anagram 2D Array \n 18.PrimeAnagramStack \n 19.PrimeAnagramQueue \n 20.Exit");
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
                        BalancedParentheses balancedParentheses = new BalancedParentheses();
                        balancedParentheses.ReadFile(@"C:\Users\SOURABH\Desktop\Day 3\DS-Algorithm\TextFile3.txt");
                        break;
                    case 13:
                        BankCashOperation bankCashOperation = new BankCashOperation();
                        bankCashOperation.Operation();
                        break;
                    case 14:
                        PalindromeChecker palindromeChecker = new PalindromeChecker();
                        Console.WriteLine("Enter the name");
                        string name = Console.ReadLine();
                        palindromeChecker.check(name);
                        break;
                    case 15:
                        HashFunction hashFunction = new HashFunction();
                        hashFunction.ReadFile(@"C:\Users\SOURABH\Desktop\Day 3\DS-Algorithm\TextFile2.txt");
                        break;
                    case 16:
                        PrimeNumber2DArray primeNumber2DArray = new PrimeNumber2DArray();
                        primeNumber2DArray.ScanPrime();
                        break;
                    case 17:
                        Anagram2DArray anagram2DArray = new Anagram2DArray();
                        anagram2DArray.GetPrime();
                        break;
                    case 18:
                        PrimeNoStack primeNoStack = new PrimeNoStack();
                        primeNoStack.GetPrime();
                        break;
                    case 19:
                        QueueAnagram queueAnagram = new QueueAnagram();
                        queueAnagram.GetPrime();
                        break;
                    case 20:
                        flag = false;
                        break;
                    
                }
            }
           
            
        }
    }

}
