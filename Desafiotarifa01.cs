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
            }
            else if ((2 * 877803) <= salario && salario <= (4 * 877803))
            {
                Console.WriteLine("Su tarifa es tipo B");
            }
           
            else
            {
                Console.WriteLine("Su tarifa es tipo C");
            }

        }
    }
}
