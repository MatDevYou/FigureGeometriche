using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Rettangolo
    {
        private double _latoBase;
        private double _altezza;

        //proprieta
        public double Base 
        {
            get { return _latoBase; }
            set { _latoBase = value; } 
        }


        public double Altezza
        {
            get { return _altezza; }
            set { _altezza = value; }
        }

        //propfull

        public double Perimetro() 
        {
            return (_latoBase + _altezza) * 2;
        }

        public double Area()
        {
            return _latoBase * _altezza;
        }

        public double Diagonale()
        {
            return Math.Sqrt(Math.Pow(_latoBase, 2) + Math.Pow(_altezza, 2));
        }



        public string Stampa()
        {
            return $"" +
                $"\nBase: {_latoBase}" +
                $"\nAltezza: {_altezza}" +
                $"\nPerimetro: {Perimetro()}" +
                $"\nArea: {Area()}" +
                $"\nDiagonale: {Diagonale()}"
                ;
        }

        //overriding , sovrascivi metodi con caratteristiche precise
        public override string ToString()
        {
            return $"" +
            $"\nBase: {Base}" +
            $"\nAltezza: {Altezza}" +
            $"\nPerimetro: {Perimetro()}" +
            $"\nArea: {Area()}" +
            $"\nDiagonale: {Diagonale()}"
    ;
        }
    }
}
