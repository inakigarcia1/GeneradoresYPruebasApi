using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradoresYPruebas.Generadores
{
    public class ParteCentralDelCuadrado
    {
        public static List<double> ObtenerNumerosAleatorios(int semilla, int numeroDigitosDeseados, int cantidadAGenerar)
        {
            if (cantidadAGenerar < 0)
                throw new InvalidDataException("La cantidad de números a generar no puede ser negativa.");

            if (numeroDigitosDeseados > semilla.ToString().Length)
                throw new InvalidDataException("La cantidad de dígitos a tomar debe ser menor o igual a la longitud de la semilla.");

            var numerosAleatorios = new List<double>();

            for (int i = 0; i < cantidadAGenerar; i++)
            {
                if(semilla == 0) break;
                semilla = ObtenerSiguienteNumero(semilla, numeroDigitosDeseados);
                numerosAleatorios.Add(Math.Round(semilla / Math.Pow(10, numeroDigitosDeseados), 3));
            }

            return numerosAleatorios;
        }
        private static int ObtenerSiguienteNumero(int semilla, int numeroDigitosDeseados)
        {
            int x = (int)Math.Pow(semilla, 2);
            int longitudX = (int)Math.Floor(Math.Log10(x) + 1);

            if (!EsPar(longitudX - numeroDigitosDeseados))
            {
                x *= 10;
            }

            return TomarDelMedio(x, numeroDigitosDeseados);
        }
        private static int TomarDelMedio(int x, int numeroDigitosDeseados)
        {
            var textoDeNumeros = x.ToString();
            var longitud = textoDeNumeros.Length;
            int mitad = longitud / 2;
            int moverAlCostado = EsPar(longitud) ? (numeroDigitosDeseados / 2) - 1 : (numeroDigitosDeseados / 2);

            return int.Parse(textoDeNumeros.Substring(mitad - 1 - moverAlCostado, numeroDigitosDeseados));
        }
        private static bool EsPar(int numero) => numero % 2 == 0;
    }
}
