using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Multithreading
{
    class IsALive
    {
        static void M1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Sleep State =" + Thread.CurrentThread.ThreadState);
        }

        static void M2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Print  i{0} ", i);
                Console.WriteLine("Thread name " + Thread.CurrentThread.Name);

                Thread.Sleep(200);
            }

        }
        

        }
    }
