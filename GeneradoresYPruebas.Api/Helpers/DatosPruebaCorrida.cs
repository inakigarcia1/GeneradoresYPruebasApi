namespace GeneradoresYPruebas.Api.Helpers;

public class DatosPruebaCorrida
{
    public double Comparador { get; set; }
    public double[] ValoresU { get; set; }

    public DatosPruebaCorrida(double comparador, double[] valoresU)
    {
        Comparador = comparador;
        ValoresU = valoresU;
    }
}
