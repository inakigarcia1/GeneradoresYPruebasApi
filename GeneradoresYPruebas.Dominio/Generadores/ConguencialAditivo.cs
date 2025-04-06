using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradoresYPruebas.Dominio.Generadores;
public class ConguencialAditivo
{
    public static List<double> ObtenerNumerosAleatorios(int m, int cantidadNumerosAGenerar, params int[] valoresN)
    {
        var numerosAleatorios = new List<double>();
        var k = valoresN.Length - 1;

        var diccionarioN = new SortedDictionary<int, int>();

        for(int i = -(valoresN.Length - 1); i < 1; i++)
        {
            diccionarioN.Add(i, valoresN[Math.Abs(i)]);
        }

        int resto = diccionarioN[0];
        for (int i = 0; i < cantidadNumerosAGenerar; i++)
        {
            resto = (int)ObtenerSiguienteResto(resto, m, k, i, diccionarioN);
            diccionarioN.Add(i + 1, resto);
            numerosAleatorios.Add(Math.Round((double)resto / m, 3));
        }

        return numerosAleatorios;
    }

    private static double ObtenerSiguienteResto(double restoPrevio, int m, int k, int i, SortedDictionary<int, int> diccionarioN)
    {
        return (restoPrevio + diccionarioN[i - k]) % m;
    }
}
