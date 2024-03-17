using System.Threading.Tasks;

namespace TaskApp
{
    internal class Program
    {
        static void DoWork(string message)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(message);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Log 1");
            Task.Factory.StartNew(() =>
            {
                DoWork("T1");
                Console.WriteLine("DoWork Completed for T1");
            });
            // Instance ı kendimiz oluşturduğumuzda, action parametresindeki methodu çalıştırmaz. 
            // Oluşturduğumuz instancetaki Start methodunu tetiklediğimizde DoWork çalışacaktır.
            var task = new Task(() =>
            {
                DoWork("T2");
                Console.WriteLine("DoWork Completed for T2");
            });
            task.Start();

            Task task3 = new Task(() => {
                DoWork("T3");
                Console.WriteLine("DoWork Completed for T3");

            });
            task3.Start();
            Console.WriteLine("Main Thread Log 2");
            Console.ReadKey();
        }
    }
}
