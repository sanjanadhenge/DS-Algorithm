using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm
{
    internal class HashFunction 
    {
        MyMapNode<int, int> myMapNode = new MyMapNode<int, int>(10);
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
            int j = 0;
            foreach(var  data in arr)
            {
                myMapNode.Add(j, data);
            }
            Console.WriteLine("Enter the number you want to find");
            int number = Convert.ToInt32(Console.ReadLine());
           int hash= myMapNode.Get(number);
            Console.WriteLine("Position  " + hash);
        }
    }
}
