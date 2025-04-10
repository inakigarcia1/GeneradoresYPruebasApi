using GeneradoresYPruebas.Dominio.Pruebas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Tests;
[TestClass]
public class PromedioTests
{
    [TestMethod]
    public void PruebaPowerpoint()
    {
        double[] valoresU = [0.01, 0.079, 0.168, 0.858, 0.901, 0.74, 0.713, 0.478, 0.277, 0.019, 0.548, 0.426];
        var comparador = 0.957;

        var resultado = Promedios.EsAleatorio(comparador, valoresU);

        Assert.IsTrue(resultado.esAleatorio);
        Assert.AreEqual(0.783, resultado.estadistico, 0.1);
    }

}
