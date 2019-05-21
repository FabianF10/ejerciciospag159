using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double num3;
      

            Console.Write("digite su dia de nacimiento ");
            num1 = double.Parse(Console.ReadLine());
            
            
            Console.Write("digite el  mes en que  nacio ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("digite el año en que nacio ");
            num3 = double.Parse(Console.ReadLine());

            double sum = num1 + num2 + num3;

             double res1 = sum / 10;
             double res2 = sum % 10;

             double a1 = res1 / 10;
             double res4 = sum % 10;


            double res5 = a1 / 10;
            double res6 = sum % 10;

            double suma = res1 + res2 + a1 + res4 + res5 + res6;

            double resultado1 = suma / 10;
            double resultado2 = suma % 10;


            double resultado3 = resultado1 + resultado2;

            double resultado4 = resultado3 / 10;
            double resultado5 = resultado3 % 10;

            double resultado6 = resultado4 + resultado5;


            double resultado7 = resultado6 - 1;

            Console.WriteLine("su numero del tarot es ;" + resultado7);

            Console.ReadKey();
        }
    }
}
