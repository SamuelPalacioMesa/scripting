using System;


namespace Desafio0202
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite el valor de su hipotenusa (t): ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Digite el valor de su ángulo a: ");
            double aGrados = double.Parse(Console.ReadLine());
            double a = aGrados * (Math.PI / 180);
            double c = (180 - 90 - aGrados);
            double valorY = t * (Math.Sin(a));
            double valorZ = t * (Math.Cos(a));
            Console.WriteLine("El valor de su ángulo c es: " + c);
            Console.WriteLine("El valor de su cateto z es: " + valorZ);
            Console.WriteLine("El valor de su cateto z es: " + valorY);
            Console.WriteLine("Desafio 0202 por Samuel palacio ");
        }
    }
}
