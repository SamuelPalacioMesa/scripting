using System;


namespace Desafio0203
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el valor numérico de su cateto z : ");
            double valorZ = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor numérico de su ángulo c : ");
            double cGrados = double.Parse(Console.ReadLine());
            double cRadianes = cGrados * (Math.PI/180);
            double valorT = (valorZ / (Math.Sin(cRadianes)));
            double valorY = (valorZ / (Math.Tan(cRadianes)));
            double valorA = (180 - 90 - cGrados);
            Console.WriteLine("El valor de su hipotenusa (t) es : " + valorT);
            Console.WriteLine("El valor de y es : " + valorY);
            Console.WriteLine("El valor de su ángulo a es : " + valorA);
            Console.WriteLine("Desafio 0203 por Samuel Palacio ");
        }
    }
}
