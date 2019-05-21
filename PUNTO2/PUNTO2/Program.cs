using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO2
{
    class Program
    {
        static void Main(string[] args)
        {
            double b;
            double x;
            double y;


            Console.Write("sumatoria notacion ");

            Console.Write("digite numero de b");
            b = double.Parse(Console.ReadLine());

            Console.Write("digite numero de b");
            x = double.Parse(Console.ReadLine());

            Console.Write("digite numero de b");
            y = double.Parse(Console.ReadLine());



            for (int a = 0; a < b; a++)
            {

                double resul = 1 / x + a * y;
                Console.WriteLine($"RESULTADO : {resul}");





            }



            Console.ReadKey();

        }
    }
}
