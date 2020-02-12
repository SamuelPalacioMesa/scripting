using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int suma = 0;
            int carta1 = 0;
            int carta2 = 0;
            int carta3 = 0;
            string continuar = "";
            
            carta1 = aleatorio.Next(1, 11);
            carta2 = aleatorio.Next(1, 11);
            suma = suma + carta1 +carta2;

            Console.WriteLine("Su carta 1 es : " + carta1);
            Console.WriteLine("Su carta 2 es : " + carta2);
            Console.WriteLine("El total es : " + suma);

            Console.Write("¿Desea otra carta (s/n) :  ");
            continuar = Console.ReadLine();

            while (continuar == "s" && suma < 21)
            {
                carta3 = aleatorio.Next(1, 11);
                suma = suma + carta3;

                
                if (suma > 21)
                {
                    continuar = "n";
                }
                else if (suma == 21)
                {
                    Console.WriteLine("Sacaste el valor perfecto");
                    Console.WriteLine("Su última carta fue : " + carta3);
                    Console.WriteLine("El total es : " + suma);

                }

                else
                {
                    Console.WriteLine("Su nueva carta es : " + carta3);
                    Console.WriteLine("El total es : " + suma);
                    Console.Write("¿Desea otra carta (s/n) :  ");
                    continuar = Console.ReadLine();
                }
            }


            if (continuar == "n")
            {

                if (suma > 21)
                {
                    Console.WriteLine("Perdiste");
                    Console.WriteLine("Su última carta fue : " + carta3);
                    Console.WriteLine("Su total es : " + suma);
                }
                else
                {
                    Console.WriteLine("Su total es : " + suma);

                }
            }



        }


    }
}










