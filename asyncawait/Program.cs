using System;
using System.Linq;
using System.Threading.Tasks;

namespace asyncawait
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            Console.WriteLine("Print Start");
            program.Print();
            Console.WriteLine("Print Ended");
            while(true){
                // Wait until abort
            }
        }

        async void Print() {
            var message1 = await getHello();
            Console.WriteLine("Hello Returned");
            var message2 = await getWorld();
            Console.WriteLine("World Returned");
            var message = new [] {message1, message2};
            Console.WriteLine(message
                .Select(arg => arg.ToLower())
                .Aggregate((i, j) => i + " " + j));
        }

        private async Task<string> getHello()
        {
            await Task.Delay(1000);
            return "Hello";
        }

        private async Task<string> getWorld()
        {
            await Task.Delay(2000);
            return "World!";
        }
    }
}
