using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca su nota: ");
            int nota;
            nota = int.Parse(Console.ReadLine());
            switch (nota)
            {
                case 10:
                case 9:
                    Console.WriteLine("Sobresaliente");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("Notable");
                    break;
                case 6:
                case 5:
                    Console.WriteLine("Suficiente");
                    break;
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("Insuficiente");
                    break;
                default:
                    Console.WriteLine("Te has equivicado");
                    break;
            }
        }
    }
}
