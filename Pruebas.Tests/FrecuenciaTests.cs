using GeneradoresYPruebas.Dominio.Pruebas;

namespace Pruebas.Tests;

[TestClass]
public class FrecuenciaTests
{
    [TestMethod]
    public void PruebaPowerpoint()
    {
        double[] valoresU = [0.01, 0.079, 0.168, 0.858, 0.901, 0.74, 0.713, 0.478, 0.277, 0.019, 0.548, 0.426];
        double x = 3;
        var comparador = 0.65;

        var resultado = Frecuencia.EsAleatorio(x, comparador, valoresU);

        Assert.IsTrue(resultado.esAleatorio);
        Assert.AreEqual(0.5, resultado.estadistico, 0.1);
    }
}