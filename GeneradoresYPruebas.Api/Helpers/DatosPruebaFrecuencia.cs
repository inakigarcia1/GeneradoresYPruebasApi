namespace GeneradoresYPruebas.Api.Helpers;

public class DatosPruebaFrecuencia
{
    public double Comparador {  get; set; }
    public double[] ValoresU {  get; set; }
    public int X { get; set; }

    public DatosPruebaFrecuencia(double comparador, double[] valoresU, int x)
    {
        Comparador = comparador;
        ValoresU = valoresU;
        X = x;
    }
}
