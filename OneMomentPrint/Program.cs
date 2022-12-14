namespace dz13_2
{
    class Threads
    {

        static Semaphore sem = new Semaphore(3, 3);
        public void Create()
        {
            Thread myThread1 = new Thread(ThreadStart);
            Thread myThread2 = new Thread(ThreadStart);
            Thread myThread3 = new Thread(ThreadStart);
            myThread1.Name = "First Thread";
            myThread2.Name = "Second Thread";
            myThread3.Name = "Third Thread";
            Thread.Sleep(0);
            myThread1.Start();
            myThread2.Start();
            myThread3.Start();
        }


        public void ThreadStart() 
        {
            sem.WaitOne();
            Console.WriteLine(Thread.CurrentThread.Name + "  --  " + DateTime.Now);
            sem.Release();
        }
    }

    class program
    {
       static  void Main()
        {
            Threads threads = new Threads();
            threads.Create();
        }
    }
}