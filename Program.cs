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
            
            sum.ReadStream();
            sum.Print();
            


            Console.ReadKey(true);
        }
    }
}
