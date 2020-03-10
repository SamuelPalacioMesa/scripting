using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace we
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("¿Cuántas personas hay?");
            int n = int.Parse(Console.ReadLine());
            double promedio = 0, suma = 0;
            List<double> edades = new List<double>();
            List<string> nombres = new List<string>();
            double desvicacion = 0;
            double tmp = 0;
            double cercano = 1000000;
            string nombrecercano = "";
            double edadc = 0, mediana = 0; ;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("¿Cual es el nombre de la persona " + (i + 1)+" ?");
                nombres.Add(Console.ReadLine());
                Console.WriteLine("¿Cual es la edad  de la persona " + (i + 1)+ " ?");
                edades.Add(int.Parse(Console.ReadLine()));


            }

            for (int i = 0; i < edades.Count; i++)
            {

                for (int j = 0; j < edades.Count - 1; j++)
                {


                    if (edades[j] > edades[j + 1])
                    {
                        string tmpn = "";
                        tmp = edades[j];
                        tmpn = nombres[j];
                        edades[j] = edades[j + 1];
                        nombres[j] = nombres[j + 1];
                        edades[j + 1] = tmp;
                        nombres[j + 1] = tmpn;

                    }
                }
            }

            for (int i = 0; i < edades.Count; i++)
            {
                promedio += (edades[i] / n);
            }

            for (int i = 0; i < edades.Count; i++)
            {
                suma+=Math.Pow((edades[i]-promedio),2);
            }


            for (int i = 0; i < edades.Count; i++)
            {
                double sumas = 0;
                    sumas = Math.Abs((edades[i]) -promedio);
                if (sumas < cercano)
                {
                    cercano = sumas;                                 //CERCANO AL PROMEDIO
                    nombrecercano = nombres[i];
                    edadc = edades[i];
                }
                
            }

            if (n % 2 == 0)
            {
                mediana = (edades[(n / 2)-1] + edades[n / 2])/2;           // MEDIANAA
            }
            else
            {
                mediana = (edades[((n + 1) / 2)-1]);
            }

            
            desvicacion = Math.Sqrt(suma / 2);  //DESVIACIONN
            Console.WriteLine("Desviacion : " + desvicacion+ " y promedio : " + promedio);

            Console.WriteLine("El mas cercano al promedio es  : " + nombrecercano + " con : " + edadc);

            Console.WriteLine("El mayor es " + nombres[nombres.Count-1] + " Con " + edades[edades.Count-1]);
            Console.WriteLine("El menor es " + nombres[0] + " Con " + edades[0]);
            Console.WriteLine("La mediana es " + mediana);


        }

    }
}



