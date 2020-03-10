using System;

namespace SDSDWEWQWDWE
{
    class Program
    {
        //Aqui está el como hacer randoms!!  -----para que no pueda seguir se no es lo que se pide que ingrese!!!-----consecutivo!!!
        static void Main(string[] args)
        {
            int dado1 = 0, dado2 = 0, total = 0, suma = 0, dobles = 0;
            double contador6 = 0, porcentaje = 0, turnos = 0;
            string respuesta = "";
            Random aleatorio = new Random(); //random!!

            while (true)
            {
                turnos ++ ;
                dado1 = aleatorio.Next(1, 7); //Random!!!
                dado2 = aleatorio.Next(1, 7); //Random!!!
                total += dado1 + dado2;
                suma = dado1 + dado2;
               
                if (suma > 6)
                {
                    contador6 += 1;
                    suma = 0;
                }
                Console.WriteLine("Sus dados dieron: " + dado1 + " y " + dado2 + " En total lleva : " + total);
                if (dado1 == 1 && dado2 == 1)
                {
                    Console.WriteLine("Perdiste!");
                    break;

                }
                if (dado1 == dado2) //consecutivo
                {
                    dobles += 1;

                }
                else
                {
                    dobles = 0;
                }
                if (total >= 100|| dobles >= 3)
                {
                    Console.WriteLine(" Ganaste!");
                    break;

                }
                
                Console.WriteLine("Desea continuar: (s o n) ");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToUpper(); // mayuscula
                
                while (respuesta != "N" && respuesta != "S") //para que no pueda seguir se no es lo que se pide que ingrese
                {
                    Console.WriteLine("Desea continuar: (s o n) ");
                    respuesta = Console.ReadLine();
                    respuesta = respuesta.ToUpper();
                }

                if(respuesta == "N")
                {
                    break;
                }

                

            }
            
            porcentaje = (contador6 / turnos)* 100 ;
            Console.WriteLine("Su porcentaje de turnos mayor a 6 fue : " + porcentaje);
                
        }
    }
}


