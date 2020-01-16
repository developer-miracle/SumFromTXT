using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFromTXT
{
    class Program
    {
        static void Main(string[] args)
        {
            SumTravel sum = new SumTravel("text.txt");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nСУММА: " + sum.ReadStream() + "грн");
            Console.ResetColor();


            Console.ReadKey(true);
        }
    }
}
