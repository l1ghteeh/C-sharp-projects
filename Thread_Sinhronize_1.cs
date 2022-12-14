namespace dz13_1
{
    class Threads
    {

        static Semaphore sem = new Semaphore(1, 1);
        public void Create1()
        {
            Thread myThread11 = new Thread(ThreadStart1);
            Thread myThread12 = new Thread(ThreadStart1);
            Thread myThread13 = new Thread(ThreadStart1);
            myThread11.Name = "Это первый поток";
            myThread12.Name = "Это второй поток";
            myThread13.Name = "Это третий поток";
            Thread.Sleep(0);
            myThread11.Start();
            Thread.Sleep(1000);
            myThread12.Start();
            Thread.Sleep(1000);
            myThread13.Start();
            

        }


        public void ThreadStart1()
        {
            sem.WaitOne();
            Console.WriteLine(Thread.CurrentThread.Name);
            sem.Release();
        }



        public void Create2()
        {
            Thread myThread21 = new Thread(ThreadStart2);
            myThread21.IsBackground = true;
            Thread myThread22 = new Thread(ThreadStart2);
            myThread22.IsBackground = true;
            Thread myThread23 = new Thread(ThreadStart2);
            myThread32.IsBackground = true;
            Thread.Sleep(1000);
            myThread21.Name = "Это первый поток";
            myThread22.Name = "Это второй поток";
            myThread23.Name = "Это третий поток";
            Thread.Sleep(0);
            myThread21.Start();
            Thread.Sleep(1000);
            myThread22.Start();
            Thread.Sleep(1000);
            myThread32.Start();

        }

       
        public void ThreadStart2()
        {
            sem.WaitOne();
            Console.WriteLine(Thread.CurrentThread.Name);
            sem.Release();
        }

        public void Create3()
        {
            Thread myThread31 = new Thread(ThreadStart3);
            Thread myThread32 = new Thread(ThreadStart3);
            Thread myThread33 = new Thread(ThreadStart3);
            Thread.Sleep(1000);
            myThread31.Name = "Это первый поток";
            myThread32.Name = "Это второй поток";
            myThread33.Name = "Это третий поток";
            Thread.Sleep(0);
            myThread31.Start();
            Thread.Sleep(1000);
            myThread32.Start();
            Thread.Sleep(1000);
            myThread33.Start();
        }

        
        public void ThreadStart3()
        {
            bool changer = true;
            while(changer == true)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "  --  " + "Состояние потока -" + Thread.CurrentThread.IsAlive);
            }
        }

    }

    class program
    {
        static void Main()
        {
            Threads threads = new Threads();
            threads.Create1();
            Thread.Sleep(1000);
            Console.WriteLine("\nА тепеь как background потоки\n ");
            threads.Create2();
            Thread.Sleep(1000);
            Console.WriteLine("\nДалее не заканчивающиеся потоки\n ");
            threads.Create3();
            Thread.CurrentThread.Interrupt();
        }
    }
}