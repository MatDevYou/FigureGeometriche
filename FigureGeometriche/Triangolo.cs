using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Triangolo
    {
        //tre lati
 

        public double Lato1{ get;  set;}
        public double Lato2 { get; set; }
        public double Lato3 { get; set; }

        //costruttori
        public Triangolo(double lato1, double lato2, double lato3)
        {
            Lato1 = lato1;
            Lato2 = lato2;
            Lato3 = lato3;
        }

        public Triangolo() { }

        public double Perimetro()
        {
            return Lato1 + Lato2 + Lato3;
        }

        public double Area()
        {
            double sp = Perimetro() / 2;
            return Math.Sqrt(sp*(sp-Lato1) * (sp-Lato2) * (sp - Lato3));
        }

        public string Tipo()
        {
            if (Lato1 == Lato2 && Lato1 == Lato3)
                return "Equilatero";
            else if (Lato1 == Lato2 || Lato1 == Lato3 || Lato2 == Lato3)
                return "Isoscele";
            return "Scaleno";
        }

        public bool IsCostruibile()
        {
            return Lato1 + Lato2 > Lato3 && Lato2 + Lato3 > Lato1 && Lato3 + Lato1 > Lato2;
        }

        //perimetro, area, tipo , è costruibile
        public override string ToString()
        {
            if (!IsCostruibile())
            {
                return "Impossibile";
            } else
            {
                return $"" +
            $"\nLato1: {Lato1}" +
            $"\nLato2: {Lato2}" +
            $"\nLato3: {Lato3}" +
            $"\nPerimetro: {Perimetro()}" +
            $"\nArea: {Area()}" +
            $"\nTipo: {Tipo()}"
            ;
            }
        }
    }
}
