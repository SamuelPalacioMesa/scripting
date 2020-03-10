using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            int[] conjuntoA = { 0, 15, 12, 18, 6, 3, 12, 6, 9, 6, 0, 12, 18 };
            int[] conjuntoB = { 2, 2, 10, 6, 4, 12, 0, 6, 8, 14, 16, 18, 6, 0, 12, 18 };
            int tmp = 0;

            List<int> interseccion = new List<int>();
            for (int i = 0; i < conjuntoA.Length; i++)
            {
                for (int j = 0; j < conjuntoB.Length; j++)
                {
                    if (conjuntoA[i] == conjuntoB[j])
                    {
                        interseccion.Add(conjuntoA[i]);
                    }
                }
            }

            for (int i = 0; i < interseccion.Count-1; i++)            //
            {

                for (int j = 0; j < interseccion.Count - 1; j++)
                {


                    if (interseccion[j] > interseccion[j + 1])                       //buble
                    {
                        tmp = interseccion[j];
                        interseccion[j] = interseccion[j + 1];
                        interseccion[j + 1] = tmp;

                    }
                    if (interseccion[i + 0] == interseccion[i + 1])
                    {
                        interseccion.RemoveAt(i);
                        i = 0;
                    }
                }                                                   //
            }


            for (int i = 0; i < interseccion.Count; i++)
            {

                Console.Write(interseccion[i]+ ",");
            }
        }
    }
}
