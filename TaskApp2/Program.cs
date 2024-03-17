namespace TaskApp2
{
    internal class Program
    {

        public static void Work1(string name)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{name}`s {i} is working");
            }
        

        }

        public static void Work2(string name)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{name}`s {i*i} is working");
            }


        }
        public static void Work3(string name)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{name}`s {Math.Pow(i,3)} is working");
            }


        }
        public static void Work4(string name)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{name}`s  is working");
            }


        }

        static void Main(string[] args)
        {

            int minWorker, minIOC;
            // Get the current settings.
            ThreadPool.GetMinThreads(out minWorker, out minIOC);
            Console.WriteLine($"Main thread start {minWorker}- {minIOC}");

            Task task1 = new Task(() => {
                Console.WriteLine("Rustem start work!");
                Work1("Rustem");
                Console.WriteLine("Rustem end work!");

            });
            Task task2 = new Task(() => {
                Console.WriteLine("Nermin start work!");
                Work2("Nermin");
                Console.WriteLine("Nermin end work!");

            });

            Task task3 = new Task(() => {
                Console.WriteLine("Ekber start work!");
                Work3("Ekber");
                Console.WriteLine("Ekber end work!");

            });
            Task task4 = new Task(() => {
                Console.WriteLine("Fizuli start work!");
                Work4("Fizuli");
                Console.WriteLine("Fizuli end work!");

            });
            task4.Start();
            task4.Wait();
            task1.Start();
            task2.Start();
            task2.Wait();
            task3.Start();

            task3.Wait();

            Console.WriteLine("Main thread end");
        }
    }
}
