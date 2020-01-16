using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFromTXT
{
    class SumTravel
    {
        private string Path { get; set; }
        public SumTravel(string path)
        {
            Path = path;
        }
        //читаем файл и вычисляем сумму
        public double ReadStream()
        {
            List<string> output = new List<string>();
            double sum = 0;
            string sumStr, modifySumStr;
            try
            {
                using (FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (StreamReader reader = new StreamReader(fs, Encoding.Unicode))
                    {
                        while (reader.Peek() != -1)
                        {
                            sumStr = reader.ReadLine();
                            modifySumStr = sumStr.Substring(sumStr.IndexOf(':') + 1);
                            output.Add(sumStr);
                            Console.WriteLine(sumStr);
                            if (double.TryParse(modifySumStr, out double result))
                            {
                                output.Add(modifySumStr);
                                Console.WriteLine(modifySumStr);
                                sum += result;
                                output.Add("(" + sum + ")");
                                Console.WriteLine("(" + sum + ")");
                            }
                        }
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            WriteStream(output);
            return sum;
        }
        //пишем результат в файл
        private void WriteStream(List<string> output)
        {
            using (FileStream fs = new FileStream("answer.txt", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {

                }
            }
        }
    }
}
