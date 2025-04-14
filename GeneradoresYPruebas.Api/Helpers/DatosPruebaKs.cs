namespace GeneradoresYPruebas.Api.Helpers;

public class DatosPruebaKs
{
    public double Comparador { get; set; }
    public double[] ValoresU { get; set; }

    public DatosPruebaKs(double comparador, double[] valoresU)
    {
        Comparador = comparador;
        ValoresU = valoresU;
    }
}
