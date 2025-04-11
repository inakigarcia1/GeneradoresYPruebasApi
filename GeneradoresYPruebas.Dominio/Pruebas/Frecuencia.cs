using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace GeneradoresYPruebas.Dominio.Pruebas;
public class Frecuencia
{
    public static (bool esAleatorio, double estadistico) EsAleatorio(int x, double comparador, params double[] valoresU)
    {
        var n = valoresU.Length;
        var listaU = new List<double>(valoresU).Order().ToList();
        var tamañoIntervalo = 1 / (double)x;
        var frecuenciaEsperada = n / (double)x;

        var frecuenciasObservadas = new Dictionary<int, int>(x);
        int numeroIntervalo = 1;

        for (double i = 0; i <= 1; i += tamañoIntervalo)
        {
            for (int j = 0; j < listaU.Count; j++)
            {
                if (listaU[j] < i || listaU[j] > i + tamañoIntervalo) continue;
                if (frecuenciasObservadas.TryAdd(numeroIntervalo, 1)) continue;

                frecuenciasObservadas[numeroIntervalo]++;
            }
            numeroIntervalo++;
        }

        double sumatoria = 0;
        foreach (var observacion in frecuenciasObservadas)
        {
            sumatoria += Math.Pow(observacion.Value - frecuenciaEsperada, 2);
        }

        var chiCuadrado = ((double)x / n) * sumatoria;

        return (chiCuadrado < comparador, chiCuadrado);
    }
}
