using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradoresYPruebas.Dominio.Pruebas;
public class Promedios
{
    public bool EsAleatorio(double comparador, params double[] valoresU)
    {
        var promedio = valoresU.Average();
        var longitud = valoresU.Length;
        var estadistico = ((promedio - 0.5) * Math.Sqrt(longitud)) / Math.Sqrt(1 / 12);
        return Math.Abs(estadistico) < comparador;
    }
}
