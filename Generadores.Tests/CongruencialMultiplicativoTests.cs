using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneradoresYPruebas.Dominio.Generadores;
using GeneradoresYPruebas.Generadores;

namespace Generadores.Tests;
[TestClass]
public class CongruencialMultiplicativoTests
{
    [TestMethod]
    public void DiapositivaTest()
    {
        // Arrange
        double semilla = 1317;
        double a = 5631;
        double m = 547;
        double cantidadAGenerar = 6;
        var esperados = new List<double>([0.636, 0.427, 0.873, 0.691, 0.257, 0.500]);


        // Act
        var numeros = CongruencialMultiplicativo.ObtenerNumerosAleatorios(semilla, a, m, cantidadAGenerar);

        // Assert
        for(double i = 0; i < (double)esperados.Count; i++)
        {
            Assert.AreEqual(esperados[(int)i], numeros[(int)i], 0.002);
        }
       
    }
}
