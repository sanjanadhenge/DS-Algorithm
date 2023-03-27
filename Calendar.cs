﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm
{
    internal class Calendar
    {
        static int year = new int();
        static int month = new int();
        static int[,] calendar = new int[6, 7];

        public void Run()
        {
            Console.Write("Enter the year:");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the month (January = 1, etc): ");
            month = Convert.ToInt32(Console.ReadLine());

            DrawHeader();
            FillCalendar();
            DrawCalendar();
            Console.ReadLine();
        }
        public void DrawHeader()
        {
            Console.Write("\n\n");
            Console.WriteLine(" % java Calendar"+" " + month + " "+ year);
            Console.WriteLine("S M T W Th F S");
        }

        public void FillCalendar()
        {
            int days = DateTime.DaysInMonth(year, month);
            int currentDay = 1;
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1) && currentDay <= days; j++)
                {
                    if (i == 0 && month > j)
                    {
                        calendar[i, j] = 0;
                    }
                    else
                    {
                        calendar[i, j] = currentDay;
                        currentDay++;
                    }
                }
            }
        }

        public void DrawCalendar()
        {
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1); j++)
                {
                    if (calendar[i, j] > 0)
                    {
                        if (calendar[i, j] < 10)
                        {
                            Console.Write(" " + calendar[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(calendar[i, j] + " ");
                        }
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}

