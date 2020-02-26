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
            int jugador = 0;
            int turnos = 0;
            int minimo = 0;
            int jm = 0;

            Console.WriteLine("¿Cuantos jugadores hay? Entre 2 y 5");
            int jugadores = int.Parse(Console.ReadLine());



            while (jugadores > 5 || jugadores < 2)
            {
                Console.WriteLine("¿Cuantos jugadores hay? Entre 2 y 5");
                jugadores = int.Parse(Console.ReadLine());
            }

            while ( (jugadores > turnos))
            {
                turnos++;
                Console.WriteLine("\n Bienvenido jugador " + (jugador+1));
                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);
                suma = carta1 + carta2;

                Console.WriteLine("Su  carta es : " + carta1);
                Console.WriteLine("Su  carta es : " + carta2);
                Console.WriteLine("El total es : " + suma);
                Console.Write("¿Desea otra carta (s/n) :  ");
                continuar = Console.ReadLine();
                
                while(continuar!="n"&& continuar != "s")
                {
                    Console.Write("Se equivocó");

                    Console.WriteLine("¿Desea otra carta (s/n) :  ");
                    continuar = Console.ReadLine();

                }
                while (continuar == "s" && suma < 21)
                {



                    if (continuar == "s")
                    {
                        carta3 = aleatorio.Next(1, 11);
                        suma += carta3;

                        if (suma > 21)
                        {
                            continuar = "n";
                            
                        }
                        else if (suma == 21)
                        {
                            Console.WriteLine("Sacaste el valor perfecto");
                            Console.WriteLine("Su última carta fue : " + carta3);
                            Console.WriteLine("El total es : " + suma);
                            continuar = "n";

                        }

                        else
                        {
                            Console.WriteLine("Su  carta es : " + carta3);
                            Console.WriteLine("El total es : " + suma);
                            Console.Write("¿Desea otra carta (s/n) :  ");
                            continuar = Console.ReadLine();

                        }
                        while (continuar != "n" && continuar != "s")
                        {
                            Console.Write("Se equivocó");

                            Console.WriteLine("¿Desea otra carta (s/n) :  ");
                            continuar = Console.ReadLine();

                        }



                    }


                    
                }

                if (continuar == "n")
                {

                    if ((suma > minimo) && (suma <= 21))
                    {
                        minimo = suma;
                        jm = jugador;
                        



                    }


                    if (suma > 21)
                    {
                        Console.WriteLine("Perdiste");
                        Console.WriteLine("Su última carta fue : " + carta3);
                        Console.WriteLine("Su total es : " + suma);
                        jugador += 1;


                    }
                    else
                    {
                        
                        jugador += 1;


                    }
                }

            }

            if (minimo == 0)
            {
                Console.WriteLine("\n No ganó nadie");
            }
            else
            {
                Console.WriteLine("\n Gana el jugaodor: " + (jm + 1) + " Con: " + minimo + " puntos");
            }
            


        }

    }
}














