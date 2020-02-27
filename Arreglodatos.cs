using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosdeDatos
{
    class Program
    {
        static void Main()
        {
            double maximo = 0;
            int npendientes = 6;
            double[]   Cx = { 0, 2, 3,7 };
            double[]   Cy = { 0, 1, 5, 7 };

            double M01 = (Cy[1] - Cy[0]) / (Cx[1] - Cx[0]);
            double M02 = (Cy[2] - Cy[0]) / (Cx[2] - Cx[0]);
            double M03 = (Cy[3] - Cy[0]) / (Cx[3] - Cx[0]);
            double M04 = (Cy[2] - Cy[1]) / (Cx[2] - Cx[1]);
            double M05 = (Cy[3] - Cy[1]) / (Cx[3] - Cx[1]);
            double M06 = (Cy[3] - Cy[2]) / (Cx[3] - Cx[2]);

            double D01 = Math.Sqrt(Math.Pow((Cy[1] - Cy[0]), 2) + Math.Pow((Cx[1] - Cx[0]), 2));
            double D02 = Math.Sqrt(Math.Pow((Cy[2] - Cy[0]), 2) + Math.Pow((Cx[2] - Cx[0]), 2));
            double D03 = Math.Sqrt(Math.Pow((Cy[3] - Cy[0]), 2) + Math.Pow((Cx[3] - Cx[0]), 2));
            double D04 = Math.Sqrt(Math.Pow((Cy[2] - Cy[1]), 2) + Math.Pow((Cx[2] - Cx[1]), 2));
            double D05 = Math.Sqrt(Math.Pow((Cy[3] - Cy[1]), 2) + Math.Pow((Cx[3] - Cx[1]), 2));
            double D06 = Math.Sqrt(Math.Pow((Cy[3] - Cy[2]), 2) + Math.Pow((Cx[3] - Cx[2]), 2));

           


            double comprobante = (M01 + M02 + M03 + M04 + M05 + M06) / npendientes;



            if (D01 > maximo)
            {
                maximo = D01;

            }
            if((D02 > maximo))
            {

                maximo = D02;

            }
            if ((D03 > maximo))
            {

                maximo = D03;

            }
            if ((D04 > maximo))
            {

                maximo = D04;

            }
             if ((D05 > maximo))
            {

                maximo = D05;

            }
            if ((D06 > maximo))
            {

                maximo = D06;

            }






            if (comprobante==M01 && comprobante == M02 && comprobante == M03 && comprobante == M04
                && comprobante == M05 && comprobante == M06)
            {

                Console.WriteLine("Los puntos está alineados");

            }
            else
            {
                Console.WriteLine("Los puntos no están alineados");

            }



            Console.WriteLine( "La maxima distancia es : " + maximo);







        }
    }
}
