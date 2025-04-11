using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneradoresYPruebas.Dominio.Generadores;

namespace Generadores.Tests;
[TestClass]
public class CongruencialAditivoTests
{
    [TestMethod]
    public void DiapositivaTest()
    {
        // Arrange
        double m = 5147;
        double cantidadAGenerar = 5;
        double[] valoresN = [3317, 5131, 2372, 1942];

        var esperados = new List<double>([0.021, 0.482, 0.479, 0.123, 0.145]);


        // Act
        var numeros = CongruencialAditivo.ObtenerNumerosAleatorios(m, cantidadAGenerar, valoresN);

        // Assert
        for (double i = 0; i < (double)esperados.Count; i++)
        {
            Assert.AreEqual(esperados[(int)i], numeros[(int)i], 0.002);
        }
    }

    [TestMethod]
    public void TpTest()
    {
        // Arrange
        double m = 5147;
        double cantidadAGenerar = 8;
        double[] valoresN = [3317, 5131, 2372, 1942];

        var esperados = new List<double>([0.021, 0.482, 0.479, 0.123, 0.145, 0.628, 0.107, 0.231]);


        // Act
        var numeros = CongruencialAditivo.ObtenerNumerosAleatorios(m, cantidadAGenerar, valoresN);

        // Assert
        for (double i = 0; i < (double)esperados.Count; i++)
        {
            Assert.AreEqual(esperados[(int)i], numeros[(int)i], 0.002);
        }
    }
}
