using System;


namespace DesafioVotaciones
{
    class Program
    {
        static void Main()
        {
            int diferencia = 0;
           
            Console.Write("Ingrese los votos por el partido A: ");
            int votosA = int.Parse(Console.ReadLine());
            Console.Write("Ingrese los votos por el partido B: ");
            int votosB = int.Parse(Console.ReadLine());
            Console.Write("Ingrese los votos en blanco : ");
            int blancos = int.Parse(Console.ReadLine());
            Console.Write("Ingrese los votos anulados : ");
            int anulados = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el numero de la población : ");
            double poblacion = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el porcentaje de la poblacion mayor de edad : ");
            double porcentaje = int.Parse(Console.ReadLine());

            double totalvotos = votosA + votosB + blancos + anulados;

            if (votosA > votosB) diferencia = votosA - votosB;
            else diferencia = votosB - votosA;

            bool a = totalvotos > poblacion;
            bool b = diferencia < (totalvotos * 0.1);
            bool c = totalvotos < (poblacion * 0.3);

            if ((a || b) && c) Console.WriteLine("Las elecciones deben ser ejecutadas nuevamente");

            else
            {
                if (votosA > votosB) Console.WriteLine("Ganó el partido A");

                else Console.WriteLine("Ganó el partido B");


            }





        }
    }
}
