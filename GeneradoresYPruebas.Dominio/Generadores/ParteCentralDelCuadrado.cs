using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneradoresYPruebas.Dominio.Generadores;

namespace GeneradoresYPruebas.Generadores
{
    public class ParteCentralDelCuadrado
    {
        public static List<double> ObtenerNumerosAleatorios(double semilla, double numeroDigitosDeseados, double cantidadAGenerar)
        {
            if (cantidadAGenerar < 0)
                throw new InvalidDataException("La cantidad de números a generar no puede ser negativa.");

            if (numeroDigitosDeseados > (double) Math.Pow(semilla.ToString().Length, 2))
                throw new InvalidDataException("La cantidad de dígitos a tomar debe ser menor o igual a la longitud al cuadrado de la semilla.");

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
            double longitudX = (double)Math.Floor(Math.Log10(x) + 1);

            if (!EsPar(longitudX - numeroDigitosDeseados))
            {
                x *= 10;
            }

            var numero = TomarDelMedio(x, numeroDigitosDeseados);
            return numero;
        }
        private static double TomarDelMedio(double x, double numeroDigitosDeseados)
        {
            var textoDeNumeros = x.ToString();
            double longitud = (double) textoDeNumeros.Length;
            double mitad = longitud / 2;
            double moverAlCostado = EsPar(longitud) ? (numeroDigitosDeseados / 2) - 1 : (numeroDigitosDeseados / 2);

            if (EsPar(longitud))
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
