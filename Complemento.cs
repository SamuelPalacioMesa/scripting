using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public string[] TercerPunto()
{
    string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
    double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

    string[] salida = new string[0];
    //--------------------------------------------
    //- Abajo de esta línea va su código ---------
    List<double> menorA3 = new List<double>();
    List<string> nombres3 = new List<string>();
    for (int i = 0; i < notas.Length; i++)
    {
        menorA3.Add(notas[i]);
        nombres3.Add(nombres[i]);
    }
    for (int i = 0; i < menorA3.Count; i++)
    {
        Console.WriteLine(nombres3[i]);
    }

    for (int i = 0; i < menorA3.Count; i++)
    {
        if (menorA3[i] >= 3)
        {
            nombres3.RemoveAt(i);
            menorA3.RemoveAt(i);
        }
    }

} 