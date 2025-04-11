using GeneradoresYPruebas.Dominio.Pruebas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Tests
{
    [TestClass]
    public class CorridaDeLaMediaTests
    {
        [TestMethod]
        public void EsAleatorio_DebeRetornarTrue_CuandoChiCuadradoEsMenorAlCritico()
        {
            // Arrange
            double[] valores = new double[]
            {
                0.01, 0.079, 0.168, 0.858, 0.901, 0.74,
                0.713, 0.478, 0.277, 0.019, 0.548, 0.426
            };

            double chiCuadradoCritico = 7.81; // valor crítico del ejemplo

            // Act
            var (esAleatorio, estadistico) = CorridaDeLaMedia.EsAleatorio(chiCuadradoCritico, valores);

            // Assert
            Assert.IsTrue(esAleatorio);
            Assert.AreEqual(5.6, Math.Round(estadistico, 2)); // 5.63 es el valor de χ² calculado en el ejemplo
        }
    }
}
