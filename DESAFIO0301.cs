using System;


namespace DESAFIO0301
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese su ángulo b : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su lado z : ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su lado y : ");
            double y = double.Parse(Console.ReadLine());
            double brad = b * (Math.PI / 180);
            double arad = Math.Atan(y / z);
            double angulocompleto = arad + brad;
            double m = (Math.Tan(angulocompleto)) * z;
            double x = m - y;
            Console.WriteLine("El valor de su x es = " + x);
           


        }
    }
}
