using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradoresYPruebas.Generadores;
public class Lehmer
{
    public static List<double> ObtenerNumerosAleatorios(int semilla, int t, int k, int cantidadDeNumerosAGenerar)
    {
        if (k >= semilla) throw new InvalidDataException("K debe ser menor que la semilla");

        var numerosAleatorios = new List<double>();

        for (int i = 0; i < cantidadDeNumerosAGenerar; i++)
        {
            semilla = ObtenerSiguienteNumero(semilla, t, k);

            numerosAleatorios.Add(Math.Round(semilla / Math.Pow(10, semilla.ToString().Length), 3));
        }

        return numerosAleatorios;
    }
    private static int ObtenerSiguienteNumero(int semilla, int t, int k)
    {
        if (k >= semilla) throw new InvalidDataException("K debe ser menor que la semilla");

        var multiplicacionTexto = (semilla * t).ToString();

        var restar = new string(multiplicacionTexto.Take(k).ToArray());

        multiplicacionTexto = multiplicacionTexto.Remove(0, k);

        return int.Parse(multiplicacionTexto) - int.Parse(restar);
    }
}
