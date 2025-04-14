using GeneradoresYPruebas.Dominio.Pruebas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Tests
{
    [TestClass]
    public class SeriesTests
    {
        [TestMethod]
        public void EsAleatorio_EjemploDeLADiapoXd_RetornaVerdaderoYEstadisticoCorrecto()
        {
            // Arrange
            double[] valoresU = new double[]
            {
                0.01, 0.079,
                0.277, 0.019,
                0.168, 0.858,
                0.901, 0.74,
                0.713, 0.478,
                0.548, 0.426
            };

            double x = 2;
            double chiCuadradoCritico = 0.675;

            // Act
            var (esAleatorio, estadistico) = Series.EsAleatorio(x, chiCuadradoCritico, 6, valoresU);

            // Assert
            Assert.IsTrue(esAleatorio, "La prueba no pasó el umbral de chi cuadrado crítico.");
            Assert.AreEqual(0.667, Math.Round(estadistico, 3), "El estadístico chi-cuadrado calculado no es el esperado.");
        }
    }
}
