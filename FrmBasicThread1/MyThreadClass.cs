﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrmBasicThread1
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i <= 5; i++)
            {
                Thread Thread1 = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + Thread1.Name + " = " + i);
                Thread.Sleep(1500);
            }
        }
    }
}
