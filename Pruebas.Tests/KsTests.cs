using GeneradoresYPruebas.Dominio.Pruebas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Tests
{
    [TestClass]
    public class KsTests
    {
        [TestMethod]
        public void EsAleatorio_DebeRetornarVerdadero_SiDnEsMenorAValorCritico_Ejemplo()
        {
            // Arrange
            double[] valores = new double[]
            {
                0.01, 0.079, 0.168, 0.858, 0.901, 0.74,
                0.713, 0.478, 0.277, 0.019, 0.548, 0.426
            };

            double valorCritico = 0.375;

            // Act
            var (esAleatorio, estadistico) = Ks.EsAleatorio(valorCritico, valores);

            // Assert
            Assert.IsTrue(esAleatorio, "Se esperaba que la secuencia fuera aleatoria");
            Assert.IsTrue(estadistico < valorCritico, $"Se esperaba que Dn < dα,n. Obtenido: {estadistico}");
        }
    }
}
