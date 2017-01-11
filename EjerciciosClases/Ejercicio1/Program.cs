using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClases
{
    class Program
    {

        static double pi = 3.1416;

        public double area(double radius )
        {
            double resultado;
            resultado = (radius * radius) * pi;
            return resultado;
        }

        public double longitud(double radius)
        {
            double resultado;
            resultado = 2 * pi * radius;
            return resultado;
        }


        static void Main(string[] args)
        {

            string radius;
            double radiusDouble;
            

            Console.WriteLine("Input the radius length: ");
            radius = Console.ReadLine();
            double.TryParse(radius, out radiusDouble);

            Program figura = new Program();
            double Area = figura.area(radiusDouble);
            double Longitud = figura.longitud(radiusDouble);

            Console.WriteLine("\nAREA: " + Area);
            Console.WriteLine("\nLONGITUD: " + Longitud);

            Console.ReadLine();

        }
    }
}
