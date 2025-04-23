using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneradoresYPruebas.Dominio.Excepciones;
using GeneradoresYPruebas.Dominio.Generadores;

namespace GeneradoresYPruebas.Generadores;
public class Lehmer
{
    public static List<double> ObtenerNumerosAleatorios(double semilla, double t, double k, double cantidadDeNumerosAGenerar)
    {
        if (semilla < 0) throw new InvalidDataException("La semilla no puede ser negativa.");
        if (k >= semilla.ToString().Length) throw new InvalidDataException("K debe ser menor que la longitud semilla.");

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
        // No se pueden generar más números
        if (semilla < 0) return (-1, true);
        if (k >= semilla.ToString().Length) return (-1, true);

        var multiplicacionTexto = (semilla * t).ToString();
        var restar = new string(multiplicacionTexto.Take((int)k).ToArray());
        multiplicacionTexto = multiplicacionTexto.Remove(0, (int)k);

        // No se pueden generar más números
        if (multiplicacionTexto == "0" && restar != "0") return (-1, true);

        (double numero, bool esUltimo) resultado = (double.Parse(multiplicacionTexto) - double.Parse(restar), false);

        if (resultado.numero < 0)
            return (Math.Abs(resultado.numero), true);

        return resultado;
    }
}