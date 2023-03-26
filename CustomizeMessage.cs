using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm
{
    internal class CustomizeMessage
    {
        public void Customize()
        {
            string line = "Hello<<name>>,We have your full name as<<Full name>> in our system.your contact number is 91-xxxxxxxxxx";
            line = line.Replace("<<name>>", "Sanjana");
            line = line.Replace("<<Full name>>", "Sanjana Sanjany Dhenge");
            line = line.Replace("91-xxxxxxxxxx", "91-9359913789");
            Console.WriteLine(line);
        }
    }
}
