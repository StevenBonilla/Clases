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
            
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////******* Almacena una lista de puntos y calcula la distancia euclidea entre pares ***********////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            double Xcoord;
            double Ycoord;

            List<Punto2D> coordenadas = new List<Punto2D>();
            List<double> distancias = new List<double>();
            //List<Punto2D> centros = new List<Punto2D>();


            /////////////////////////////////
            // Creamos una lista de objetos de la clase Punto2D, donde cada objeto contendrá la coordenada x e y 
            ////////////////////////////////

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

                bool continuar = true; //booleano que permitirá repetir la pregunta "Do you want to coninue", si no se introducen los caracteres y,Y,n,N
                do
                {
                    Console.WriteLine("\nDo you want to continue? (y/n)");    // s = continuar; n = finalizar 
                    string again = Console.ReadLine();
                    if (again == "n" || again == "N")    //Si el usuario deseea terminar, Flag "end" cambia a true y salimos del bucle
                    {
                        end = true;
                        continuar = true;
                    }else if (again == "y" || again == "Y")     //Si el usuario deseea continuar, Flag "end" continua en false y permanecemos en el bucle
                    {
                        end = false;
                        continuar = true;
                    }
                    else    // En este caso el valor introducido no es ni n/N ni y/Y, por lo que preguntamos de nuevo si quiere continuar, hasta que se escriba uno de esos cuatro caracteres
                    {
                        continuar = false;
                    }
                      
                  } while (!continuar); //Si el caracter introducido no corresponde con n,N,y,Y, el bucle continúa, preguntando de nuevo si desea continuar, hasta introducir n,N,y,Y
            }



            ////////////////////////////////////////
            //Una vez almacenados todos los objetos en la lista coordenadas, creamos una nueva lista "distancias" para almacenar la distancia euclidea entre las posiciones (0,1) (2,3) (3,4)...
            ////////////////////////////////////////

            for (int i = 0; i < coordenadas.Count -1 ; i=i+2)     //Recorre el bucle de 2 en 2 objetos, para poder llamar a la duncion distEucl. hasta (count-1) porque en la última supera el límite con i+1 del p2
            {
                Punto2D p1 = coordenadas.ElementAt(i);
                Punto2D p2 = coordenadas.ElementAt(i + 1);

                distancias.Add(p1.DistanciaEuclidea(p2));   //Almaceno en una lista (de doubles) las distancias obtenidas (distancia de p1 a p2), llamando al método con el objeto p1 y pasando los valores de p2          
            }

            Console.WriteLine("\n");
            foreach (double m in distancias)    // Recorre la lista (doubles) de distancias para imprimirlas por pantalla
            {
                Console.WriteLine("Distancia: " + m);
            }

            Console.ReadLine();

            //foreach (Punto2D m in coordenadas)  //Recorre la lista (objejtos) de puntos para imprimirlos por pantalla
            //{
            //    Console.WriteLine(m);
            //}

            //Console.ReadLine();

            */



            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////********* comprueba si un punto dado está dentro de una circunferencia con centro y radio dado **************////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////
            // Creamos un nuevo objeto que corresponderá con el centro de la circunferencia
            ////////////////////////////////////////

            double xCenterDouble, yCenterDouble;
            double xPuntoDouble, yPuntoDouble;


            Console.WriteLine("\nInput the coordinates of the center of the circunference: ");  //Pedimos por pantalla las coordenadas del centro
            Console.Write("X: ");
            string xCenter = Console.ReadLine();
            double.TryParse(xCenter, out xCenterDouble);
            Console.Write("Y: ");
            string yCenter = Console.ReadLine();
            double.TryParse(yCenter, out yCenterDouble);

            Punto2D centro = new Punto2D(xCenterDouble, yCenterDouble); //Objeto centro con las coordenadas del centro de la circunferencia



            ////////////////////////////////////////
            // Creamos un nuevo objeto que corresponderá con el Punto
            ////////////////////////////////////////

            Console.WriteLine("\nInput the coordinates of the Point: ");  //Pedimos por pantalla las coordenadas del Punto
            Console.Write("X: ");
            string xPunto = Console.ReadLine();
            double.TryParse(xPunto, out xPuntoDouble);
            Console.Write("Y: ");
            string yPunto = Console.ReadLine();
            double.TryParse(yPunto, out yPuntoDouble);

            Punto2D punto = new Punto2D(xPuntoDouble, yPuntoDouble); //Objeto Punto con las coordenadas del punto

            Console.WriteLine("\nCentro de la circunferencia: " + centro.getX() + " , " + centro.getY()); //Imprimimos por pantalla los valores del objeto centro de tipo Punto2D
            Console.WriteLine("\nPunto: " + punto.getX() + " , " + punto.getY());



            ////////////////////////////////////////
            // Calculamos si la distancia del centro al punto es menor que el radio de la circunferencia, entonces dicho punto estará dentro de la circunferencia
            ////////////////////////////////////////

            //double distanciaCentroPunto = punto.DistanciaEuclidea(centro);    //Calculamos la distancia del centro al punto llamando al método distanciaEuclidea

            double radiusDouble;
            Console.WriteLine("\nInput the radius of the circunference: ");     //Pedimos el radio que va a tener la circunferencia
            string radius = Console.ReadLine();
            double.TryParse(radius, out radiusDouble);

            Ejercicio3.Circunferencia miCircunferencia = new Ejercicio3.Circunferencia(centro, radiusDouble);   //Creamos nuestro objeto de tipo Circunferencia pasandole el objeto de tipo Punto2D y el radio de la circunferencia

            bool pertenece = miCircunferencia.estaDentro(punto);   //Llamamos al método estaDentro para comprobar si la distancia centro-punto es menor o mayor que el radio, para saber si está o No (respectivamente) dentro de la circunferencia
            if (pertenece)  
            {
                Console.WriteLine("El punto está dentro de la circunferencia");
            }else
            {
                Console.WriteLine("\nEl punto No está dentro de la circunferencia");
            }



            ////////////////////////////////////////
            // Imprime por pantalla el Area y longitud de la circunferencia
            ////////////////////////////////////////

            double Area = miCircunferencia.area(radiusDouble);  
            double Longitud = miCircunferencia.longitud(radiusDouble);

            Console.WriteLine("\nEl radio de la circunferencia es: " + radiusDouble);
            Console.WriteLine("Area: " + Area);
            Console.WriteLine("Longitud: " + Longitud);

            



            Console.ReadLine();
        }

    }
}
