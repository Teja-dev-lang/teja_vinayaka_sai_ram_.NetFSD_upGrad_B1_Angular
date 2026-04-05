using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MultiThreading
{
    internal class ParallelNumbers
    {
        static int counter = 0;
        static int all_sum = 0;
        static readonly object locker = new object();
        static void Counter()
        {
            
            lock(locker)
            {   
                int threadCount = 0;
                for (int i = 0; i <= 10; i++)
                {
                    counter += 1;
                    threadCount += counter;
                    //Console.WriteLine(counter);
                }
                all_sum += threadCount;
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Count is : {threadCount}");

            }
        }
        static void Main()
        {
            Thread t = new Thread(Counter);
            t.Start();
            Thread t1 = new Thread(Counter);
            t1.Start();
            Thread t2 = new Thread(Counter);
            t2.Start();

            t.Join();
            t1.Join();
            t2.Join();
            Console.WriteLine($"All Thread  Sum is : {all_sum}");

        }
    }
}
