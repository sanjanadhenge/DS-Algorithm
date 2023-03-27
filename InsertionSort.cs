using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm
{
    internal class InsertionSort
    {
        public void ReadFile(String filepath)
        {
            string readData = File.ReadAllText(filepath);
            string[] words = readData.Split(" ");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i+1; j < words.Length; j++)
                {
                    if (words[i].CompareTo(words[j]) > 0)
                    {
                        string temp = words[i];
                        words[i] = words[j];
                        words[j] = temp;
                    }
                }
            }
            Console.WriteLine("After Sorting ------------->");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }

    }
}
