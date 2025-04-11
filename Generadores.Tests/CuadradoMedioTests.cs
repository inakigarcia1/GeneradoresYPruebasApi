using GeneradoresYPruebas.Generadores;

namespace Generadores.Tests;

[TestClass]
public sealed class CuadradoMedioTests
{
    [TestMethod]
    public void DiapositivaTest()
    {
        // Arrange
        int semilla = 123;
        int n = 3;
        int cantidadAGenerar = 4;


        // Act
        var numeros = ParteCentralDelCuadrado.ObtenerNumerosAleatorios(semilla, n, cantidadAGenerar);

        // Assert
        CollectionAssert.AreEqual(numeros, new List<double>([0.512, 0.214, 0.579, 0.524]));
    }

    [TestMethod]
    public void SinMasNumerosTest()
    {
        // Arrange
        int semilla = 123;
        int n = 3;
        int cantidadAGenerar = 15;


        // Act
        var numeros = ParteCentralDelCuadrado.ObtenerNumerosAleatorios(semilla, n, cantidadAGenerar);

        // Assert
        CollectionAssert.AreEqual(numeros, new List<double>([0.512, 0.214, 0.579, 0.524, 0.457, 0.884, 0.145, 0.102, 0.04, 0.6, 0]));
    }

    [TestMethod]
    public void OtroProgramaTest()
    {
        // Arrange
        int semilla = 1234;
        int n = 2;
        int cantidadAGenerar = 7;


        // Act
        var numeros = ParteCentralDelCuadrado.ObtenerNumerosAleatorios(semilla, n, cantidadAGenerar);

        // Assert
        var esperados = new List<double>([0.27, 0.29, 0.41, 0.68, 0.62, 0.84, 0.05]);

        // Assert
        for (int i = 0; i < esperados.Count; i++)
        {
            Assert.AreEqual(esperados[i], numeros[i], 0.01);
        }
    }
}
