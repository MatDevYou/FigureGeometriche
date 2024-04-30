using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Cerchio
    {
        //attributi 
        private double raggio;

        //overloading
        //costruttore di default
        //public Cerchio() { }

        //costruttore di passaggio con paramatri
         public Cerchio(double raggio)
         {
            this.raggio = raggio;
         }



        //metodi
        public double Diametro()
        {
            return raggio * 2;
        }

        public double Circonferenza()
        {
            return Diametro() * Math.PI;
        }

        public double Area()
        {
            return Math.PI * raggio * raggio;
        }

        public string Stampa()
        {
            return $"" +
                $"\nRaggio: {raggio}" +
                $"\n Diametro: {Diametro()}" +
                $"\n Circonferenza: {Circonferenza()}" +
                $"\n Area: {Area()}"
                ;
        }

    }
}
