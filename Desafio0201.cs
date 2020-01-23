using System;


namespace Desafio0201
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el valor numérico de su cateto z: ");
            double valorZ = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor numérico de su cateto y: ");
            double valorY = double.Parse(Console.ReadLine());
            double valorHipotenusa = Math.Sqrt(Math.Pow(valorZ, 2) + Math.Pow(valorY, 2));
            Console.WriteLine("El valor de su hipotenusa (t) es: " + valorHipotenusa);
            double C = Math.Atan(valorZ / valorY);
            double A = Math.Atan(valorY / valorZ);
            double valorC = (C * (180 / Math.PI));
            double valorA = (A * (180 / Math.PI));
            Console.WriteLine("El valor de su ángulo c es: " + valorC);
            Console.WriteLine("El valor de su ángulo a es: " + valorA);
            Console.WriteLine("Desafio0201 por Samuel Palacio");


        }
    }
}
