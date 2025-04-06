using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradoresYPruebas.Generadores;
public class CongruencialMixto
{
    public static List<double> ObtenerNumerosAleatorios(double semilla, double a, double c, double m, int cantidadDeNumerosAGenerar)
    {
        var numerosAleatorios = new List<double>();

        for (int i = 0; i < cantidadDeNumerosAGenerar; i++)
        {
            semilla = (int) ObtenerSiguienteResto(semilla, a, c, m);
            numerosAleatorios.Add(Math.Round((double)semilla / m, 3));
        }

        return numerosAleatorios;
    }

    private static double ObtenerSiguienteResto(double restoPrevio, double a, double c, double m)
    {
        return (a * restoPrevio + c) % m;
    }
}
