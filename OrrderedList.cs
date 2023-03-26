using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm
{
     internal class OrderedList
    {
        public void ReadFile(string filepath)
        {
            LinkedListGeneric<int> linkedListGeneric = new LinkedListGeneric<int>();

            string readData = File.ReadAllText(filepath);
            string[] words = readData.Split(" ");
            foreach (var word in words)
            {
                int item = Convert.ToInt32(word);
                linkedListGeneric.Add(item);
            }
            int input = Convert.ToInt32(Console.ReadLine());
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
