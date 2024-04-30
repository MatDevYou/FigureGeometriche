using System.Security.Cryptography;

namespace FigureGeometriche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Figure Geometriche!");

            Quadrato q = new Quadrato();
            

            try 
            {
                
                q.SetLato(-1.45);//inizializzo il lato del quadrato
                Console.WriteLine(q.Stampa());

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Cerchio c = new Cerchio(1.45);

            Console.WriteLine(c.Stampa());

            Rettangolo r = new Rettangolo()
            {
                Base = 1.45,
                Altezza = 6
            };

            Console.WriteLine(r.ToString());

            Triangolo t = new Triangolo(1, 2, 3);

            Console.WriteLine(t);

            Punto p = new Punto("P", 2,3);
            Console.WriteLine(p);

            Punto q1 = new Punto("Q", -2, -3);
            Console.WriteLine(q1);

            Punto r1 = new Punto(1.5, -2.5);
            Console.WriteLine(r1.Stampa());

            Console.WriteLine($"PQ = {p.Distanza(q1)}");
            Console.WriteLine($"PQ = {q1.Distanza(p)}");

            Triangolo t1 = new Triangolo(p,q1,r1);
            Console.WriteLine(r1);
        }
    }
}