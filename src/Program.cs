using Fibonacci;
using static System.Console;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fibonnaciGenerator = new FibonacciGenerator();

            var fibonaccis = fibonnaciGenerator.Generate(10);

            foreach(var fibo in fibonaccis){
            	WriteLine(fibo);
            }
        }

    }
}