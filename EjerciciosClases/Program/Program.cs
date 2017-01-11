using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClases.Program
{
    class Program
    {
        static void Main(string[] args)
        {

            double Xcoord;
            double Ycoord;

            List<Punto2D> coordenadas = new List<Punto2D>();
            List<double> distancias = new List<double>();

            //coordenadas.Add(new Punto2D(1,2));
            //coordenadas.Add(new Punto2D(3, 4));
            //coordenadas.Add(new Punto2D(5, 0));
            //coordenadas.Add(new Punto2D(1, 1));


            // Creamos una lista de objetos de la clase Punto2D, donde cada objeto contendrá la coordenada x e y 

            Console.WriteLine("Input the coordinates. (type y to introduce another point, or n to finish)");
            bool end = false;   // Flag que permitirá salir del bucle cuando el usuario quiera
            while (!end)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write("\nX: ");   // Almacenamiento de la coordenada X del punto 
                    string x = Console.ReadLine();
                    double.TryParse(x, out Xcoord);

                    Console.Write("Y: ");   // Almacenamiento de la coordenada Y del punto
                    string y = Console.ReadLine();
                    double.TryParse(y, out Ycoord);

                    coordenadas.Add(new Punto2D(Xcoord, Ycoord));   // Definición del punto a partir de X e Y
                }

                //do
                //{
                    Console.WriteLine("\nDo you want to continue? (y/n)");    // s = continuar; n = finalizar 
                    string again = Console.ReadLine();
                    if (again == "n" || again == "N")    //Si el usuario deseea terminar, Flag "end" cambia a true y salimos del bucle
                    {
                        end = true;
                    }           //if else (again == "y" || again == "Y"){

                //    }
                //} while ();
            }



            for (int i = 0; i < coordenadas.Count -1 ; i=i+2)     //Recorre el bucle de 2 en 2 objetos, para poder llamar a la duncion distEucl. hasta (count-1) porque en la última supera el límite con i+1 del p2
            {
                Punto2D p1 = coordenadas.ElementAt(i);
                Punto2D p2 = coordenadas.ElementAt(i + 1);

                distancias.Add(p1.DistanciaEuclidea(p2));   //Almaceno en una lista (de doubles) las distancias obtenidas (distancia de p1 a p2)          
            }

            foreach (double m in distancias)
            {
                Console.WriteLine("Distancia: " + m);
            }



            //foreach (Punto2D m in coordenadas)
            //{
            //    Console.WriteLine(m);
            //}


            //Punto2D punto1 = new Punto2D(0, 0);
            //Punto2D punto2 = new Punto2D(1, 1);

            //punto1.DistanciaEuclidea(punto1.getX(), punto1.getY, punto2.getX, punto2.getY);


            Console.ReadLine();
        }

    }
}
