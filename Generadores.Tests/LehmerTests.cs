using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneradoresYPruebas.Dominio.Generadores;
using GeneradoresYPruebas.Generadores;

namespace Generadores.Tests;
[TestClass]
public class LehmerTests
{
    [TestMethod]
    public void PresentacionTest()
    {
        // Arrange
        double semilla = 4122;
        double t = 76;
        double k = t.ToString().Length;
        double tot = 5;

        var esperados = new List<double>([0.3241, 0.6292, 0.8145, 0.8959, 0.816]);


        // Act
        var numeros = Lehmer.ObtenerNumerosAleatorios(semilla, t, k, tot);

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
        double semilla = 35451;
        double t = 73;
        double k = t.ToString().Length;
        double tot = 8;

        var esperados = new List<double>([0.87898, 0.16490, 0.3758, 0.4307, 0.4380, 0.9709, 0.8687, 0.4088]);


        // Act
        var numeros = Lehmer.ObtenerNumerosAleatorios(semilla, t, k, tot);

        // Assert
        for (double i = 0; i < (double)esperados.Count; i++)
        {
            Assert.AreEqual(esperados[(int)i], numeros[(int)i], 0.0002);
        }
    }
}
