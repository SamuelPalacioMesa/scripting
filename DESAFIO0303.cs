using System;


namespace DESADIO0303
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese su lado w : ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su ángulo d : ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su lado x : ");
            double x = double.Parse(Console.ReadLine());
            double drad = d * (Math.PI / 180);
            double m = w * (Math.Cos(drad));
            double y = m - x;
            Console.WriteLine("Su lado y es : " + y);
        }
    }
}
