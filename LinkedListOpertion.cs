using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm
{
    internal class LinkedListOperation
    {

        public void ReadFile(string filepath)
        {
            LinkedListGeneric<string> linkedListGeneric = new LinkedListGeneric<string>();

            string readData = File.ReadAllText(filepath);
            string[] words = readData.Split(" ");
            foreach (var word in words)
            {
                linkedListGeneric.Add(word);
            }
            string input = Console.ReadLine();
            int result = linkedListGeneric.Search(input);
            if (result == -1)
            {
                Console.WriteLine("Found");
                linkedListGeneric.DeleteNodeAtParticularPosition(result);
            }
            else
            {
                linkedListGeneric.Add(input);
            }
            linkedListGeneric.Display();
        }

    }
}
