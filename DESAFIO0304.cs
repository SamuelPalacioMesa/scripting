using System;


namespace DESADIO0304
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese su lado w : ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su lado t : ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su ánguo c : ");
            double c = double.Parse(Console.ReadLine());
            double crad = c * (Math.PI / 180);
            double z = t * (Math.Sin(crad));
            double m = Math.Sqrt(Math.Pow(w, 2) - Math.Pow(z, 2));
            double y = t * (Math.Cos(crad));
            double x = m - y;
            Console.WriteLine("Su lado x es : " + x);
        }
    }
}
