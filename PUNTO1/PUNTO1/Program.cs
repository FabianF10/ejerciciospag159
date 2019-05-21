using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;



            Console.Write("digite el numero 1");
            a =double.Parse(Console.ReadLine());

            Console.Write("digite el numero 2");
            b = double.Parse(Console.ReadLine());



            if (a>=0 == b>=0) //si a y b son mayores que 0 es decir si son numeros positivos se realizara la suma 
            {
                Console.WriteLine(a + b);
            }
            else 
            {
                Console.WriteLine("el numero es negativo no se puede realizar la operacion ");//si los numeros son negativos no se podra realizar la operacion

            }


            if (a<b)
            {
                Console.WriteLine("a es menor que  b se aplicara b+a");//si a es menor que b se intercambiaran los valores....
                Console.WriteLine(b + a);
            }
            
            









            Console.ReadKey();



        }
    }
}
