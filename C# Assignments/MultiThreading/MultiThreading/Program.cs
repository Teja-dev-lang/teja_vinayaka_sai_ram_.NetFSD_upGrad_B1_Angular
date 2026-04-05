namespace MultiThreading
{
    internal class Program
    {
        static void Work()
        {
            Console.WriteLine("ThreadStarted");
            //Thread.Sleep(20000);
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(Work);
            t.Start();
            Console.WriteLine(t.IsAlive);
            Thread t1 = new Thread(Work);
            t1.Start();
        }
    }
}
