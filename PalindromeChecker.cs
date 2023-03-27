using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm
{
    internal class PalindromeChecker
    {
        QueueGeneric<char> queue = new QueueGeneric<char>();
        public void check(string palindrome)
        {
            char[] words1 = palindrome.ToCharArray();
            char[] word2 = new char[words1.Length];
            int k = 0;
            foreach(char item in words1)
            {
                queue.Enqueue(item);
            }
            for(int i =words1.Length-1;i>=0;i--)
            {
                word2[k] = words1[i];
                k++;
            }
            string reverse = new string(word2);
            if(reverse.Equals(palindrome))
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }

        }
    }
}
