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
                Console.WriteLine("Select option \n 1.Binary Search \n 2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        BinarySearch binarySearch = new BinarySearch();
                        binarySearch.ReadFile(@"C:\Users\SOURABH\Desktop\Day 3\DS-Algorithm\TextFile1.txt");
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
           
            
        }
    }

}
