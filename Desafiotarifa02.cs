using System;


namespace DESAFIOTARIFA
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese su salario en pesos : ");
            double salario = double.Parse(Console.ReadLine());
            if (salario < (2 * 877803))
            {
                Console.WriteLine("Su tarifa es tipo A");
                Console.WriteLine("El valor de su cuota moderadora es de 3400");
            }
            else if ((2 * 877803) <= salario && salario <= (5 * 877803))
            {
                Console.WriteLine("Su tarifa es tipo B");
                Console.WriteLine("El valor de su cuota moderadora es de 13500");
            }
            else
            {
                Console.WriteLine("Su tarifa es tipo C");
                Console.WriteLine("El valor de su cuota moderadora es de 35600");
            }
        }
    }
}
