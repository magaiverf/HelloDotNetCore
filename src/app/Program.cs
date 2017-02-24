using static System.Console;
using ClassLibrary;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("Hello World!");
            WriteLine($"The answer is {new Thing().Get(19, 23)}");
        }
    }
}
