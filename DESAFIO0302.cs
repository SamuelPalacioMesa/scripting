using System;

namespace DESAFIO0302
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese su ángulo d : ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su ángulo b : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su lado y : ");
            double y = double.Parse(Console.ReadLine());
            double angulogrande = 180 - 90 - d;
            double a = angulogrande - b;
            double arad = a * (Math.PI / 180);
            double z = y / (Math.Tan(arad));
            Console.WriteLine("El valor de su z es : " + z);
            
        }
    }
}
