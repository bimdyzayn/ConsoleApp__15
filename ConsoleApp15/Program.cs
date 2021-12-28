using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Арифметиская прогрессия:");
            ArithProgression arith = new ArithProgression();
            arith.setStart(12);
            arith.setStep(4);
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine("Сброс:");
            arith.reset();
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine("Геометрическая прогрессия:");
            GeomProgression geom = new GeomProgression();
            geom.setStart(12);
            geom.setStep(4);
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            
            Console.ReadKey();
        }
    }
}
