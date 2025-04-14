namespace GeneradoresYPruebas.Api.Helpers;

public class DatosPruebaSerie
{
    public double Comparador { get; set; }
    public double[] ValoresU { get; set; }
    public double N { get; set; }
    public double X { get; set; }

    public DatosPruebaSerie(double comparador, double[] valoresU, double n, double x)
    {
        Comparador = comparador;
        ValoresU = valoresU;
        N = n;
        X = x;
    }
}
