using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Quadrato
    {
        //information hidding ,non possimao avere attributi pubblici
        //attributo
        private double lato;

        //getter e setters
        //getter
        public double GetLato() 
        {
            return lato;
        }

        //setter - stile java inizializza attributo
        public void SetLato(double lato) 
        {
            if (lato <= 0)
                throw new Exception("Valore inserito non valido!");
            this.lato = lato;
        }

        //metodi
        public double Perimetro()
        {
            double p = lato * 4;
            return p;  
        }

        public double Area() 
        {
            double a = lato * lato;
            return a;
        }

        public double Diagonale()
        {
            double d = lato * Math.Sqrt(2);
            return d;
        }

        //metodo "consumer"

        public string Stampa() 
        {
            return $"" +
                $"Lato: {lato}" +
                $", Perimetro: {Perimetro()}" +
                $", Area: {Area()}" +
                $", Diagonale: {Diagonale()}"
                ;
        }

    }
}
