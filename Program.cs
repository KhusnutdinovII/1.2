using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            string inside = "Точка внутри контура!";
            string outside = "Точка вне контура!";
            Console.WriteLine("Введите абсциссу точки: ");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите ординату точки: ");
            y = float.Parse(Console.ReadLine());
            if (Math.Abs(x) <= 1 && Math.Abs(y) <= 1)
            {
                if (Math.Abs(x) >= 0.5 && Math.Abs(y) >= 0.5)
                    Console.WriteLine(inside);
                else
                    Console.WriteLine(outside);
            }
            else
                Console.WriteLine(outside); 
            Console.ReadKey();
        }
    }
}
