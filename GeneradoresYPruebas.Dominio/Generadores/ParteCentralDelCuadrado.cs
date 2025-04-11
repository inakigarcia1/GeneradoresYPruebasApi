using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradoresYPruebas.Generadores
{
    public class ParteCentralDelCuadrado
    {
        public static List<double> ObtenerNumerosAleatorios(double semilla, double numeroDigitosDeseados, double cantidadAGenerar)
        {
            if (cantidadAGenerar < 0)
                throw new InvalidDataException("La cantidad de números a generar no puede ser negativa.");

            if (numeroDigitosDeseados > (double) semilla.ToString().Length)
                throw new InvalidDataException("La cantidad de dígitos a tomar debe ser menor o igual a la doubleitud de la semilla.");

            var numerosAleatorios = new List<double>();

            for (double i = 0; i < cantidadAGenerar; i++)
            {
                if(semilla == 0) break;
                semilla = ObtenerSiguienteNumero(semilla, numeroDigitosDeseados);
                numerosAleatorios.Add(Math.Round(semilla / Math.Pow(10, numeroDigitosDeseados), 6));
            }

            return numerosAleatorios;
        }
        private static double ObtenerSiguienteNumero(double semilla, double numeroDigitosDeseados)
        {
            double x = (double)Math.Pow(semilla, 2);
            double doubleitudX = (double)Math.Floor(Math.Log10(x) + 1);

            if (!EsPar(doubleitudX - numeroDigitosDeseados))
            {
                x *= 10;
            }

            var numero = TomarDelMedio(x, numeroDigitosDeseados);
            return numero;
        }
        private static double TomarDelMedio(double x, double numeroDigitosDeseados)
        {
            var textoDeNumeros = x.ToString();
            double doubleitud = (double) textoDeNumeros.Length;
            double mitad = doubleitud / 2;
            double moverAlCostado = EsPar(doubleitud) ? (numeroDigitosDeseados / 2) - 1 : (numeroDigitosDeseados / 2);

            if (EsPar(doubleitud))
            {
                return double.Parse(textoDeNumeros.Substring((int)(mitad - 1 - moverAlCostado), (int)numeroDigitosDeseados));
            }
            else
            {
                return double.Parse(textoDeNumeros.Substring((int)(mitad - moverAlCostado), (int)numeroDigitosDeseados));
            }
        }
        private static bool EsPar(double numero) => numero % 2 == 0;
    }
}
