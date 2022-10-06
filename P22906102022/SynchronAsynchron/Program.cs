using System;
using System.Threading;

namespace SynchronAsynchron
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("az-AZ");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            //string str = Console.ReadLine();

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.UtcNow.AddHours(4));
            Console.WriteLine(DateTime.UtcNow.AddHours(4).ToString("dddd - MMMM ... yy"));




            //Thread thread1 = new Thread(Loop1);
            //Thread thread2 = new Thread(Loop2);

            //thread1.Start();
            //thread2.Start();

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine($"Main - {i} Thread Id {Thread.CurrentThread.ManagedThreadId}");
            //}

            //thread1.Join();

            //Loop2();
            //Loop1();
        }

        //static void Loop1()
        //{
        //    //Thread.Sleep(0);
        //    Thread.Yield();

        //    for (int i = 0; i < 100; i++)
        //    {
        //        Console.WriteLine($"Loop 1 - {i} Thread Id {Thread.CurrentThread.ManagedThreadId}");
        //    }
        //}

        //static void Loop2()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Console.WriteLine($"Loop 2 - {i} Thread Id {Thread.CurrentThread.ManagedThreadId}");
        //    }
        //}
    }
}
