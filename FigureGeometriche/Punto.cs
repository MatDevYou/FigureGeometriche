using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Punto
    {
        //P(x1,y1)
        //(x2,y2)

        public string Etichetta { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Punto(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Punto(string etichetta, double x, double y)
        {
            Etichetta = etichetta;
            X = x;
            Y = y;
        }

        public double Distanza()
        {//distanza dall'origine degli assi
            Punto o = new Punto(0, 0);
            return Distanza(o);
        }

        public double Distanza(Punto punto)
        {
            return Math.Sqrt(Math.Pow(this.X - punto.X,2) +Math.Pow(this.Y - punto.Y,2));
        }

        public override string ToString()
        {
            return $"{{{nameof(Etichetta)}={Etichetta}, {nameof(X)}={X.ToString()}, {nameof(Y)}={Y.ToString()}, Distanza = {Distanza()}}}";
        }

        public string Stampa()
        {
            return $"{Etichetta}({X},{Y})";
        }
        //distanza

        //overloading
        //rispetto Origine assi

        //toString

    }
}
