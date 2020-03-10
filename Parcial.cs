using System;
using System.Collections.Generic;
using System.Text;

class Parcial {

    string[] names;
    double[] data;
    

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------


        for (int i = 0; i < nombres.Length; i++)
        {
            bool a = notas[i] <= 3;
            if (a == true)
            {
                salida++;
            }

        }
        Console.WriteLine(salida);
       



        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        for (int j = 0; j < nombres.Length; j++)
        {
            for (int i = 0; i < nombres.Length-1; i++)
            {
                double tmpnotas = 0;
                string tmpnombres = "";
                if (notas[i] > notas[i + 1])
                {
                    tmpnotas = notas[i + 1];
                    tmpnombres = nombres[i + 1];
                    notas[i + 1] = notas[i];
                    nombres[i + 1] = nombres[i];
                    notas[i] = tmpnotas;
                    nombres[i] = tmpnombres;

                }
            }
        }
        for (int i = 0; i < salida.Length; i++)
        {
            salida[i] = nombres[i];
        }
        for (int i = 0; i < salida.Length; i++)
        {
            Console.Write(salida);
        }





        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        List<string> nombres3 = new List<string>();
        int total = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas [i] <= 3)
            {
                
                nombres3.Add(nombres[i]);
                total++;
            }
        }
        salida = new string[total];
        for(int i = 0; i < salida.Length; i++)
        {
            salida[i] = nombres3[i];
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        int total = 0;
        for (int i = 0; i < nombres.Length; i++)
        {
            if (nombres[i][0] == 'A' || nombres[i][0] == 'E' || nombres[i][0] == 'I' || nombres[i][0] == 'O' || nombres[i][0] == 'U' )
            {
                total++;
            }
        }

        salida = new string[total];
        int j = 0;
        for (int i = 0; i < nombres.Length; i++)
        {

            if (nombres[i][0] == 'A' || nombres[i][0] == 'E' || nombres[i][0] == 'I' || nombres[i][0] == 'O' || nombres[i][0] == 'U')
            {
                salida[j] = nombres[i];
                j++;
            }
        }

        



        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------





        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> CuartoPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------





        //- Arriba de esta línea va su código --------
        return salida;
    }
}


