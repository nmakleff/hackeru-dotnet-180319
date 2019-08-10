using System;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        public static async Task<int> SumAsync(int x)
        {
            Console.WriteLine("SumAsync Start with x=" + x);
            int sum = 0;

            for (int i = 0; i < x; i++)
            {
                await Task.Delay(1);
                sum += i;
            }

            Console.WriteLine("SumAsync Stop x=" + x);
            return sum;
        }

        public static async Task<int> CalcAsync()
        {
            Console.WriteLine("CalcAsync Start");
            int calc = 0;

            Task<int> t1 = SumAsync(200);
            Task<int> t2 = SumAsync(100);

            // Do whatever I'd like

            int[] res = await Task.WhenAll(t1, t2);
            calc = res[0] + res[1];

            Console.WriteLine("CalcAsync Stop");
            return calc;
        }

        static void Main(string[] args)
        {
            CalcAsync().Wait();
        }
    }
}
