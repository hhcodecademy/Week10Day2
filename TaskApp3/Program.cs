using System.Diagnostics.CodeAnalysis;

namespace TaskApp3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("Enter first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());

            //Task task1 = new Task(() =>
            //{
            //    sum(x, y);
            //});

            //Task task2 = new Task(() =>
            //{
            //    multiply(x, y);
            //});
            //task1.Start();

            //task2.Start();
            //task1.Wait();

            int sumResult = sum(5, 8);
            var resultTask =  sum2(5, 8);
            int sum2Result = await resultTask;

            sum3(sumResult, sum2Result);
            multiply(5, 8);


        }

        public static int sum(int x, int y)
        {
            int result = x + y;
            Thread.Sleep(3000);
            // Console.WriteLine($"Sum result: {result}");
            return result;

        }

        public async static Task<int> sum2(int x, int y)
        {
            int result = (x * x) + (y * y);
            await Task.Delay(2000);
            //  Console.WriteLine($"Sum result: {result}");
            return result;

        }
        public async static void sum3(int x, int y)
        {
            int result = (x * 2) + (y * 2);
            Console.WriteLine($"Sum result: {result}");
            await Task.Delay(7000);
        }
        public static void multiply(int x, int y)
        {
            int result = x * y;
            Console.WriteLine($"Muliply result: {result}");
        }
    }
}
