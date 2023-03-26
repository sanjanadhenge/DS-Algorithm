using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm
{
    internal class BalancedParentheses
    {
        public void ReadFile(string filePath)
        {
            LinkedListStack<string> listStack = new LinkedListStack<string>();
            string readData = File.ReadAllText(filePath);
            string[] words = readData.Split(" ");
            foreach (string word in words)
            {
              if(word.Equals("("))
                {
                    listStack.Push(word);
                }
              if(word.Equals(")"))
                {
                    listStack.Pop();
                }
            }
            listStack.Peek();
        }
    }
}
