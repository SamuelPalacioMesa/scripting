using System;


namespace Dados
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random ();
            int dado = aleatorio.Next(1, 13);
            int suma = 0;
            int turnos = 0;
            int anterior = 0;

            Console.WriteLine("Usted sacó : " + dado);
            Console.WriteLine("¿Desea continuar? (s/n) ");
            string respuesta = Console.ReadLine();
            suma += dado;
            turnos++;

            anterior = dado;

            while (respuesta == "s")
            {
                anterior = dado;
                dado = aleatorio.Next(1, 13);
                suma += dado;
                turnos++;

                if (anterior == 10 && dado == 12)
                {
                    Console.WriteLine("¡GANASTE!");
                    Console.WriteLine("Usted sacó : " + dado + " y antes un " + anterior);;
                    respuesta = "n";
                }
                else if (suma >= 100)
                {
                    Console.WriteLine("¡GANASTE!");
                    Console.WriteLine("Usted sacó : " + dado);
                    respuesta = "n";
                }
                else if (dado % 2 != 0 && turnos > 3)
                {
                    Console.WriteLine("¡PERDISTE!");
                    Console.WriteLine("Usted sacó un número impar : " + dado);
                    respuesta = "n";
                }
                else
                {
                    Console.WriteLine("Usted sacó : " + dado);
                    Console.WriteLine("Usted en total tiene : " + suma);
                    Console.WriteLine("¿Desea continuar? (s/n) ");
                    respuesta = Console.ReadLine();
                }

            }

            if (respuesta == "n")
            {
                
                Console.WriteLine("Usted en total obtuvo : " + suma);

            }
        }
    }
}














