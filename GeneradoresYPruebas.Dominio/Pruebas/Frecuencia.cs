using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradoresYPruebas.Dominio.Pruebas;
public class Frecuencia
{
    public static bool EsAleatorio(int x, double estadistico, params double[] valoresU)
    {
        var n = valoresU.Length;
        var tamañoIntervalo = 1 / (double)x;
        var frecuenciaEsperada = n / (double)x;

        var intervalos = new List<double>();

        var frecuenciasObservadas = new Dictionary<int, int>();
        for (double i = 0; i <= 1; i += tamañoIntervalo)
        {
            intervalos.Add(i);
        }

        for(int i = 1; i <= x; i++)
        {
            frecuenciasObservadas.Add(i, 0);
        }


        for (int i = 0; i < x; i++)
        {
            for(int j = 0; i < valoresU.Length; j++)
            {
                if (valoresU[i] > intervalos[i] && valoresU[i] < intervalos[i + 1])
                {

                }
            }
        }

        return true;
    }
}
