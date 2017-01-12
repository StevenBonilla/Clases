using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClases
{
    class Punto2D
    {
        private double x;
        private double y;

        public Punto2D(double _x, double _y)    //Constructor
        {
            this.x = _x;
            this.y = _y;
        }

        public double getX()
        {
            return x;
        }

        public void setX(double _x)
        {
            this.x = _x;
        }

        public double getY()
        {
            return y;
        }

        public void setY(double _y)
        {
            this.y = _y;
        }

        public override string ToString()   // Método que me permite imprimir por pantalla correctamente, pasando a string los parámetros del objeto en cuestión
        {
            return x + " , " + y;
        }


        //public double DistanciaEuclidea(double x2, double y2)     //Función que devuelve la distancia entre dos puntos (necesarias 2 coordX y 2 coordY)
        //{
        //    double resultado;
        //    double x1 = this.getX();
        //    double y1 = this.getY();
        //    resultado = ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        //    return resultado;
        //}

        public double DistanciaEuclidea(Punto2D p2)     //Función que devuelve la distancia entre dos puntos (necesarias 2 coordX y 2 coordY). Al haber llamado al método con el punto1, no será necesario pasar sus valores, los toma directamente con this
        {
            double resultado;
            double x1 = this.getX();
            double y1 = this.getY();
            double x2 = p2.getX();
            double y2 = p2.getY();
            resultado = (Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1) * (y2 - y1)));   //Calcula la distancia euclidea entre 2 puntos
            return resultado;
        }

    }
}
