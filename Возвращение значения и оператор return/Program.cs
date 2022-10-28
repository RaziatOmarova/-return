using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Возвращение_значения_и_оператор_return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name()
            {
                return "Raziyat";
            }
            Console.WriteLine(name());

            int Sum(int x, int y)
            {
                return x + y;
            }
            int result = Sum(478, 924);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
