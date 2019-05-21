using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //realice un programa que calcule las raices de la ecuacion; 
         
            double a;
            double b;
            double c;
            double x = 1;
            double x1;
            double x2;
            double resultado1;
            double resultado;
            double dividiendo;
            double d;
            double j;
            double y;
            double resulta;
            double resulta2;




            Console.Write("digite el el valor de a ");
            a = int.Parse(Console.ReadLine());



            Console.Write("digite el el valor de b ");
            b = int.Parse(Console.ReadLine());



            Console.Write("digite el el valor de c ");
            c = int.Parse(Console.ReadLine());

            resultado = Math.Sqrt(b * b * 4 * a * c);
            
              dividiendo =  ( 2 * a);
            x1 = (-b + resultado)/dividiendo;

            dividiendo = (2 * a);
            x2 = (-b + resultado) / dividiendo;

            resultado1 = (x1 * x2);


            if (a ==0 && b==0)// si a es igual a 0 y b es igual a o entonces :
            {
                Console.WriteLine("LA ECUACION ES DEGENERADA");
            }

            if (a ==0 && b>0)// si a es igual a 0 y b no es igual a o entonces :
            {
                resultado = Math.Sqrt(-c/b); 
                dividiendo = (2 * a);
                x1 = (-b + resultado) / dividiendo;

                dividiendo = (2 * a);
                x2 = (-b + resultado) / dividiendo;

                resultado1 = (x1 * x2);
            }


            //en los demas casos aplicaremos 

            d = (b * b - 4 * a * c);

            if ( d>=0  )
            {

                resultado = Math.Sqrt(b * b * 4 * a * c);

                dividiendo = (2 * a);
                x1 = (-b + resultado) / dividiendo;

                dividiendo = (2 * a);
                x2 = (-b + resultado) / dividiendo;

                resultado1 = (x1 * x2);

                Console.WriteLine("" + resultado1);

            }
            else
            {
                if (d < 0)
                {

                    Console.Write("digite valor de y");
                    y = double.Parse(Console.ReadLine());

                    Console.Write("digite valor de j");
                    j = double.Parse(Console.ReadLine());

                    resulta = (x + y * j);
                    resulta2 = (x - y * j);
                    Console.WriteLine("" +"\n"+resulta+"\n"+ resulta2);
                    

                }



            }


           


















            Console.ReadKey();





        }
    }
}
