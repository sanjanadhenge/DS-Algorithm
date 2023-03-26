using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm
{
    internal class BankCashOperation
    {
        QueueGeneric<String> queue = new QueueGeneric<String>();
        int amount = 10000;
        public BankCashOperation()
        {
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
        }
        public void Operation()
        {
            int count = queue.Size();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter an Option\n1.WithDraw\n2.Deposit\n3.CheckAmount");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;

                }
            }
        }
        public void CheckAmmount()
        {
            Console.WriteLine(amount);
        }
        public void WithDraw()
        {
            Console.WriteLine("Enter the Amount you want to withdraw");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            if (amount > withdrawAmount)
            {
                amount -= withdrawAmount;
            }
            else
            {
                Console.WriteLine("Ifficient Balance ,Please Try again");
            }
        }
        public void Deposit()
        {
            Console.WriteLine("Enter the Amount you want to Deposit");
            int depositAmount = Convert.ToInt32(Console.ReadLine());
            depositAmount += amount;
        }

    }
}
