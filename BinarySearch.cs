using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm
{
    internal class BinarySearch
    {
        public void ReadFile(String  filepath)
        {
            string readData = File.ReadAllText(filepath);
            string[] words = readData.Split(" ");
            Console.WriteLine("Enter the Word you want to found");
            String search = Console.ReadLine();
            int flag = 0;
            foreach(var word in words)
            {
                if(word.Equals(search))
                {
                    Console.WriteLine("Found");
                    break;
                }
                else
                {
                    flag = 1;
                }
          
            }
            if(flag == 1)
            {
                Console.WriteLine("The word you entered is not in the file");
            }
        }
        
    }



   
}
