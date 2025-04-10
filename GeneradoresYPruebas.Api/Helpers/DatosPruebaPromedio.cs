namespace GeneradoresYPruebas.Api.Helpers;

public class DatosPruebaPromedio
{
    public double Comparador {  get; set; }
    public double[] ValoresU {  get; set; }

    public DatosPruebaPromedio(double comparador, double[] valoresU)
    {
        Comparador = comparador;
        ValoresU = valoresU;
    }
}
