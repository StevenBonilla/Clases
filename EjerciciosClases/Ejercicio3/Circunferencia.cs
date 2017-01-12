using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClases.Ejercicio3
{
    class Circunferencia
    {

        private Punto2D centro;
        private double radius;
        private static double pi = 3.1416;

        public Circunferencia( Punto2D _centro, double _radius)     //Constructor que me va a definir la circunferencia
        {
            this.centro = _centro;
            this.radius = _radius;
        }


        //////////////////////////////////////
        // Metodos para calcular el radio y longitud de una cirunferencia dada
        //////////////////////////////////////

        public double area(double radius)
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


        ////////////////////////////////////////
        //Metodo para saber si un punto dado está dentro de la circunferencia (Si el radio de la circunferencia es mayor que la distancia euclidea entre el centro y el punto en cuestion, está dentro)
        ///////////////////////////////////////
        
        public bool estaDentro(Punto2D punto)
        {
            bool dentro;

            double distancia = punto.DistanciaEuclidea(this.centro);

            if (distancia <= this.radius)
            {
                dentro = true;
            }else
            {
                dentro = false;
            }

            return dentro;
        } 


    }
}
