using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] conjuntoA = { 0, 15, 12, 18, 6, 3, 12, 6, 9, 6, 0, 12, 18 };
            int[] conjuntoB = { 2, 2, 10, 6, 4, 12, 0, 6, 8, 14, 16, 18, 6, 0, 12, 18};
            int[] union = new int[conjuntoA.Length + conjuntoB.Length];
            int tmp = 0, contador = 0;
            int[] unionTemporal = new int[union.Length];
            int ultimovalor = 0;

            for (int i = 0; i < conjuntoA.Length; i++)
            {

                union[i] = conjuntoA[i];

            }
            for (int i = 0; i < conjuntoB.Length; i++)
            {

                union[i+conjuntoA.Length] = conjuntoB[i];

            }

            for (int i = 0; i < union.Length; i++)
            {

                for (int j = 0; j < union.Length-1; j++)
                {


                    if (union[j]> union[j + 1])
                    {
                        tmp = union[j];
                        union[j] = union[j + 1];
                        union[j + 1] = tmp;

                    }
                }
            }
            for (int i = 0; i < union.Length; i++)
            {
                Console.WriteLine(union[i]);
            }
                for (int i = 0; i < union.Length-1; i++)
            {
                
               if( union[i] != union[i + 1] )
                {
                    unionTemporal[contador] = union[i];
                    contador++;

                }
               
              
            }
            unionTemporal[contador] = union[union.Length - 1];
            contador++;


            int[] unionDefinitiva = new int [contador];

            for(int i = 0; i< unionDefinitiva.Length; i++)
            {
                unionDefinitiva[i] = unionTemporal[i];

            }
            for (int i = 0; i < unionDefinitiva.Length; i++)
            {
                Console.Write(unionDefinitiva[i] + ",");
            }
        }
    }
}




