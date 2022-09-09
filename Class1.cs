using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Multithreading
{
    class IsALive
    {
     
        static void Main(string[] args)
        {
            ThreadAliveAndStates();


            thread t1 = new thread(new threadstart(m2));
            t1.name = "t1 thread";

            thread t2 = new thread(m2);
            t2.name = "t2 thread";
            thread t3 = new thread(m2);
            t3.name = "t3 thread";
            t2.priority = threadpriority.highest;
            t1.priority = threadpriority.normal;
            t3.priority = threadpriority.lowest;
            t2.start();
            t1.start();
            t1.join();

            t3.start();

            Console.ReadLine();

        }
        private static void ThreadAliveAndStates()
        {
            Thread t1 = new Thread(M1);
            Thread t2 = new Thread(M1);
            Console.WriteLine("----Before Start---- ");
            Console.WriteLine("Is T1 alive= " + t1.IsAlive);
            Console.WriteLine("Is T2 alive= " + t2.IsAlive);
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);

            t1.Start();
            t2.Start();
            Console.WriteLine("----After Start----");
            Console.WriteLine("Is T1 alive= " + t1.IsAlive);
            Console.WriteLine("Is T2 alive= " + t2.IsAlive);
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);

            t1.Abort();
            t2.Abort();
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);
        }
    }
    }
