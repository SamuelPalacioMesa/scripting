using System;

namespace _5Jueves
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado = 0;
            int vidas = 3;
            int total = 0;
            int turno = 0;
            int dado2 = 0;
            string continuar = "s";

            while (continuar == "s" && vidas != 0 && total < 100)
            {
                dado = aleatorio.Next(1, 7);
                dado2 = 0;

                turno++;

                if (turno % 2 == 0)
                {
                    vidas--;
                    Console.WriteLine("Turno par, perdió 1 vida.");
                }
                if (turno % 3 == 0)
                {
                    dado2 = aleatorio.Next(1, 7);
                    if (dado2 == dado)
                    {
                        vidas++;
                        Console.WriteLine("Ganó 1 vida");
                    }

                    Console.WriteLine("Sacó " + dado2 + " y ");
                }

                Console.WriteLine("Sacó " + dado);
                total += dado + dado2;

                if (vidas == 0)
                {
                    Console.WriteLine("Perdió. Tiene " + vidas + " vidas.");
                    continuar = "n";
                }

               
                else if (total >= 100)
                {
                    Console.WriteLine("Ganó, sacó" + total);
                    continuar = "n";
                }

                
                else
                {
                    Console.WriteLine("Lleva: " + total + " y tiene: " + vidas + " vidas.");
                    Console.WriteLine("Continuar (s/n)?");

                    continuar = Console.ReadLine();
                }

            }
        }
    }
}