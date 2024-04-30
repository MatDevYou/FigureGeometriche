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

        }
    }
}