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
        int semilla = 1317;
        int a = 5631;
        int m = 547;
        int cantidadAGenerar = 6;
        var esperados = new List<double>([0.636, 0.427, 0.873, 0.691, 0.257, 0.500]);


        // Act
        var numeros = CongruencialMultiplicativo.ObtenerNumerosAleatorios(semilla, a, m, cantidadAGenerar);

        // Assert
        for(int i = 0; i < esperados.Count; i++)
        {
            Assert.AreEqual(esperados[i], numeros[i], 0.002);
        }
       
    }
}
