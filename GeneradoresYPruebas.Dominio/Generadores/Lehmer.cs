using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneradoresYPruebas.Dominio.Excepciones;

namespace GeneradoresYPruebas.Generadores;
public class Lehmer
{
    public static List<double> ObtenerNumerosAleatorios(double semilla, double t, double k, double cantidadDeNumerosAGenerar)
    {
        if (semilla < 0) throw new InvalidDataException("La semilla no puede ser negativa.");
        if (k >= semilla) throw new InvalidDataException("K debe ser menor que la semilla.");

        var numerosAleatorios = new List<double>();
        (double numero, bool esUltimo) resultado = (semilla, false);

        for (double i = 0; i < cantidadDeNumerosAGenerar; i++)
        {
            resultado = ObtenerSiguienteNumero(resultado.numero, t, k);

            if (resultado.esUltimo)
            {
                numerosAleatorios.Add(resultado.numero);
                break;
            }

            numerosAleatorios.Add(Math.Round(resultado.numero / Math.Pow(10, resultado.numero.ToString().Length), 6));
        }

        return numerosAleatorios;
    }
    private static (double numero, bool esUltimo) ObtenerSiguienteNumero(double semilla, double t, double k)
    {
        if(semilla < 0) return (0, true); // No se pueden generar más números

        if (k >= semilla) throw new InvalidDataException("K debe ser menor que la semilla.");

        var multiplicacionTexto = (semilla * t).ToString();

        var restar = new string(multiplicacionTexto.Take((int)k).ToArray());

        multiplicacionTexto = multiplicacionTexto.Remove(0, (int)k);

        return (double.Parse(multiplicacionTexto) - double.Parse(restar), false);
    }
}
