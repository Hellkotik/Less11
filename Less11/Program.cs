using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа k и b");
            double k=Convert.ToDouble(Console.ReadLine());
            double b=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ваше уравнение иммет вид: {0}x+{1}=0", k, b);
            Urav urav = new Urav(k, b);
            Console.WriteLine(urav.Root());
            Console.ReadKey();
        }
    }
}
