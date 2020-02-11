using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBase
{
    class Program
    {
        static void Main()
        {
            int tipoderiesgo= 0 ;
            double arl = 0;
            int prima = 0;
            double eps = 0;
            double pension = 0;
            double salarioreal = 0;
            double salarioanual = 0;
            int SMMV = 877803;
            Console.Write("Ingrese su salario: ");
            int salario = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su tipo de contrato(Independiente=1 e dependiente=2): ");
            int contrato = int.Parse(Console.ReadLine());

            double basecotizacion = salario*0.4;
            if (basecotizacion < SMMV) basecotizacion = SMMV;

            switch (contrato)
            {
                case 1:

                    Console.Write("Ingrese su tipo de riesgo (1 a 5 ): ");
                    tipoderiesgo = int.Parse(Console.ReadLine());
                    switch (tipoderiesgo)
                    {
                        case 1:
                            arl = basecotizacion * 0.00522;
                            break;
                        case 2:
                            arl = basecotizacion * 0.01044;
                            break;
                        case 3:
                            arl = basecotizacion * 0.02436;
                            break;
                        case 4:
                            arl = basecotizacion * 0.04350;
                            break;
                        case 5:
                            arl = basecotizacion * 0.06960;
                            break;
                    }
                    eps = basecotizacion * 0.16;
                    pension = basecotizacion * 0.125;
                    break;

                case 2:

                    eps = basecotizacion * 0.04;
                    pension = basecotizacion * 0.04;
                    prima = salario;
                    break;
            }

            salarioreal = (salario - eps - pension - arl);
            salarioanual = (salarioreal * 12) + prima;
            Console.WriteLine("Su salario real es : " + salarioreal);
            Console.WriteLine("Su salario real es : " + salarioanual);
        
        }
    }
}
