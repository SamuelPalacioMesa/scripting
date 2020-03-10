using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salud
{//Aqui está lo trabajdo con switch!
    class Program
    {
        static void Main(string[] args)
        {
            double baseCotizacion = 0, eps = 0, arl = 0, pension = 0, slmmv = 877803, prima = 0, salarioReal = 0, salarioAnual = 0;
            Console.WriteLine("Ingrese su salario en pesos: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tipo de contrato, dependiente(1) o independiente(2): ");
            int tipoContrato = int.Parse(Console.ReadLine());
            baseCotizacion = (salario * 0.4);
            if (baseCotizacion < slmmv) baseCotizacion = slmmv;

            if (tipoContrato == 1)
            {
                eps = (baseCotizacion * 16) / 100;
                pension = (baseCotizacion * 12.5) / 100;
                Console.WriteLine("Ingrese su tipo de riesgo (1 a 5) : ");
                int tipoRiesgo = int.Parse(Console.ReadLine());

                switch (tipoRiesgo)
                {

                    case 1:
                        {
                            arl = (baseCotizacion * 0.522) / 100;
                            break;
                        }
                    case 2:
                        {
                            arl = (baseCotizacion * 1.044) / 100;

                            break;
                        }
                    case 3:
                        {
                            arl = (baseCotizacion * 2.436) / 100;

                            break;
                        }
                    case 4:
                        {
                            arl = (baseCotizacion * 4.350) / 100;
                            break;
                        }
                    case 5:
                        {
                            arl = (baseCotizacion * 6.960) / 100;

                            break;
                        }


                }


            }

            else
            {

                eps = (baseCotizacion * 4) / 100;
                pension = (baseCotizacion * 4) / 100;
                prima = salario;
            }

            salarioReal = salario - eps - pension - arl;
            salarioAnual = (salarioReal * 12) + prima;

            Console.WriteLine(salarioReal);
            Console.WriteLine(salarioAnual);
        }
    }
}

