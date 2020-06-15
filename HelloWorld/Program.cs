using System;
using System.Threading.Tasks;

namespace core_svc
{
    class Program
    {
        static async Task Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Hello World!");
                await Task.Delay(500);
            }
            
        }
    }
}
