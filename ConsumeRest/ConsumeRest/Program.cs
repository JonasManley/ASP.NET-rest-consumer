using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeRest
{
    class Program
    {
        private static string _getBookings;
        static async Task Main(string[] args)
        {
            Apihelper.InitializeClient();

            Processor processor = new Processor();
            await processor.getBookings();

            Console.WriteLine(processor.Test);

            foreach (var item in processor.CarList)
            {
                Console.WriteLine(item);
            }
          

            Console.ReadLine();
        }
    }
}
